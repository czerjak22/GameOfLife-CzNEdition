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
	public partial class Form1 : Form
	{
        public Form1()
		{
			InitializeComponent();
			//MainPanel();
        }
		/*
		//putton higlighten sond play generally made....
		private void playBtn_Click(object sender, EventArgs e)
		{
			//kene uj panelt tudni inportalni....
			
		}

		private void optionsBtn_Click(object sender, EventArgs e)
		{
			//kene uj panelt tudni inportalni....
			
		}


		private void mainActraction_Click(object sender, EventArgs e)
		{
			//kene animaljak
		}*/
		void MainPanel()
		{
			MainMenu control = new MainMenu();
			control.Dock = DockStyle.Fill;
			control.Visible = true;
			control.Enabled = true;

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
	}
}
