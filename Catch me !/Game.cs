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


        //drag
        bool mouseIsDown = false;
        bool mouseDrag = false;
        Point lastModifyedCell = new Point(-1, -1);
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


                StreamReader reader = new StreamReader(openFileDialog.OpenFile());

                //itt egyszer el kell dontsem hogy mit savelek hogy tudjam beolvasni   
                int seged = -1;
                int.TryParse(reader.ReadLine(), out seged);
                if(seged!= -1)
                {
                    cellSize= seged;
                    numericUpDownCellSize.Value = cellSize;
                    recalculatePixels();
                    foreach (Cell c in b.cells)
                    {
                        c.IsAlive = bool.Parse(reader.ReadLine());
                    }
                    b.UpdateGrid();
                    panelGrid.Image = b.GetBitmap();
                }
                else
                {
                    MessageBox.Show("Invalid file type!\n...\nLoad another file!");
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
            if(buttonTimer.Text=="Start")
            {
                buttonTimer.Text = "Stop";
                buttonIterate.Enabled = false;
            }
            else
            {
                buttonTimer.Text = "Start";
                buttonIterate.Enabled = true;
            }
               
        


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
        bool megvaltozott = false;
        private void numericUpDownCellSize_ValueChanged(object sender, EventArgs e)
        {
            cellSize =(int) numericUpDownCellSize.Value;
            megvaltozott = true;
           
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (megvaltozott)
            { 
            recalculatePixels();
                megvaltozott=false;
        }
            else
            {
            b.resetAllCellsState();
                panelGrid.Image = b.GetBitmap();
            }
               timerGame.Stop();
            buttonTimer.Text = "Start";
            buttonIterate.Enabled = true;

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
            alterCellState(e);
            if(mouseDrag)
            mouseIsDown= true;
        }

        private void alterCellState(MouseEventArgs me)
        {
            double j = Math.Ceiling(me.X / (double)cellSize) - 1;
            double i = Math.Ceiling(me.Y / (double)cellSize) - 1;
            if(lastModifyedCell.X==j&&lastModifyedCell.Y==i)
            {
                return;
            }
            //ideeee......
            labelTest.Text = String.Format("X: {0} Y: {1}\n J: {2}   I: {3}\n N:{4}", me.X, me.Y, j, i, j + i * b.getCellsNumX());
            b.CellClicked((int)i, (int)j);
            updatePixels();
            ///idaig...... kene egy vectrot felvegyek amibe a megvaltozando cellakat eltarolom egyszerre vegigfutok
            /////s azutan egyszer updateolom a bitmapet
            //jah s kene egy bitmap feedbekk
            //talan egy vonal >< ---mas thread ? nagyon meg akarom neheziteni az eletem><

            lastModifyedCell = new Point((int)j, (int)i);


        }
        private void panelGrid_MouseUp(object sender, MouseEventArgs e)
        {
           mouseIsDown= false;
            lastModifyedCell = new Point(-1,-1);
        }

        private void panelGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseIsDown)
            {
                alterCellState(e);
            }
        }

        private void timerMouseHold_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Megy!");
            MouseEventArgs me = (MouseEventArgs)e;
            double j = Math.Ceiling(me.X / (double)cellSize) - 1;
            double i = Math.Ceiling(me.Y / (double)cellSize) - 1;
            labelTest.Text = String.Format("X: {0} Y: {1}\n J: {2}   I: {3}\n N:{4}", me.X, me.Y, j, i, j + i * b.getCellsNumX());
            b.CellClicked((int)i, (int)j);
            updatePixels();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
           SaveFileDialog sfd=new SaveFileDialog();
            sfd.Filter = "hello|*.igen";
            sfd.Title="Save the current state of the grid!";
           

          
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.OpenFile());
                sw.WriteLine(b.getCellSize());
              foreach(Cell c in b.cells)
                {
                    sw.WriteLine(c.IsAlive);
                }
          
                sw.Close();
            }
            
        }

        private void checkBoxDrag_CheckedChanged(object sender, EventArgs e)
        {
            mouseDrag=checkBoxDrag.Checked;
        }

        
    }
}
