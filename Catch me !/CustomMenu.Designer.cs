namespace CIG
{
    partial class CustomMenu
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
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.panelCellActive = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCellInactive = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCellInitial = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBtn.Location = new System.Drawing.Point(201, 454);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(213, 52);
            this.ReturnBtn.TabIndex = 4;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 79);
            this.label2.TabIndex = 6;
            this.label2.Text = "Custom Colors";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCellActive
            // 
            this.panelCellActive.BackColor = System.Drawing.Color.Brown;
            this.panelCellActive.Location = new System.Drawing.Point(193, 182);
            this.panelCellActive.Name = "panelCellActive";
            this.panelCellActive.Size = new System.Drawing.Size(50, 50);
            this.panelCellActive.TabIndex = 7;
            this.panelCellActive.Click += new System.EventHandler(this.panelcellActive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cell Active";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cell Inactive";
            // 
            // panelCellInactive
            // 
            this.panelCellInactive.BackColor = System.Drawing.Color.Brown;
            this.panelCellInactive.Location = new System.Drawing.Point(287, 184);
            this.panelCellInactive.Name = "panelCellInactive";
            this.panelCellInactive.Size = new System.Drawing.Size(50, 50);
            this.panelCellInactive.TabIndex = 10;
            this.panelCellInactive.Click += new System.EventHandler(this.panelCellInactive_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Border";
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.Brown;
            this.panelBorder.Location = new System.Drawing.Point(381, 184);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(50, 50);
            this.panelBorder.TabIndex = 12;
            this.panelBorder.Click += new System.EventHandler(this.panelBorder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Initial Cell";
            this.label5.Visible = false;
            // 
            // panelCellInitial
            // 
            this.panelCellInitial.BackColor = System.Drawing.Color.Brown;
            this.panelCellInitial.Location = new System.Drawing.Point(423, 184);
            this.panelCellInitial.Name = "panelCellInitial";
            this.panelCellInitial.Size = new System.Drawing.Size(50, 50);
            this.panelCellInitial.TabIndex = 14;
            this.panelCellInitial.Visible = false;
            this.panelCellInitial.Click += new System.EventHandler(this.panelCellInitial_Click);
            // 
            // CustomMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelCellInitial);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelCellInactive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCellActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReturnBtn);
            this.Name = "CustomMenu";
            this.Size = new System.Drawing.Size(615, 544);
            this.Load += new System.EventHandler(this.CustomMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Panel panelCellActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCellInactive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelCellInitial;
    }
}
