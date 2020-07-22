namespace Version1
{
    partial class DayControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNextDay = new System.Windows.Forms.Label();
            this.labelBackDay = new System.Windows.Forms.Label();
            this.buttonExercise = new System.Windows.Forms.Button();
            this.buttonFiber = new System.Windows.Forms.Button();
            this.buttonCarb = new System.Windows.Forms.Button();
            this.buttonFat = new System.Windows.Forms.Button();
            this.buttonProtein = new System.Windows.Forms.Button();
            this.buttonKcak = new System.Windows.Forms.Button();
            this.buttonWater = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.buttonExercise);
            this.panel1.Controls.Add(this.buttonFiber);
            this.panel1.Controls.Add(this.buttonCarb);
            this.panel1.Controls.Add(this.buttonFat);
            this.panel1.Controls.Add(this.buttonProtein);
            this.panel1.Controls.Add(this.buttonKcak);
            this.panel1.Controls.Add(this.buttonWater);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 401);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.labelBackDay);
            this.panel2.Controls.Add(this.labelNextDay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 36);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(294, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(15, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(65, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label";
            // 
            // labelNextDay
            // 
            this.labelNextDay.BackColor = System.Drawing.Color.Transparent;
            this.labelNextDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNextDay.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextDay.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNextDay.Location = new System.Drawing.Point(164, 10);
            this.labelNextDay.Name = "labelNextDay";
            this.labelNextDay.Size = new System.Drawing.Size(48, 23);
            this.labelNextDay.TabIndex = 2;
            this.labelNextDay.Text = "next";
            // 
            // labelBackDay
            // 
            this.labelBackDay.BackColor = System.Drawing.Color.Transparent;
            this.labelBackDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBackDay.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackDay.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBackDay.Location = new System.Drawing.Point(11, 10);
            this.labelBackDay.Name = "labelBackDay";
            this.labelBackDay.Size = new System.Drawing.Size(48, 23);
            this.labelBackDay.TabIndex = 3;
            this.labelBackDay.Text = "back";
            // 
            // buttonExercise
            // 
            this.buttonExercise.BackColor = System.Drawing.Color.DarkRed;
            this.buttonExercise.FlatAppearance.BorderSize = 0;
            this.buttonExercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExercise.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExercise.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExercise.Image = global::Version1.Properties.Resources.Webp_net_resizeimage__6_;
            this.buttonExercise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExercise.Location = new System.Drawing.Point(-1, 323);
            this.buttonExercise.Name = "buttonExercise";
            this.buttonExercise.Size = new System.Drawing.Size(96, 44);
            this.buttonExercise.TabIndex = 6;
            this.buttonExercise.Text = "   exercise";
            this.buttonExercise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExercise.UseVisualStyleBackColor = false;
            this.buttonExercise.Click += new System.EventHandler(this.buttonExercise_Click);
            // 
            // buttonFiber
            // 
            this.buttonFiber.BackColor = System.Drawing.Color.DarkRed;
            this.buttonFiber.FlatAppearance.BorderSize = 0;
            this.buttonFiber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiber.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiber.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFiber.Image = global::Version1.Properties.Resources.Webp_net_resizeimage__5_;
            this.buttonFiber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiber.Location = new System.Drawing.Point(-1, 279);
            this.buttonFiber.Name = "buttonFiber";
            this.buttonFiber.Size = new System.Drawing.Size(96, 44);
            this.buttonFiber.TabIndex = 5;
            this.buttonFiber.Text = "fiber";
            this.buttonFiber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFiber.UseVisualStyleBackColor = false;
            this.buttonFiber.Click += new System.EventHandler(this.buttonFiber_Click);
            // 
            // buttonCarb
            // 
            this.buttonCarb.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCarb.FlatAppearance.BorderSize = 0;
            this.buttonCarb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarb.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarb.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCarb.Image = global::Version1.Properties.Resources.Webp_net_resizeimage__4_;
            this.buttonCarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCarb.Location = new System.Drawing.Point(-1, 235);
            this.buttonCarb.Name = "buttonCarb";
            this.buttonCarb.Size = new System.Drawing.Size(96, 44);
            this.buttonCarb.TabIndex = 4;
            this.buttonCarb.Text = "carb";
            this.buttonCarb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCarb.UseVisualStyleBackColor = false;
            this.buttonCarb.Click += new System.EventHandler(this.buttonCarb_Click);
            // 
            // buttonFat
            // 
            this.buttonFat.BackColor = System.Drawing.Color.DarkRed;
            this.buttonFat.FlatAppearance.BorderSize = 0;
            this.buttonFat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFat.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFat.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFat.Image = global::Version1.Properties.Resources.Webp_net_resizeimage__3_;
            this.buttonFat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFat.Location = new System.Drawing.Point(-1, 191);
            this.buttonFat.Name = "buttonFat";
            this.buttonFat.Size = new System.Drawing.Size(96, 44);
            this.buttonFat.TabIndex = 3;
            this.buttonFat.Text = "fat";
            this.buttonFat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFat.UseVisualStyleBackColor = false;
            this.buttonFat.Click += new System.EventHandler(this.buttonFat_Click);
            // 
            // buttonProtein
            // 
            this.buttonProtein.BackColor = System.Drawing.Color.DarkRed;
            this.buttonProtein.FlatAppearance.BorderSize = 0;
            this.buttonProtein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProtein.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProtein.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProtein.Image = global::Version1.Properties.Resources.Webp_net_resizeimage__2_;
            this.buttonProtein.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProtein.Location = new System.Drawing.Point(-1, 147);
            this.buttonProtein.Name = "buttonProtein";
            this.buttonProtein.Size = new System.Drawing.Size(96, 44);
            this.buttonProtein.TabIndex = 2;
            this.buttonProtein.Text = "protein";
            this.buttonProtein.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProtein.UseVisualStyleBackColor = false;
            this.buttonProtein.Click += new System.EventHandler(this.buttonProtein_Click);
            // 
            // buttonKcak
            // 
            this.buttonKcak.BackColor = System.Drawing.Color.DarkRed;
            this.buttonKcak.FlatAppearance.BorderSize = 0;
            this.buttonKcak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKcak.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKcak.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKcak.Image = global::Version1.Properties.Resources.Webp_net_resizeimage__1_;
            this.buttonKcak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKcak.Location = new System.Drawing.Point(-1, 103);
            this.buttonKcak.Name = "buttonKcak";
            this.buttonKcak.Size = new System.Drawing.Size(96, 44);
            this.buttonKcak.TabIndex = 1;
            this.buttonKcak.Text = "kcal";
            this.buttonKcak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKcak.UseVisualStyleBackColor = false;
            this.buttonKcak.Click += new System.EventHandler(this.buttonKcak_Click);
            // 
            // buttonWater
            // 
            this.buttonWater.BackColor = System.Drawing.Color.DarkRed;
            this.buttonWater.FlatAppearance.BorderSize = 0;
            this.buttonWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWater.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWater.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonWater.Image = ((System.Drawing.Image)(resources.GetObject("buttonWater.Image")));
            this.buttonWater.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWater.Location = new System.Drawing.Point(-1, 59);
            this.buttonWater.Name = "buttonWater";
            this.buttonWater.Size = new System.Drawing.Size(96, 44);
            this.buttonWater.TabIndex = 0;
            this.buttonWater.Text = "water";
            this.buttonWater.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWater.UseVisualStyleBackColor = false;
            this.buttonWater.Click += new System.EventHandler(this.buttonWater_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Pink;
            this.sidePanel.Location = new System.Drawing.Point(0, 59);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 42);
            this.sidePanel.TabIndex = 2;
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(675, 401);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonWater;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBackDay;
        private System.Windows.Forms.Label labelNextDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonKcak;
        private System.Windows.Forms.Button buttonProtein;
        private System.Windows.Forms.Button buttonExercise;
        private System.Windows.Forms.Button buttonFiber;
        private System.Windows.Forms.Button buttonCarb;
        private System.Windows.Forms.Button buttonFat;
        private System.Windows.Forms.Panel sidePanel;
    }
}
