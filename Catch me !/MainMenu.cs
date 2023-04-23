using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_me__
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();

            Select();//deselects all items

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //nem jo  mar a meglevo jatekot nyissa meg
            //torulnom kell a game user formot
            //s azutan egy ujat kell rakjak a helyebe

            /* var p = Parent.Controls.OfType<Game>().FirstOrDefault();

             if (p != null) p.Visible = true;
            */
            Form1 g = Parent.FindForm() as Form1;
            if (g == null) return;
            g.makeNewGame();
           
        }

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            var p = Parent.Controls.OfType<ControlPanel>().FirstOrDefault();

            if (p != null) p.Visible = true;

        }

      
    }
}
