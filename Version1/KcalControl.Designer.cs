namespace Version1
{
    partial class KcalControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKcalNecc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewKcal = new System.Windows.Forms.DataGridView();
            this.buttonShowChart = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKcal)).BeginInit();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelKcalNecc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(405, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 368);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Version1.Properties.Resources.he;
            this.pictureBox1.Location = new System.Drawing.Point(32, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelKcalNecc
            // 
            this.labelKcalNecc.BackColor = System.Drawing.Color.LightSalmon;
            this.labelKcalNecc.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKcalNecc.Location = new System.Drawing.Point(69, 100);
            this.labelKcalNecc.Name = "labelKcalNecc";
            this.labelKcalNecc.Size = new System.Drawing.Size(101, 34);
            this.labelKcalNecc.TabIndex = 8;
            this.labelKcalNecc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSalmon;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 75);
            this.label4.TabIndex = 7;
            this.label4.Text = "According to your health parametres, your daily calorie demand is ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewKcal);
            this.panel2.Location = new System.Drawing.Point(19, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 250);
            this.panel2.TabIndex = 9;
            // 
            // dataGridViewKcal
            // 
            this.dataGridViewKcal.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridViewKcal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKcal.Location = new System.Drawing.Point(3, 10);
            this.dataGridViewKcal.Name = "dataGridViewKcal";
            this.dataGridViewKcal.Size = new System.Drawing.Size(361, 240);
            this.dataGridViewKcal.TabIndex = 1;
            // 
            // buttonShowChart
            // 
            this.buttonShowChart.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonShowChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowChart.FlatAppearance.BorderSize = 0;
            this.buttonShowChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowChart.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowChart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowChart.Image = global::Version1.Properties.Resources.Icon_Small_40;
            this.buttonShowChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowChart.Location = new System.Drawing.Point(19, 29);
            this.buttonShowChart.Name = "buttonShowChart";
            this.buttonShowChart.Size = new System.Drawing.Size(147, 48);
            this.buttonShowChart.TabIndex = 10;
            this.buttonShowChart.Text = "Show data";
            this.buttonShowChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShowChart.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(12, 47);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(49, 20);
            this.rbMale.TabIndex = 10;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(12, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 20);
            this.rbFemale.TabIndex = 11;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Location = new System.Drawing.Point(14, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 10);
            this.panel3.TabIndex = 14;
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBoxSex.Controls.Add(this.rbMale);
            this.groupBoxSex.Controls.Add(this.rbFemale);
            this.groupBoxSex.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSex.Location = new System.Drawing.Point(213, 5);
            this.groupBoxSex.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.groupBoxSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxSex.Size = new System.Drawing.Size(140, 76);
            this.groupBoxSex.TabIndex = 15;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Please,choose your sex";
            // 
            // KcalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonShowChart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KcalControl";
            this.Size = new System.Drawing.Size(654, 368);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKcal)).EndInit();
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridViewKcal;
        public System.Windows.Forms.Button buttonShowChart;
        public System.Windows.Forms.Label labelKcalNecc;
        public System.Windows.Forms.RadioButton rbMale;
        public System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.GroupBox groupBoxSex;
    }
}
