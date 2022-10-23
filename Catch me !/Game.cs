using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_me__
{
    public partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            button.Location = new Point(r.Next(0, this.Width - button.Width),r.Next(0,this.Height-button.Height));
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You caught me!", "Congrats!");
            
            this.Visible = false;

            var p = Parent.Controls.OfType<MainMenu>().FirstOrDefault();

            if (p != null) p.Visible = true;
        }
    }
}
