namespace Catch_me__
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.buttonResize = new System.Windows.Forms.Button();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.checkBoxDrag = new System.Windows.Forms.CheckBox();
            this.buttonIterate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCellSize = new System.Windows.Forms.NumericUpDown();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.panelGrid = new System.Windows.Forms.PictureBox();
            this.timerResize = new System.Windows.Forms.Timer(this.components);
            this.buttonRe = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonRe);
            this.panelControl.Controls.Add(this.buttonReturn);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.trackBarSpeed);
            this.panelControl.Controls.Add(this.buttonResize);
            this.panelControl.Controls.Add(this.checkBoxGrid);
            this.panelControl.Controls.Add(this.checkBoxDrag);
            this.panelControl.Controls.Add(this.buttonIterate);
            this.panelControl.Controls.Add(this.buttonClear);
            this.panelControl.Controls.Add(this.labelTest);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.numericUpDownCellSize);
            this.panelControl.Controls.Add(this.buttonTimer);
            this.panelControl.Controls.Add(this.buttonLoad);
            this.panelControl.Controls.Add(this.buttonSave);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(442, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(173, 544);
            this.panelControl.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(36, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(100, 28);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Speed";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(36, 284);
            this.trackBarSpeed.Maximum = 300;
            this.trackBarSpeed.Minimum = 50;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(104, 56);
            this.trackBarSpeed.TabIndex = 8;
            this.trackBarSpeed.Value = 50;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(36, 510);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(100, 28);
            this.buttonResize.TabIndex = 12;
            this.buttonResize.Text = "Resize";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Checked = true;
            this.checkBoxGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrid.Location = new System.Drawing.Point(38, 153);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(54, 20);
            this.checkBoxGrid.TabIndex = 5;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // checkBoxDrag
            // 
            this.checkBoxDrag.AutoSize = true;
            this.checkBoxDrag.Checked = true;
            this.checkBoxDrag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrag.Location = new System.Drawing.Point(38, 126);
            this.checkBoxDrag.Name = "checkBoxDrag";
            this.checkBoxDrag.Size = new System.Drawing.Size(100, 20);
            this.checkBoxDrag.TabIndex = 4;
            this.checkBoxDrag.Text = "Drag Select";
            this.checkBoxDrag.UseVisualStyleBackColor = true;
            this.checkBoxDrag.CheckedChanged += new System.EventHandler(this.checkBoxDrag_CheckedChanged);
            // 
            // buttonIterate
            // 
            this.buttonIterate.Location = new System.Drawing.Point(36, 475);
            this.buttonIterate.Name = "buttonIterate";
            this.buttonIterate.Size = new System.Drawing.Size(100, 28);
            this.buttonIterate.TabIndex = 11;
            this.buttonIterate.Text = "Iterate";
            this.buttonIterate.UseVisualStyleBackColor = true;
            this.buttonIterate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(36, 441);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(45, 343);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(78, 16);
            this.labelTest.TabIndex = 8;
            this.labelTest.Text = "Debug Only";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cell Size (px):";
            // 
            // numericUpDownCellSize
            // 
            this.numericUpDownCellSize.Location = new System.Drawing.Point(13, 224);
            this.numericUpDownCellSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCellSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCellSize.Name = "numericUpDownCellSize";
            this.numericUpDownCellSize.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownCellSize.TabIndex = 6;
            this.numericUpDownCellSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownCellSize.ValueChanged += new System.EventHandler(this.numericUpDownCellSize_ValueChanged);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(36, 407);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(100, 28);
            this.buttonTimer.TabIndex = 9;
            this.buttonTimer.Text = "Start";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoad.Location = new System.Drawing.Point(36, 51);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(36, 90);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 50;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // panelGrid
            // 
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(442, 544);
            this.panelGrid.TabIndex = 1;
            this.panelGrid.TabStop = false;
            this.panelGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseDown);
            this.panelGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseMove);
            this.panelGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseUp);
            this.panelGrid.Resize += new System.EventHandler(this.panelGrid_Resize);
            // 
            // timerResize
            // 
            this.timerResize.Tick += new System.EventHandler(this.timerresize_Tick);
            // 
            // buttonRe
            // 
            this.buttonRe.Enabled = false;
            this.buttonRe.Location = new System.Drawing.Point(76, 222);
            this.buttonRe.Name = "buttonRe";
            this.buttonRe.Size = new System.Drawing.Size(83, 27);
            this.buttonRe.TabIndex = 7;
            this.buttonRe.Text = "Resize";
            this.buttonRe.UseVisualStyleBackColor = true;
            this.buttonRe.Click += new System.EventHandler(this.buttonRe_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(615, 544);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Game_Scroll);
            this.SizeChanged += new System.EventHandler(this.Game_SizeChanged);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCellSize;
        private System.Windows.Forms.PictureBox panelGrid;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonIterate;
        private System.Windows.Forms.CheckBox checkBoxDrag;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.Timer timerResize;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonRe;
    }
}
