namespace Version1
{
    partial class PFCControl
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
            this.labelCarbohydrate = new System.Windows.Forms.Label();
            this.labelProtein = new System.Windows.Forms.Label();
            this.labelFat = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.labelCarbohydrate);
            this.panel1.Controls.Add(this.labelProtein);
            this.panel1.Controls.Add(this.labelFat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 52);
            this.panel1.TabIndex = 0;
            // 
            // labelCarbohydrate
            // 
            this.labelCarbohydrate.BackColor = System.Drawing.Color.LightGreen;
            this.labelCarbohydrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCarbohydrate.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarbohydrate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCarbohydrate.Location = new System.Drawing.Point(457, 11);
            this.labelCarbohydrate.Name = "labelCarbohydrate";
            this.labelCarbohydrate.Size = new System.Drawing.Size(177, 21);
            this.labelCarbohydrate.TabIndex = 5;
            this.labelCarbohydrate.Text = "Carbohydrate";
            this.labelCarbohydrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProtein
            // 
            this.labelProtein.BackColor = System.Drawing.Color.LightGreen;
            this.labelProtein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelProtein.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProtein.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProtein.Location = new System.Drawing.Point(17, 11);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(177, 21);
            this.labelProtein.TabIndex = 3;
            this.labelProtein.Text = "Protein";
            this.labelProtein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFat
            // 
            this.labelFat.BackColor = System.Drawing.Color.LightGreen;
            this.labelFat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFat.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFat.Location = new System.Drawing.Point(237, 11);
            this.labelFat.Name = "labelFat";
            this.labelFat.Size = new System.Drawing.Size(177, 21);
            this.labelFat.TabIndex = 4;
            this.labelFat.Text = "Fat";
            this.labelFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(289, 61);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(362, 307);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-15, -15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(231, 94);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 101);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the date to show your fat/protein/carbohydrate percentage %";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Version1.Properties.Resources.nutrient_composition_146;
            this.pictureBox1.Location = new System.Drawing.Point(12, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PFCControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.panel1);
            this.Name = "PFCControl";
            this.Size = new System.Drawing.Size(654, 368);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelProtein;
        public System.Windows.Forms.Label labelFat;
        public System.Windows.Forms.Label labelCarbohydrate;
        public LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
