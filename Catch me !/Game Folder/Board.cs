using System;
using System.Collections.Generic;
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

        int height;
        int width;

        int cellsNumX;
        int cellsNumY;

        int cellSize;
        int minCellBorder = 5;
        public Cell[,] cells;
        Bitmap bmp;
        public Board(int width,int height,int cellSize) 
        {
            this.height = height;
            this.width = width;
            this.cellSize = cellSize;
            
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

        public void UpdateGrid()
        {
            if (cellSize > minCellBorder)
            {
                     for (int i = 0; i < cellsNumY; i++) ////itt a cellak szamaig kell menjek a cellsNumX
                {
                    for (int j = 0; j < cellsNumX; j++)
                    {
                        if (cells[i,j].IsAlive) FillCellWBorder(j, i, Color.White,Color.Violet);
                        else FillCellWBorder(j, i, Color.Black,Color.Violet);
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
            cells[i, j].IsAlive = !cells[i, j].IsAlive;
        }
     public Bitmap GetBitmap()
        {
            return bmp;
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
        
          
            for(int i=0;i<cellsNumY;i++) ////itt a cellak szamaig kell menjek a cellsNumX
            {
                for(int j=0;j<cellsNumX;j++)
                {
                    /* if (r.Next(0, 2) == 1)
                         FillCell(j,i,Color.Aqua);
                     else FillCell(j,i,Color.Black);*/
                    if(cellSize> minCellBorder)
                    FillCellWBorder(j, i, Color.Yellow,Color.Black);
                    else
                        FillCell(j, i, Color.Yellow);
                    getNeigbores(j,i);/// cella nem kell tudja a szomszedjait azt kulon le kell checkolni....

                }
            }

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


        private void FillCellWBorder(int x,int y,Color cell,Color border)
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


        internal void checkLogic()
        {
           
            for(int i = 0; i < cells.GetLength(0); i++)
            {
                for(int j=0;j< cells.GetLength(1);j++)
                {
                    cells[i, j].check();
                }
            }
               
            
            foreach (Cell c in cells)
            {
                c.update();
            }
           
        }
    }
}
