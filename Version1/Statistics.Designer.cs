namespace Version1
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.closeButton = new System.Windows.Forms.Label();
            this.buttonRegistBack = new System.Windows.Forms.Button();
            this.chartStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.SandyBrown;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(767, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 31);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // buttonRegistBack
            // 
            this.buttonRegistBack.BackColor = System.Drawing.Color.Turquoise;
            this.buttonRegistBack.Location = new System.Drawing.Point(12, 10);
            this.buttonRegistBack.Name = "buttonRegistBack";
            this.buttonRegistBack.Size = new System.Drawing.Size(36, 23);
            this.buttonRegistBack.TabIndex = 17;
            this.buttonRegistBack.Text = "←";
            this.buttonRegistBack.UseVisualStyleBackColor = false;
            this.buttonRegistBack.Click += new System.EventHandler(this.buttonRegistBack_Click);
            // 
            // chartStat
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStat.Legends.Add(legend1);
            this.chartStat.Location = new System.Drawing.Point(77, 70);
            this.chartStat.Name = "chartStat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "SeriesStat";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartStat.Series.Add(series1);
            this.chartStat.Size = new System.Drawing.Size(627, 282);
            this.chartStat.TabIndex = 18;
            this.chartStat.Text = "chart1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Version1.Properties.Resources.food1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartStat);
            this.Controls.Add(this.buttonRegistBack);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button buttonRegistBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStat;
    }
}