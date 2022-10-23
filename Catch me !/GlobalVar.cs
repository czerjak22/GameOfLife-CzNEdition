using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

       

        public static bool IsMusic { get => isMusic; set => isMusic = value; }
        public static bool IsSounds { get => isSounds; set => isSounds = value; }

        public static void SaveToFile()
        {
            StreamWriter ki = new StreamWriter("ki.txt");
            //kiiratom az adott adatokat ugy ahogy akarom 
            ///konvenciom nev space adat;
            ki.WriteLine("isMusic " + isMusic.ToString());
            ki.WriteLine("isSounds " + isSounds.ToString());
            ki.Close();

        }
        public static void readFromFile()
        {
            StreamReader be = new StreamReader("ki.txt");
            string[] lines = be.ReadToEnd().Trim().Split(new string[] { "\r\n" },StringSplitOptions.None);
            foreach (string i in lines)
            {

                ///kulon functioba kell rakjam eztet 
                ///newm szeretem az iffes megoldast....
                ///nincsen mas otletem
               // MessageBox.Show(i);
                if (i.Contains("isMusic"))
                {
                    isMusic = bool.Parse(i.Replace("isMusic ", "").Trim());
                   // MessageBox.Show(bool.Parse(i.Replace("isMusic ", "").Trim()).ToString());
                }
                if (i.Contains("isSounds"))
                {
                    isSounds = bool.Parse(i.Replace("isSounds ", "").Trim());
                 //   MessageBox.Show(bool.Parse(i.Replace("isSounds ", "").Trim()).ToString());
                }

            }
            be.Close();
        }


    }
}
