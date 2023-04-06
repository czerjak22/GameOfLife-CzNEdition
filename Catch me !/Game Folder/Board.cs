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

        int cellSize;
        int minCellBorder = 5;
        public Cell[,] cells;

        List<Tuple<Cell,Tuple<int,int>>> valtoztatottCellak;

        Bitmap bmp;

        public Board(int width,int height,int cellSize) 
        {
            this.height = height;
            this.width = width;
            this.cellSize = cellSize;
            valtoztatottCellak = new List<Tuple<Cell,Tuple<int,int>>>();
        }
        public int getCellsNumY()
        {
            return cellsNumY;   
        } 
        public int getCellsNumX()
        {
            return cellsNumX;   
        }
        public void CalculateGrid()
        {
           cellsNumX=width/cellSize;
           //cellsNumX=1000;
           //cellsNumX=1000;
            cellsNumY=height/cellSize;
          
            cells=new Cell[cellsNumY,cellsNumX];
            bmp= new Bitmap(width,height);
            for(int i=0; i<cellsNumY; i++)
            {
                for(int j=0;j<cellsNumX;j++)
                {
                    cells[i,j] = new Cell();
                    cells[i,j].IsAlive = false;
                }
            }
            CellsInit();
            
        }
        //idk temporalis
        public void UpdateGrid()
        {
           
                foreach (Tuple<Cell,Tuple<int,int>> c in valtoztatottCellak)
                {////                                           j  --------->   i
                    if (cells[c.Item2.Item1, c.Item2.Item2].IsAlive) FillCellWBorder(c.Item2.Item2, c.Item2.Item1, Color.White, Color.Violet);
                    else FillCellWBorder(c.Item2.Item2, c.Item2.Item1, Color.Black, Color.Violet);
                }
                valtoztatottCellak.Clear();
                
        }
           

           

       
        //eredeti nem modifikalt
        public void UpdateGrid2()
        {
            if (gridOn && cellSize > minCellBorder)
            {
                for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX
                {
                    for (int j = 0; j < cellsNumX; j++)
                    {
                        if (cells[i, j].IsAlive) FillCellWBorder(j, i, Color.White, Color.Violet);
                        else FillCellWBorder(j, i, Color.Black, Color.Violet);
                    }
                }
            }
            else
            {
                for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX
                {
                    for (int j = 0; j < cellsNumX; j++)
                    {
                        if (cells[i, j].IsAlive) FillCell(j, i, Color.White);
                        else FillCell(j, i, Color.Black);
                    }
                }
            }




        }
        public void CellClicked(int i,int j)
        {
            try
            {

                cells[i, j].IsAlive = !cells[i, j].IsAlive;
            }
            catch (Exception e){
           
            }
        }

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
        //kell initializalni a celleket s a szomszedjaikat
        //a listanak a nagysagat le kell fixelni

        //vagy veszek egy panelnyi bitmappet s abba a bvixel sizeokat cserelem ,
        //vagy veszek egy cellanyi bitmapet amit majd scalelek....
        public void CellsInit()
        {
            Random r= new Random();

            for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX

            {
                for (int j = 0; j < cellsNumX; j++)
                {
                   
                    if (gridOn && cellSize > minCellBorder)
                        FillCellWBorder(j, (int)i, Color.Yellow, Color.Black);
                    else
                        FillCell(j, i, Color.Yellow);
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
            {
                for(int k=minOsz;k<=maxOsz;k++ )
                {
                    if(CellExists(h,k) && (h != i || k != j))
                    {           
                        cells[i, j].Szomszedok.Add(cells[h, k]);
                    }
                }
            }
          
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
                        FillCellWBorder(j, (int)i, Color.Yellow, Color.Black);
                    else
                        FillCell(j, i, Color.Yellow);
                }
            }
        }
    }
}


