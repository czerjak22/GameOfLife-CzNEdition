using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_me__
{
  
    internal class Board
    {
        public static bool gridOn = true;
        int height;
        int width;

        int cellsNumX;
        int cellsNumY;
        Color cellActive = Color.White;
        Color cellInActiv = Color.Black;
        Color border = Color.Violet;
        Color initCell= Color.Blue;
        int cellSize;
        int minCellBorder = 5;
        public Cell[,] cells;

        List<Tuple<Cell,Tuple<int,int>>> valtoztatottCellak;

        Bitmap bmp;



        #region gettersSetters

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public Bitmap GetBitmap()
        {
            return bmp;
        }
        public void SetBitmap(Bitmap b)
        {
            bmp = b;
        }

        public void setCellSize(int cellSize)
        {
            this.cellSize = cellSize;
        }
        public int getCellSize()
        {
            return cellSize;
        }
        public int getCellsNumY()
        {
            return cellsNumY;
        }

        public int getCellsNumX()
        {
            return cellsNumX;
        }

        /// <summary>
        /// it return the widt that was initialized with the board
        /// </summary>
        /// <returns></returns>
        public int getWidth()
        {
            return width;
        }
        #endregion

        public Board(int width, int height, int cellSize)
        {
            this.height = height;
            this.width = width;
            this.cellSize = cellSize;
            valtoztatottCellak = new List<Tuple<Cell, Tuple<int, int>>>();
            cellActive = GlobalVar.CellActive;
            cellInActiv = GlobalVar.CellInactive;
            border = GlobalVar.Border;
            //   initCell= GlobalVar.InitCell;//kiszedtem ezt a featuret
            initCell = GlobalVar.CellInactive;
        }


        public void CalculateGrid()
        {
           
                cellsNumX = width / cellSize;
                cellsNumY = height / cellSize;

                cells = new Cell[cellsNumY, cellsNumX];
                bmp = new Bitmap(width, height);
            //regi for
          //  for (int i = 0; i < cellsNumY; i++)
                Parallel.For(0, cellsNumY, i =>    //elvileg gyorsabb mert multithread
             {
                 for (int j = 0; j < cellsNumX; j++)
                 {
                     cells[i, j] = new Cell();
                     cells[i, j].IsAlive = false;
                 }
             });
                CellsInit();
            
        }

        public void CalculateGridSaveOld()
        {
            if (cells == null)//ha legelsobszor van meghivva mikor meg nem volt a cell , nincs mit elmentsen , genarald le uresen a cellakat
            {
                CalculateGrid();
                return;
            }
            //lehet hogy lassu leszszz...
          //elmentem a valuekat egy seged tombe
            bool[,] seged=new bool[cellsNumY, cellsNumX];
            Parallel.For(0, cellsNumY, i =>    //elvileg gyorsabb mert multithread
            {
                for (int j = 0; j < cellsNumX; j++)
                {
                    seged[i, j] = cells[i,j].IsAlive;
                }
            });

            cellsNumX = width / cellSize;
            cellsNumY = height / cellSize;
            cells = new Cell[cellsNumY, cellsNumX];
            bmp = new Bitmap(width, height);



            Parallel.For(0, cellsNumY, i =>    //elvileg gyorsabb mert multithread
            {
                for (int j = 0; j < cellsNumX; j++)
                {
                    cells[i, j] = new Cell();
                    try
                    {
                        cells[i, j].IsAlive = seged[i, j];
                    }catch(Exception e)
                    {
                        cells[i, j].IsAlive=false;
                    }
                }
            });
            Parallel.For(0, cellsNumY, i =>
            {
                for (int j = 0; j < cellsNumX; j++)

                {
                    getNeigbores(j, i);/// cella nem kell tudja a szomszedjait azt kulon le kell checkolni....

                }
            });
            UpdateAllGrid();
        }
        //csak azokat a helyeket nezi ahol kell valamit csinalni...
        public void UpdateGridPart()
        {

            foreach (Tuple<Cell, Tuple<int, int>> c in valtoztatottCellak) {
                ////                                           j  --------->   i

                switch (gridOn)
                {
                    case true:

                        if (cells[c.Item2.Item1, c.Item2.Item2].IsAlive) FillCellWBorder(c.Item2.Item2, c.Item2.Item1,cellActive,border);
                        else FillCellWBorder(c.Item2.Item2, c.Item2.Item1, cellInActiv,border);
                        break; 
                    case false:

                        if (cells[c.Item2.Item1, c.Item2.Item2].IsAlive) FillCell(c.Item2.Item2, c.Item2.Item1, cellActive);
                        else FillCell(c.Item2.Item2, c.Item2.Item1,cellInActiv);
                        break;

                }
            }
                valtoztatottCellak.Clear();
            
                
        }
           

           

       
        //eredeti nem modifikalt
        public void UpdateAllGrid()
        {
            if (gridOn && cellSize > minCellBorder)
            {
                for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX
                {
                    for (int j = 0; j < cellsNumX; j++)
                    {
                        if (cells[i, j].IsAlive) FillCellWBorder(j, i, cellActive, border);
                        else FillCellWBorder(j, i, cellInActiv, border);
                    }
                }
            }
            else
            {
                for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX
                {
                    for (int j = 0; j < cellsNumX; j++)
                    {
                        if (cells[i, j].IsAlive) FillCell(j, i,cellActive);
                        else FillCell(j, i, cellInActiv);
                    }
                }
            }




        }
        public void CellClicked(int i,int j)
        {
            try
            {

                cells[i, j].IsAlive = !cells[i, j].IsAlive;

                //uj modifikalas
                valtoztatottCellak.Add(Tuple.Create(cells[i, j], Tuple.Create(i, j)));
            }
            catch (Exception e){
             //   Console.log("Cells clicked fugvenybe");
            }
        }
      
        //kell initializalni a celleket s a szomszedjaikat
        //a listanak a nagysagat le kell fixelni

        //vagy veszek egy panelnyi bitmappet s abba a bvixel sizeokat cserelem ,
        //vagy veszek egy cellanyi bitmapet amit majd scalelek....
        public void CellsInit()
        {
           

            for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX

            {
                for (int j = 0; j < cellsNumX; j++)
                {
                   
                    if (gridOn && cellSize > minCellBorder)
                        FillCellWBorder(j, (int)i, initCell, border);
                    else
                        FillCell(j, i, initCell);
                }
            }

            // for(int i=0;i<cellsNumY;i++) ////itt a cellak szamaig kell menjek a cellsNumX
            Parallel.For(0, cellsNumY, i =>
           {
               for (int j = 0; j < cellsNumX; j++)

               {
                   getNeigbores(j, i);/// cella nem kell tudja a szomszedjait azt kulon le kell checkolni....

               }
           });

        }

       

        private void getNeigbores(int j ,int i)
        {
           
            int minSor = i - 1 < 0 ? i : i - 1;
            int maxSor = i +1 > cells.GetLength(0) ? i : i + 1;
            int minOsz = j - 1 < 0 ? j : j - 1;
            int maxOsz = j + 1 > cells.GetLength(1) ? j : j + 1;
            for(int h=minSor;h<=maxSor;h++)
           // Parallel.For(minSor,maxSor+1,h=>
            {
                for(int k=minOsz;k<=maxOsz;k++ )
                {
                    if(CellExists(h,k) && (h != i || k != j))
                    {           
                        cells[i, j].Szomszedok.Add(cells[h, k]);
                    }
                }
            }//);
          
        }

        private bool CellExists( int i,int j)
        {
            try
            {
                if (cells[i, j].IsAlive) { };
                return true;
            }
            catch(Exception e) 
            {
                return false; 
            }
           
        }

        
        private   void FillCellWBorder(int x,int y,Color cell,Color border)
        {
            for (int i = 0; i < cellSize; i++)
            {
                for (int j = 0; j < cellSize; j++)
                {
                    if(j==0||i==0) bmp.SetPixel(x * cellSize + i, y * cellSize + j, border);
                    else
                        bmp.SetPixel(x*cellSize+i, y*cellSize+j, cell);
                }
            }

            bmp.SetPixel(bmp.Width / 2, bmp.Height / 2, Color.Red);
        }

        private void FillCell(int x, int y, Color cell)
        {
            for (int i = 0; i < cellSize; i++)
            {
                for (int j = 0; j < cellSize; j++)
                {
                   
                   
                        bmp.SetPixel(x * cellSize + i, y * cellSize + j, cell);
                }
            }
            bmp.SetPixel(bmp.Width / 2, bmp.Height / 2, Color.Red);
        }

       
       public void checkLogic()
        {
           
            for(int i = 0; i < cells.GetLength(0); i++)
            {
                for(int j=0;j< cells.GetLength(1);j++)
                {
                    if (cells[i, j].check())
                    {
                        valtoztatottCellak.Add(Tuple.Create(cells[i,j],Tuple.Create(i, j)));
                    }
                }
            }

            //vector vagy queue be tarolom a megvaltoztatott cellakat s csak ott updatelelem a bitmapet
            foreach (Tuple<Cell,Tuple<int,int>> c in valtoztatottCellak)
            {
                c.Item1.update();
            }
           
        }
        public void resetAllCellsState()
        {
            foreach(Cell c in cells)
            {
                c.IsAlive = false;
                c.IsAliveNext = false;
             
            }
            for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX

            {
                for (int j = 0; j < cellsNumX; j++)
                {

                    if (cellSize > minCellBorder)
                        FillCellWBorder(j, (int)i, cellInActiv, border);
                    else
                        FillCell(j, i, cellInActiv);
                }
            }
        }
    }
}


