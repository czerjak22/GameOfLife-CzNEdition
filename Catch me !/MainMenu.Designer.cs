namespace Catch_me__
{
    partial class MainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.costumizeBtn = new System.Windows.Forms.Button();
            this.mainActraction = new System.Windows.Forms.PictureBox();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainActraction)).BeginInit();
            this.SuspendLayout();
            // 
            // costumizeBtn
            // 
            this.costumizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.costumizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.costumizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costumizeBtn.Location = new System.Drawing.Point(81, 427);
            this.costumizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.costumizeBtn.MinimumSize = new System.Drawing.Size(13, 37);
            this.costumizeBtn.Name = "costumizeBtn";
            this.costumizeBtn.Size = new System.Drawing.Size(452, 79);
            this.costumizeBtn.TabIndex = 18;
            this.costumizeBtn.TabStop = false;
            this.costumizeBtn.Text = "Customize";
            this.costumizeBtn.UseVisualStyleBackColor = false;
            this.costumizeBtn.Click += new System.EventHandler(this.costumizeBtn_Click);
            // 
            // mainActraction
            // 
            this.mainActraction.BackColor = System.Drawing.Color.Transparent;
            this.mainActraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainActraction.Image = ((System.Drawing.Image)(resources.GetObject("mainActraction.Image")));
            this.mainActraction.Location = new System.Drawing.Point(232, 35);
            this.mainActraction.Margin = new System.Windows.Forms.Padding(4);
            this.mainActraction.Name = "mainActraction";
            this.mainActraction.Size = new System.Drawing.Size(151, 151);
            this.mainActraction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainActraction.TabIndex = 23;
            this.mainActraction.TabStop = false;
            // 
            // optionsBtn
            // 
            this.optionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.optionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsBtn.Location = new System.Drawing.Point(81, 322);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.optionsBtn.MinimumSize = new System.Drawing.Size(13, 37);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(452, 79);
            this.optionsBtn.TabIndex = 20;
            this.optionsBtn.TabStop = false;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = false;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Location = new System.Drawing.Point(81, 218);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4);
            this.playBtn.MinimumSize = new System.Drawing.Size(13, 37);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(452, 79);
            this.playBtn.TabIndex = 19;
            this.playBtn.TabStop = false;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.costumizeBtn);
            this.Controls.Add(this.mainActraction);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.playBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(615, 544);
            ((System.ComponentModel.ISupportInitialize)(this.mainActraction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button costumizeBtn;
        private System.Windows.Forms.PictureBox mainActraction;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button playBtn;
    }
}
