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

namespace CIG
{
    public partial class ControlPanel : UserControl
    {
        SoundManager sfx;
        public ControlPanel(SoundManager s)
        {
            sfx = s;
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
            sfx.PlayClick();
            var p = Parent.Controls.OfType<MainMenu>().FirstOrDefault();

            if (p != null) p.Visible = true;
        }

        private void musicCkb_CheckedChanged(object sender, EventArgs e)
        {
           
            musicBar.Enabled = musicCkb.Checked;
            GlobalVar.IsMusic = musicCkb.Checked;
            sfx.musicEnabled(musicCkb.Checked);

        }

        private void musicCkb_VisibleChanged(object sender, EventArgs e)
        {
            InitializeValues();
        }

        private void soundsCkb_CheckedChanged(object sender, EventArgs e)
        {
            soundBar.Enabled = soundsCkb.Checked;
            GlobalVar.IsSounds = soundsCkb.Checked;
            sfx.sfxenabled(soundsCkb.Checked);
        }

        private void soundBar_Scroll(object sender, EventArgs e)
        {
            //ide meg kell irjam az ertek a menteset 
            GlobalVar.SoundBarValue=soundBar.Value;
            sfx.buttonVolumeAdjust(soundBar.Value);
        }

        private void musicBar_Scroll(object sender, EventArgs e)
        {
           GlobalVar.MusicBarValue=musicBar.Value;
            sfx.backgroundMusicVolumeAdjust(musicBar.Value);
        }
    }
}
