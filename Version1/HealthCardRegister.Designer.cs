namespace Version1
{
    partial class HealthCardRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthCardRegister));
            this.panelHealthCardReg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxActLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldHeight = new System.Windows.Forms.TextBox();
            this.fieldWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.buttonRegistBack = new System.Windows.Forms.Button();
            this.buttonCLose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.panelHealthCardReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHealthCardReg
            // 
            this.panelHealthCardReg.BackColor = System.Drawing.Color.SpringGreen;
            this.panelHealthCardReg.BackgroundImage = global::Version1.Properties.Resources.food1;
            this.panelHealthCardReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHealthCardReg.Controls.Add(this.pictureBox1);
            this.panelHealthCardReg.Controls.Add(this.comboBoxActLevel);
            this.panelHealthCardReg.Controls.Add(this.label6);
            this.panelHealthCardReg.Controls.Add(this.label5);
            this.panelHealthCardReg.Controls.Add(this.fieldHeight);
            this.panelHealthCardReg.Controls.Add(this.fieldWeight);
            this.panelHealthCardReg.Controls.Add(this.label4);
            this.panelHealthCardReg.Controls.Add(this.label3);
            this.panelHealthCardReg.Controls.Add(this.label2);
            this.panelHealthCardReg.Controls.Add(this.datePick);
            this.panelHealthCardReg.Controls.Add(this.buttonRegistBack);
            this.panelHealthCardReg.Controls.Add(this.buttonCLose);
            this.panelHealthCardReg.Controls.Add(this.label1);
            this.panelHealthCardReg.Controls.Add(this.buttonSubmit);
            this.panelHealthCardReg.Controls.Add(this.log);
            this.panelHealthCardReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHealthCardReg.Location = new System.Drawing.Point(0, 0);
            this.panelHealthCardReg.Name = "panelHealthCardReg";
            this.panelHealthCardReg.Size = new System.Drawing.Size(800, 450);
            this.panelHealthCardReg.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxActLevel
            // 
            this.comboBoxActLevel.FormattingEnabled = true;
            this.comboBoxActLevel.Items.AddRange(new object[] {
            "Sedentary: little or no exercise",
            "Light: exercise 1-3 times a week",
            "Moderate: exercise 4-5 times a week ",
            "Active: daily exercise or intense exercise 3-4 times a week",
            "Very active: intense exercise 6-7 times a week",
            "Extra active: very intense exercise daily or physical job"});
            this.comboBoxActLevel.Location = new System.Drawing.Point(168, 356);
            this.comboBoxActLevel.Name = "comboBoxActLevel";
            this.comboBoxActLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActLevel.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "kg";
            // 
            // fieldHeight
            // 
            this.fieldHeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fieldHeight.Location = new System.Drawing.Point(168, 290);
            this.fieldHeight.Name = "fieldHeight";
            this.fieldHeight.Size = new System.Drawing.Size(100, 20);
            this.fieldHeight.TabIndex = 22;
            // 
            // fieldWeight
            // 
            this.fieldWeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fieldWeight.Location = new System.Drawing.Point(168, 216);
            this.fieldWeight.Name = "fieldWeight";
            this.fieldWeight.Size = new System.Drawing.Size(100, 20);
            this.fieldWeight.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 38);
            this.label4.TabIndex = 20;
            this.label4.Text = "Level of activeness";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Weight";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePick
            // 
            this.datePick.CalendarFont = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.datePick.Location = new System.Drawing.Point(168, 147);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(80, 20);
            this.datePick.TabIndex = 17;
            // 
            // buttonRegistBack
            // 
            this.buttonRegistBack.BackColor = System.Drawing.Color.Turquoise;
            this.buttonRegistBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistBack.Location = new System.Drawing.Point(13, 12);
            this.buttonRegistBack.Name = "buttonRegistBack";
            this.buttonRegistBack.Size = new System.Drawing.Size(36, 23);
            this.buttonRegistBack.TabIndex = 16;
            this.buttonRegistBack.Text = "←";
            this.buttonRegistBack.UseVisualStyleBackColor = false;
            this.buttonRegistBack.Click += new System.EventHandler(this.buttonRegistBack_Click);
            // 
            // buttonCLose
            // 
            this.buttonCLose.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCLose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.buttonCLose.Location = new System.Drawing.Point(766, 3);
            this.buttonCLose.Name = "buttonCLose";
            this.buttonCLose.Size = new System.Drawing.Size(31, 33);
            this.buttonCLose.TabIndex = 15;
            this.buttonCLose.Text = "X";
            this.buttonCLose.UseVisualStyleBackColor = false;
            this.buttonCLose.Click += new System.EventHandler(this.buttonCLose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date of birth";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.buttonSubmit.FlatAppearance.BorderSize = 2;
            this.buttonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSubmit.Location = new System.Drawing.Point(535, 386);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(118, 39);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click_1);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Aqua;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(27, 49);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(290, 62);
            this.log.TabIndex = 0;
            this.log.Text = "Enter your health data";
            this.log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HealthCardRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHealthCardReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HealthCardRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthCardRegister";
            this.panelHealthCardReg.ResumeLayout(false);
            this.panelHealthCardReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHealthCardReg;
        private System.Windows.Forms.Button buttonRegistBack;
        private System.Windows.Forms.Button buttonCLose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.TextBox fieldHeight;
        private System.Windows.Forms.TextBox fieldWeight;
        private System.Windows.Forms.ComboBox comboBoxActLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}