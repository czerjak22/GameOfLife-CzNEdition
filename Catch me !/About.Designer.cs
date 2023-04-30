namespace Catch_me__
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(27, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(510, 347);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBtn.Location = new System.Drawing.Point(176, 400);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(213, 52);
            this.ReturnBtn.TabIndex = 0;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(25, 25);
            this.Name = "About";
            this.Size = new System.Drawing.Size(565, 489);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ReturnBtn;
    }
}
