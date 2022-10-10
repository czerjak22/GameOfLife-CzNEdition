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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.playBtn = new System.Windows.Forms.Button();
			this.optionsBtn = new System.Windows.Forms.Button();
			this.costumizeBtn = new System.Windows.Forms.Button();
			this.moneyName = new System.Windows.Forms.Label();
			this.moneyNum = new System.Windows.Forms.Label();
			this.mainActraction = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.mainActraction)).BeginInit();
			this.SuspendLayout();
			// 
			// playBtn
			// 
			this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.playBtn.BackColor = System.Drawing.Color.Transparent;
			this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.playBtn.Location = new System.Drawing.Point(64, 168);
			this.playBtn.MinimumSize = new System.Drawing.Size(10, 30);
			this.playBtn.Name = "playBtn";
			this.playBtn.Size = new System.Drawing.Size(339, 64);
			this.playBtn.TabIndex = 0;
			this.playBtn.Text = "Play";
			this.playBtn.UseVisualStyleBackColor = false;
			this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
			// 
			// optionsBtn
			// 
			this.optionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.optionsBtn.BackColor = System.Drawing.Color.Transparent;
			this.optionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.optionsBtn.Location = new System.Drawing.Point(64, 247);
			this.optionsBtn.MinimumSize = new System.Drawing.Size(10, 30);
			this.optionsBtn.Name = "optionsBtn";
			this.optionsBtn.Size = new System.Drawing.Size(339, 64);
			this.optionsBtn.TabIndex = 1;
			this.optionsBtn.Text = "Options";
			this.optionsBtn.UseVisualStyleBackColor = false;
			this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
			// 
			// costumizeBtn
			// 
			this.costumizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.costumizeBtn.BackColor = System.Drawing.Color.Transparent;
			this.costumizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.costumizeBtn.Location = new System.Drawing.Point(64, 333);
			this.costumizeBtn.MinimumSize = new System.Drawing.Size(10, 30);
			this.costumizeBtn.Name = "costumizeBtn";
			this.costumizeBtn.Size = new System.Drawing.Size(339, 64);
			this.costumizeBtn.TabIndex = 2;
			this.costumizeBtn.Text = "Customize";
			this.costumizeBtn.UseVisualStyleBackColor = false;
			this.costumizeBtn.Click += new System.EventHandler(this.costumizeBtn_Click);
			// 
			// moneyName
			// 
			this.moneyName.AutoSize = true;
			this.moneyName.Location = new System.Drawing.Point(353, 20);
			this.moneyName.Name = "moneyName";
			this.moneyName.Size = new System.Drawing.Size(39, 13);
			this.moneyName.TabIndex = 3;
			this.moneyName.Text = "Money";
			// 
			// moneyNum
			// 
			this.moneyNum.AutoSize = true;
			this.moneyNum.Location = new System.Drawing.Point(399, 20);
			this.moneyNum.Name = "moneyNum";
			this.moneyNum.Size = new System.Drawing.Size(31, 13);
			this.moneyNum.TabIndex = 4;
			this.moneyNum.Text = "9999";
			// 
			// mainActraction
			// 
			this.mainActraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.mainActraction.Image = ((System.Drawing.Image)(resources.GetObject("mainActraction.Image")));
			this.mainActraction.Location = new System.Drawing.Point(167, 76);
			this.mainActraction.Name = "mainActraction";
			this.mainActraction.Size = new System.Drawing.Size(137, 64);
			this.mainActraction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.mainActraction.TabIndex = 5;
			this.mainActraction.TabStop = false;
			this.mainActraction.Click += new System.EventHandler(this.mainActraction_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(461, 442);
			this.Controls.Add(this.mainActraction);
			this.Controls.Add(this.moneyNum);
			this.Controls.Add(this.moneyName);
			this.Controls.Add(this.costumizeBtn);
			this.Controls.Add(this.optionsBtn);
			this.Controls.Add(this.playBtn);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Catch me!";
			((System.ComponentModel.ISupportInitialize)(this.mainActraction)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button playBtn;
		private System.Windows.Forms.Button optionsBtn;
		private System.Windows.Forms.Button costumizeBtn;
		private System.Windows.Forms.Label moneyName;
		private System.Windows.Forms.Label moneyNum;
		private System.Windows.Forms.PictureBox mainActraction;
	}
}

