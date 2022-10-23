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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
           // playBtn.Location=new Point(Width/2,playBtn.Location.Y);

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;   

        }

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var p = Parent.Controls.OfType<ControlPanel>().FirstOrDefault();

            if (p != null) p.Visible = true;

        }
    }
}
