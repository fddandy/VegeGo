namespace Version1
{
    partial class WaterControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelWaterDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWaterNecc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWater = new System.Windows.Forms.ComboBox();
            this.labelWaterResult = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water drunk today : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWaterDay
            // 
            this.labelWaterDay.AutoSize = true;
            this.labelWaterDay.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterDay.Location = new System.Drawing.Point(208, 14);
            this.labelWaterDay.Name = "labelWaterDay";
            this.labelWaterDay.Size = new System.Drawing.Size(24, 31);
            this.labelWaterDay.TabIndex = 1;
            this.labelWaterDay.Text = "1";
            this.labelWaterDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "You need to drink ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "l a day";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWaterNecc
            // 
            this.labelWaterNecc.AutoSize = true;
            this.labelWaterNecc.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterNecc.Location = new System.Drawing.Point(165, 277);
            this.labelWaterNecc.Name = "labelWaterNecc";
            this.labelWaterNecc.Size = new System.Drawing.Size(39, 25);
            this.labelWaterNecc.TabIndex = 5;
            this.labelWaterNecc.Text = "lab";
            this.labelWaterNecc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 60);
            this.label4.TabIndex = 6;
            this.label4.Text = "Find out how your water income statistics look like";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxWater
            // 
            this.comboBoxWater.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBoxWater.FormattingEnabled = true;
            this.comboBoxWater.Items.AddRange(new object[] {
            "today",
            "last week",
            "last month"});
            this.comboBoxWater.Location = new System.Drawing.Point(210, 78);
            this.comboBoxWater.Name = "comboBoxWater";
            this.comboBoxWater.Size = new System.Drawing.Size(63, 21);
            this.comboBoxWater.TabIndex = 8;
            // 
            // labelWaterResult
            // 
            this.labelWaterResult.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterResult.Location = new System.Drawing.Point(32, 116);
            this.labelWaterResult.Name = "labelWaterResult";
            this.labelWaterResult.Size = new System.Drawing.Size(226, 91);
            this.labelWaterResult.TabIndex = 9;
            this.labelWaterResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Version1.Properties.Resources.woda;
            this.pictureBox2.Location = new System.Drawing.Point(12, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Version1.Properties.Resources.water;
            this.pictureBox1.Location = new System.Drawing.Point(282, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // WaterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.labelWaterResult);
            this.Controls.Add(this.comboBoxWater);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWaterNecc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWaterDay);
            this.Controls.Add(this.label1);
            this.Name = "WaterControl";
            this.Size = new System.Drawing.Size(583, 339);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label labelWaterDay;
        public System.Windows.Forms.Label labelWaterNecc;
        public System.Windows.Forms.ComboBox comboBoxWater;
        public System.Windows.Forms.Label labelWaterResult;
    }
}
