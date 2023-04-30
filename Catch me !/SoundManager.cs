
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Catch_me__
{
    public class SoundManager
    {
      public  //at kell irjam mediaplayerre mert nincs volume ....
        WindowsMediaPlayer button = new WindowsMediaPlayer();
      public  
        WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        //static SoundPlayer backgroundMusic = new SoundPlayer("music.wav");
        bool isMusic;
        bool isSfx;
        int volMusic;
        int volSfx;
        public SoundManager()
        {
            if (File.Exists(@"sounds\\music.mp3") == false) MessageBox.Show("Background Music not found!");
            if (File.Exists(@"sounds\\click.mp3") == false) MessageBox.Show("Button click sound not found!");
            #region musicPlayerInit
            //music
            musicPlayer.URL = @"sounds\\music.mp3";
            musicPlayer.settings.playCount = 9999;
            musicPlayer.controls.stop();

            //butt
            button.URL = @"sounds\\click.mp3";
          //  musicPlayer.settings.playCount = 9999;
            button.controls.stop();


            #endregion


            loadSettings();


        }

        public void PlayClick()
        {
            if(isSfx)
            button.controls.play();
        }
        public void backgroundMusicStart()///lehet hogy innen fogom csheckolni hogy mi s hogy van a bealitasokba elmentve
        {

            if(isMusic)
            musicPlayer.controls.play();
        }
        public void backgroundMusicPause()
        {
             musicPlayer.controls.pause();
        }
        public void backgroundMusicVolumeAdjust(int value)
        {
             musicPlayer.settings.volume=value; 
        }
        public void buttonVolumeAdjust(int value)
        {
            button.settings.volume= value;
        }
        public void musicEnabled(bool val)
        {
           
            if(val==false&& isMusic==true)
            {
                backgroundMusicPause();
            }
          else if(val==true&&isMusic==false)
            {
                isMusic = val;
                backgroundMusicStart();
            }
            isMusic = val;
        }
        public void sfxenabled(bool val)
        {
            isSfx= val;
        }
        public void loadSettings()
        {
            this.isMusic = GlobalVar.IsMusic;
            this.isSfx = GlobalVar.IsSounds;
            this.volMusic = GlobalVar.MusicBarValue;
            this.volSfx = GlobalVar.SoundBarValue;

            musicPlayer.settings.volume = volMusic;
            button.settings.volume= volSfx; ; //nem letezik ilyen....


        }

    }
}

