namespace Version1
{
    partial class HealthCardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthCardControl));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.chartWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEditHC = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelActiveLevel = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelHealthInf = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.labelDate);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.comboBoxChartType);
            this.panelMain.Controls.Add(this.chartWeight);
            this.panelMain.Controls.Add(this.comboBoxPeriod);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.buttonEditHC);
            this.panelMain.Controls.Add(this.panel8);
            this.panelMain.Controls.Add(this.labelHealthInf);
            this.panelMain.Location = new System.Drawing.Point(-16, -6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(675, 401);
            this.panelMain.TabIndex = 3;
            this.panelMain.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(558, 36);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(103, 22);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Period ";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(558, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Today is : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(313, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Chart type";
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxChartType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "column",
            "spline",
            "line",
            "point"});
            this.comboBoxChartType.Location = new System.Drawing.Point(404, 51);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(103, 21);
            this.comboBoxChartType.TabIndex = 15;
            // 
            // chartWeight
            // 
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.Title = "Kg";
            chartArea1.Name = "ChartArea1";
            this.chartWeight.ChartAreas.Add(chartArea1);
            this.chartWeight.Location = new System.Drawing.Point(312, 92);
            this.chartWeight.Name = "chartWeight";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Name = "SeriesW";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartWeight.Series.Add(series1);
            this.chartWeight.Size = new System.Drawing.Size(345, 307);
            this.chartWeight.TabIndex = 14;
            this.chartWeight.Text = "chart1";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            title1.Name = "Title1";
            title1.Text = "Personal statistics";
            title2.Name = "Title2";
            this.chartWeight.Titles.Add(title1);
            this.chartWeight.Titles.Add(title2);
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "last week",
            "last month",
            "last year"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(404, 24);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(103, 21);
            this.comboBoxPeriod.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(325, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Period ";
            // 
            // buttonEditHC
            // 
            this.buttonEditHC.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonEditHC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditHC.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditHC.Location = new System.Drawing.Point(135, 349);
            this.buttonEditHC.Name = "buttonEditHC";
            this.buttonEditHC.Size = new System.Drawing.Size(75, 23);
            this.buttonEditHC.TabIndex = 2;
            this.buttonEditHC.Text = "Edit";
            this.buttonEditHC.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.labelAL);
            this.panel8.Controls.Add(this.labelW);
            this.panel8.Controls.Add(this.labelH);
            this.panel8.Controls.Add(this.labelBD);
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.labelHeight);
            this.panel8.Controls.Add(this.labelActiveLevel);
            this.panel8.Controls.Add(this.labelWeight);
            this.panel8.Controls.Add(this.labelBirthDate);
            this.panel8.Location = new System.Drawing.Point(48, 106);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(248, 237);
            this.panel8.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "cm";
            // 
            // labelAL
            // 
            this.labelAL.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAL.Location = new System.Drawing.Point(144, 173);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(101, 55);
            this.labelAL.TabIndex = 14;
            this.labelAL.Text = "label3";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.Location = new System.Drawing.Point(123, 115);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(48, 17);
            this.labelW.TabIndex = 13;
            this.labelW.Text = "label3";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(114, 64);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(48, 17);
            this.labelH.TabIndex = 12;
            this.labelH.Text = "label3";
            // 
            // labelBD
            // 
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBD.Location = new System.Drawing.Point(141, 20);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(48, 17);
            this.labelBD.TabIndex = 11;
            this.labelBD.Text = "label3";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(5, 163);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelHeight.Location = new System.Drawing.Point(49, 64);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(45, 17);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height";
            // 
            // labelActiveLevel
            // 
            this.labelActiveLevel.AutoSize = true;
            this.labelActiveLevel.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveLevel.ForeColor = System.Drawing.Color.Crimson;
            this.labelActiveLevel.Location = new System.Drawing.Point(49, 173);
            this.labelActiveLevel.Name = "labelActiveLevel";
            this.labelActiveLevel.Size = new System.Drawing.Size(90, 17);
            this.labelActiveLevel.TabIndex = 5;
            this.labelActiveLevel.Text = "Lifestyle mode";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelWeight.Location = new System.Drawing.Point(49, 115);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(47, 17);
            this.labelWeight.TabIndex = 4;
            this.labelWeight.Text = "Weight";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBirthDate.Location = new System.Drawing.Point(49, 18);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(62, 17);
            this.labelBirthDate.TabIndex = 0;
            this.labelBirthDate.Text = "BirthDate";
            // 
            // labelHealthInf
            // 
            this.labelHealthInf.AutoSize = true;
            this.labelHealthInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHealthInf.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealthInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelHealthInf.Location = new System.Drawing.Point(79, 52);
            this.labelHealthInf.Name = "labelHealthInf";
            this.labelHealthInf.Size = new System.Drawing.Size(195, 30);
            this.labelHealthInf.TabIndex = 0;
            this.labelHealthInf.Text = "Your health card";
            // 
            // HealthCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "HealthCardControl";
            this.Size = new System.Drawing.Size(643, 388);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private DayControl dayControl2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeight;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEditHC;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelActiveLevel;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelHealthInf;
    }
}
