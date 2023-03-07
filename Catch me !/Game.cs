using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_me__
{
    public partial class Game : UserControl
    {
        #region Variables
        OpenFileDialog fileDialog;
        string fileContent = string.Empty;
        string filePath = string.Empty;
        Board b;
        int cellSize = 16;
        #endregion

        public Game()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // fileDialog=new OpenFileDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            
        }

     
        private void Game_Load(object sender, EventArgs e)
        {
           b = new Board(panelGrid.Width,panelGrid.Height,cellSize);
            recalculatePixels();
         
            //kell egy uj board 
            //azon a boardon lesznek a cellek
            //a cellek szerint rendelelem ki a gridet......paint s bitmapokkal...
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
           // recalculatePixels();
            timerGame.Enabled=!timerGame.Enabled;
        }
        private void recalculatePixels()
        {
           b.setCellSize(cellSize);
            b.CalculateGrid();
            panelGrid.Image = b.GetBitmap();
        }
        private void updatePixels()
        {
            b.UpdateGrid();
            panelGrid.Image = b.GetBitmap();

        }
        private void Game_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.OldValue > e.NewValue)
            {
                cellSize--;
            }
            else
            {
                cellSize++;
            }
            recalculatePixels();
        }

        private void numericUpDownCellSize_ValueChanged(object sender, EventArgs e)
        {
            cellSize =(int) numericUpDownCellSize.Value;
           
        }

        private void panelGrid_Click(object sender, EventArgs e)
        {
          /*  MouseEventArgs me =  (MouseEventArgs)e;
            double j = Math.Ceiling(me.X / (double)cellSize)-1;
            double i = Math.Ceiling(me.Y / (double)cellSize)-1;
            labelTest.Text = String.Format("X: {0} Y: {1}\n J: {2}   I: {3}\n N:{4}", me.X, me.Y,j, i,j+i*b.getCellsNumX());
            b.CellClicked((int)i,(int)j);
            updatePixels();*/
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            recalculatePixels();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            b.checkLogic();
            updatePixels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.checkLogic();
            updatePixels();
        }


     
        private void panelGrid_MouseDown(object sender, MouseEventArgs e)
        {
           
            MouseEventArgs me = (MouseEventArgs)e;
            double j = Math.Ceiling(me.X / (double)cellSize) - 1;
            double i = Math.Ceiling(me.Y / (double)cellSize) - 1;
            labelTest.Text = String.Format("X: {0} Y: {1}\n J: {2}   I: {3}\n N:{4}", me.X, me.Y, j, i, j + i * b.getCellsNumX());
            b.CellClicked((int)i, (int)j);
            updatePixels();
        }

        private void panelGrid_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void timerMouseHold_Tick(object sender, EventArgs e)
        {

            MouseEventArgs me = (MouseEventArgs)e;
            double j = Math.Ceiling(me.X / (double)cellSize) - 1;
            double i = Math.Ceiling(me.Y / (double)cellSize) - 1;
            labelTest.Text = String.Format("X: {0} Y: {1}\n J: {2}   I: {3}\n N:{4}", me.X, me.Y, j, i, j + i * b.getCellsNumX());
            b.CellClicked((int)i, (int)j);
            updatePixels();
        }

        private void panelGrid_MouseHover(object sender, EventArgs e)
        {
            //
            //panelGrid_MouseUp(this.panelGrid, e);
            
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           SaveFileDialog sfd=new SaveFileDialog();
            sfd.Filter = "hello|*.igen";
            sfd.Title="Save the current state of the grid!";
           

          
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.OpenFile());
                sw.WriteLine(b.getCellsNumX());
              foreach
            sw.Write(b.cells);
                sw.Close();
            }
            
        }
    }
}
