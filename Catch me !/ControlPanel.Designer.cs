namespace CIG
{
    partial class ControlPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.soundsCkb = new System.Windows.Forms.CheckBox();
            this.musicCkb = new System.Windows.Forms.CheckBox();
            this.musicBar = new System.Windows.Forms.TrackBar();
            this.soundBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(201, 455);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(213, 52);
            this.ReturnBtn.TabIndex = 3;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // soundsCkb
            // 
            this.soundsCkb.AutoSize = true;
            this.soundsCkb.Location = new System.Drawing.Point(99, 172);
            this.soundsCkb.Margin = new System.Windows.Forms.Padding(4);
            this.soundsCkb.Name = "soundsCkb";
            this.soundsCkb.Size = new System.Drawing.Size(75, 20);
            this.soundsCkb.TabIndex = 4;
            this.soundsCkb.Text = "Sounds";
            this.soundsCkb.UseVisualStyleBackColor = true;
            this.soundsCkb.CheckedChanged += new System.EventHandler(this.soundsCkb_CheckedChanged);
            // 
            // musicCkb
            // 
            this.musicCkb.AutoSize = true;
            this.musicCkb.Location = new System.Drawing.Point(435, 172);
            this.musicCkb.Margin = new System.Windows.Forms.Padding(4);
            this.musicCkb.Name = "musicCkb";
            this.musicCkb.Size = new System.Drawing.Size(64, 20);
            this.musicCkb.TabIndex = 6;
            this.musicCkb.Text = "Music";
            this.musicCkb.UseVisualStyleBackColor = true;
            this.musicCkb.CheckedChanged += new System.EventHandler(this.musicCkb_CheckedChanged);
            this.musicCkb.VisibleChanged += new System.EventHandler(this.musicCkb_VisibleChanged);
            // 
            // musicBar
            // 
            this.musicBar.Location = new System.Drawing.Point(373, 217);
            this.musicBar.Margin = new System.Windows.Forms.Padding(4);
            this.musicBar.Maximum = 100;
            this.musicBar.Minimum = 1;
            this.musicBar.Name = "musicBar";
            this.musicBar.Size = new System.Drawing.Size(212, 56);
            this.musicBar.SmallChange = 5;
            this.musicBar.TabIndex = 7;
            this.musicBar.TickFrequency = 10;
            this.musicBar.Value = 1;
            this.musicBar.Scroll += new System.EventHandler(this.musicBar_Scroll);
            // 
            // soundBar
            // 
            this.soundBar.Location = new System.Drawing.Point(44, 217);
            this.soundBar.Margin = new System.Windows.Forms.Padding(4);
            this.soundBar.Maximum = 100;
            this.soundBar.Name = "soundBar";
            this.soundBar.Size = new System.Drawing.Size(212, 56);
            this.soundBar.SmallChange = 5;
            this.soundBar.TabIndex = 8;
            this.soundBar.TickFrequency = 10;
            this.soundBar.Scroll += new System.EventHandler(this.soundBar_Scroll);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.soundBar);
            this.Controls.Add(this.musicBar);
            this.Controls.Add(this.musicCkb);
            this.Controls.Add(this.soundsCkb);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(615, 544);
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.CheckBox soundsCkb;
        private System.Windows.Forms.CheckBox musicCkb;
        private System.Windows.Forms.TrackBar musicBar;
        private System.Windows.Forms.TrackBar soundBar;
    }
}
