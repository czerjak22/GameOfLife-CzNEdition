using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_me__
{
    public partial class ControlPanel : UserControl
    {
        public ControlPanel()
        {
            InitializeComponent();
            InitializeValues();

        }

        private void InitializeValues()
        {
            musicCkb.Checked = GlobalVar.IsMusic;
            musicBar.Enabled = musicCkb.Checked;
            soundsCkb.Checked = GlobalVar.IsSounds;
            soundBar.Enabled = soundsCkb.Checked;

            soundBar.Value = GlobalVar.SoundBarValue;
            musicBar.Value = GlobalVar.MusicBarValue;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
             this.Visible = false;

            var p = Parent.Controls.OfType<MainMenu>().FirstOrDefault();

            if (p != null) p.Visible = true;
        }

        private void musicCkb_CheckedChanged(object sender, EventArgs e)
        {
           
            musicBar.Enabled = musicCkb.Checked;
            GlobalVar.IsMusic = musicCkb.Checked;

        }

        private void musicCkb_VisibleChanged(object sender, EventArgs e)
        {
            InitializeValues();
        }

        private void soundsCkb_CheckedChanged(object sender, EventArgs e)
        {
            soundBar.Enabled = soundsCkb.Checked;
            GlobalVar.IsSounds = soundsCkb.Checked;
        }

        private void soundBar_Scroll(object sender, EventArgs e)
        {
            //ide meg kell irjam az ertek a menteset 
            GlobalVar.SoundBarValue=soundBar.Value;
          
        }

        private void musicBar_Scroll(object sender, EventArgs e)
        {
           GlobalVar.MusicBarValue=musicBar.Value;  
        }
    }
}
