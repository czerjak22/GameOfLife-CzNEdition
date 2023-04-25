namespace Catch_me__
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.mainMenuStatic = new Catch_me__.MainMenu(Sounds);
            this.controlPanelStatic = new Catch_me__.ControlPanel(Sounds);
            this.customMenuStatic = new Catch_me__.CustomMenu(Sounds);
            this.game = new Catch_me__.Game(Sounds);
            this.SuspendLayout();
            // 
            // mainMenuStatic
            // 
            this.mainMenuStatic.BackColor = System.Drawing.Color.IndianRed;
            this.mainMenuStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuStatic.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStatic.Margin = new System.Windows.Forms.Padding(4);
            this.mainMenuStatic.Name = "mainMenuStatic";
            this.mainMenuStatic.Size = new System.Drawing.Size(615, 544);
            this.mainMenuStatic.TabIndex = 1;
            // 
            // controlPanelStatic
            // 
            this.controlPanelStatic.BackColor = System.Drawing.Color.Coral;
            this.controlPanelStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanelStatic.Location = new System.Drawing.Point(0, 0);
            this.controlPanelStatic.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanelStatic.Name = "controlPanelStatic";
            this.controlPanelStatic.Size = new System.Drawing.Size(615, 544);
            this.controlPanelStatic.TabIndex = 0;
            this.controlPanelStatic.Visible = false;
            // 
            // customMenuStatic
            // 
            this.customMenuStatic.BackColor = System.Drawing.Color.Tomato;
            this.customMenuStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customMenuStatic.Location = new System.Drawing.Point(0, 0);
            this.customMenuStatic.Name = "customMenuStatic";
            this.customMenuStatic.Size = new System.Drawing.Size(615, 544);
            this.customMenuStatic.TabIndex = 2;
            this.customMenuStatic.Visible = false;
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Margin = new System.Windows.Forms.Padding(4);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(615, 544);
            this.game.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(615, 544);
            this.Controls.Add(this.mainMenuStatic);
            this.Controls.Add(this.controlPanelStatic);
            this.Controls.Add(this.customMenuStatic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(633, 591);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch me!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

		}


        #endregion

       
        private ControlPanel controlPanelStatic;
        private MainMenu mainMenuStatic;
        private CustomMenu customMenuStatic;
    }
}

