﻿using System;
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
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
            GlobalVar.readFromFile();
            
            //ez nem megy mindig le talan tul rovid????
            //    SoundPlayer g = new SoundPlayer("igen.wav");
            // g.Play();
            //xd
            //SystemSounds.Hand.Play();



        }


        public void menuToOptions()
        {
            mainMenuStatic.Visible = false;
           	controlPanelStatic.Visible = true;

        }
        public void optionsToMenu()
        {
            mainMenuStatic.Visible = true;
            controlPanelStatic.Visible = false;
        }
        public void makeNewGame()
        {

            this.Controls.Remove(this.game);
            game = new Game();
            this.game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Name = "game1";
            this.game.Size = new System.Drawing.Size(461, 442);
            this.game.TabIndex = 2;
            this.Controls.Add(this.game);
            game.Dock=DockStyle.Fill;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ///elmentem az adatokat ugy ahogy vannak a globalvar be s mikor bezarom a formot akkor irom eyszerre ki egy fileba
            ///sorrend talan megleszi igy oldva
            ///nem lesz reduplikalas

            GlobalVar.SaveToFile();
        }

      
    }
}
