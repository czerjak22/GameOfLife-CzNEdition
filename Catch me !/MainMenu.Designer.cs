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
            this.moneyNum = new System.Windows.Forms.Label();
            this.moneyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainActraction)).BeginInit();
            this.SuspendLayout();
            // 
            // costumizeBtn
            // 
            this.costumizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.costumizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.costumizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.costumizeBtn.Location = new System.Drawing.Point(47, 342);
            this.costumizeBtn.MinimumSize = new System.Drawing.Size(10, 30);
            this.costumizeBtn.Name = "costumizeBtn";
            this.costumizeBtn.Size = new System.Drawing.Size(339, 64);
            this.costumizeBtn.TabIndex = 18;
            this.costumizeBtn.Text = "Customize";
            this.costumizeBtn.UseVisualStyleBackColor = false;
            // 
            // mainActraction
            // 
            this.mainActraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainActraction.Image = ((System.Drawing.Image)(resources.GetObject("mainActraction.Image")));
            this.mainActraction.Location = new System.Drawing.Point(150, 92);
            this.mainActraction.Name = "mainActraction";
            this.mainActraction.Size = new System.Drawing.Size(137, 64);
            this.mainActraction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainActraction.TabIndex = 23;
            this.mainActraction.TabStop = false;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.optionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionsBtn.Location = new System.Drawing.Point(47, 263);
            this.optionsBtn.MinimumSize = new System.Drawing.Size(10, 30);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(339, 64);
            this.optionsBtn.TabIndex = 20;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = false;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playBtn.Location = new System.Drawing.Point(47, 180);
            this.playBtn.MinimumSize = new System.Drawing.Size(10, 30);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(339, 64);
            this.playBtn.TabIndex = 19;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // moneyNum
            // 
            this.moneyNum.AutoSize = true;
            this.moneyNum.Location = new System.Drawing.Point(382, 36);
            this.moneyNum.Name = "moneyNum";
            this.moneyNum.Size = new System.Drawing.Size(31, 13);
            this.moneyNum.TabIndex = 22;
            this.moneyNum.Text = "9999";
            // 
            // moneyName
            // 
            this.moneyName.AutoSize = true;
            this.moneyName.Location = new System.Drawing.Point(336, 36);
            this.moneyName.Name = "moneyName";
            this.moneyName.Size = new System.Drawing.Size(39, 13);
            this.moneyName.TabIndex = 21;
            this.moneyName.Text = "Money";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.costumizeBtn);
            this.Controls.Add(this.mainActraction);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.moneyNum);
            this.Controls.Add(this.moneyName);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(461, 442);
            ((System.ComponentModel.ISupportInitialize)(this.mainActraction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button costumizeBtn;
        private System.Windows.Forms.PictureBox mainActraction;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label moneyNum;
        private System.Windows.Forms.Label moneyName;
    }
}
