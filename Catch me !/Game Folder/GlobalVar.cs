using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Catch_me__
{
    internal static class GlobalVar
    {
        ///osztan ide kell majd addoljam lehet a
        ///mainmenu tions  es a game  UC okat <summary>
        /// osztan ide kell majd addoljam lehet a
        
        //Default values
        private static bool isMusic=true;
        private static bool isSounds = true;
        private static Int32 soundBarValue = 1;
        private static Int32 musicBarValue = 1;
        private static Color cellActive = Color.White;
        private static Color cellInactive = Color.Black;
        private static Color border = Color.Violet;
        private static Color initCell = Color.Blue;

        #region getters setters
        public static bool IsMusic { get => isMusic; set => isMusic = value; }
        public static bool IsSounds { get => isSounds; set => isSounds = value; }
        public static int SoundBarValue { get => soundBarValue; set => soundBarValue = value; }
        public static int MusicBarValue { get => musicBarValue; set => musicBarValue = value; }
        public static Color CellActive { get => cellActive; set => cellActive = value; }
        public static Color CellInactive { get => cellInactive; set => cellInactive = value; }
        public static Color Border { get => border; set => border = value; }
        public static Color InitCell { get => initCell; set => initCell = value; }
        #endregion
        public static void SaveToFile()
        {
            StreamWriter ki = new StreamWriter("ConfigFile.txt");
            //kiiratom az adott adatokat ugy ahogy akarom 
            ///konvenciom nev space adat;
            ki.WriteLine("isMusic " + isMusic.ToString());
            ki.WriteLine("isSounds " + isSounds.ToString());
            ki.WriteLine("soundBarValue " + soundBarValue.ToString());
            ki.WriteLine("musicBarValue " + musicBarValue.ToString());
            ki.WriteLine("color_cellActive " + cellActive.R.ToString() + " " + cellActive.G.ToString() + " " + cellActive.B.ToString());
            ki.WriteLine("color_cellInactive " + cellInactive.R.ToString() + " " + cellInactive.G.ToString() + " " + cellInactive.B.ToString());
            ki.WriteLine("color_border " + border.R.ToString() + " " + border.G.ToString() + " " + border.B.ToString());
            ki.WriteLine("color_initCell " + initCell.R.ToString() + " " + initCell.G.ToString() + " " + initCell.B.ToString());
            ki.Close();

        }

        public static void readFromFile()
        {
            StreamReader be = new StreamReader("ConfigFile.txt");
            string[] lines = be.ReadToEnd().Trim().Split(new string[] { "\r\n" },StringSplitOptions.None);
            foreach (string i in lines)
            {
               // lines[].IndexOfAny//mivan???
                ///kulon functioba kell rakjam eztet 
                ///newm szeretem az iffes megoldast....
                ///nincsen mas otletem
               // MessageBox.Show(i);
                if (i.Contains("isMusic"))
                {
                    isMusic = bool.Parse(i.Replace("isMusic ", "").Trim());
                   // MessageBox.Show(bool.Parse(i.Replace("isMusic ", "").Trim()).ToString());
                }
                else if (i.Contains("isSounds"))
                {
                    isSounds = bool.Parse(i.Replace("isSounds ", "").Trim());
                 //   MessageBox.Show(bool.Parse(i.Replace("isSounds ", "").Trim()).ToString());
                }
                else if(i.Contains("soundBarValue"))
                {
                    soundBarValue = Int32.Parse(i.Replace("soundBarValue", "").Trim());
                }
                else if (i.Contains("musicBarValue"))
                {
                    musicBarValue= Int32.Parse(i.Replace("musicBarValue", "").Trim());
                }
                else if (i.Contains("color_cellActive"))
                {
                    string[] k = i.Replace("color_cellActive", "").Trim().Split(' ');
                    int r = 0, g = 0, b = 0;
                     int.TryParse(k[0],out r);
                     int.TryParse(k[1],out g);
                     int.TryParse(k[2],out b);
                    cellActive = Color.FromArgb(r, g, b);
                  //  MessageBox.Show(cellActive.R.ToString() + " " + cellActive.G.ToString() + " " + cellActive.B.ToString());
                   
                }
                else if (i.Contains("color_cellInactive"))
                {
                    string[] k = i.Replace("color_cellInactive", "").Trim().Split(' ');
                    int r = 0, g = 0, b = 0;
                    int.TryParse(k[0], out r);
                    int.TryParse(k[1], out g);
                    int.TryParse(k[2], out b);
                    cellInactive = Color.FromArgb(r, g, b);
                    //  MessageBox.Show(cellActive.R.ToString() + " " + cellActive.G.ToString() + " " + cellActive.B.ToString());

                }
                else if (i.Contains("color_border"))
                {
                    string[] k = i.Replace("color_border", "").Trim().Split(' ');
                    int r = 0, g = 0, b = 0;
                    int.TryParse(k[0], out r);
                    int.TryParse(k[1], out g);
                    int.TryParse(k[2], out b);
                    border = Color.FromArgb(r, g, b);
                    //  MessageBox.Show(cellActive.R.ToString() + " " + cellActive.G.ToString() + " " + cellActive.B.ToString());

                }
                else if (i.Contains("color_initCell"))
                {
                    string[] k = i.Replace("color_initCell", "").Trim().Split(' ');
                    int r = 0, g = 0, b = 0;
                    int.TryParse(k[0], out r);
                    int.TryParse(k[1], out g);
                    int.TryParse(k[2], out b);
                    initCell = Color.FromArgb(r, g, b);
                    //  MessageBox.Show(cellActive.R.ToString() + " " + cellActive.G.ToString() + " " + cellActive.B.ToString());

                }



            }
            be.Close();
        }


    }
}
