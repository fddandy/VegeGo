namespace Version1
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Location = new System.Drawing.Point(144, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 264);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.Welcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcome.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Welcome.Location = new System.Drawing.Point(0, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(182, 264);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to your healthier eating";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(90)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.passField);
            this.panel2.Controls.Add(this.loginField);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.log);
            this.panel2.Location = new System.Drawing.Point(323, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 264);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogin.Location = new System.Drawing.Point(112, 212);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(118, 39);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Enter";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passField.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passField.Location = new System.Drawing.Point(95, 166);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(158, 40);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.AcceptsReturn = true;
            this.loginField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginField.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginField.Location = new System.Drawing.Point(95, 114);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(158, 40);
            this.loginField.TabIndex = 3;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Khaki;
            this.password.Image = global::Version1.Properties.Resources.iconfinder_key_password_passcode_access_2205205;
            this.password.Location = new System.Drawing.Point(56, 166);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(32, 34);
            this.password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password.TabIndex = 2;
            this.password.TabStop = false;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Khaki;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.Image = global::Version1.Properties.Resources.iconfinder_user_female_172621;
            this.login.Location = new System.Drawing.Point(56, 114);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(32, 32);
            this.login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login.TabIndex = 1;
            this.login.TabStop = false;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Khaki;
            this.log.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(50, 29);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(217, 48);
            this.log.TabIndex = 0;
            this.log.Text = "Member log in";
            this.log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.SandyBrown;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(761, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 31);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseClick);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.buttonRegister.FlatAppearance.BorderSize = 2;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRegister.Location = new System.Drawing.Point(370, 373);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(220, 38);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "New ? Register right now!";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.RegisterForm_Cilck);
            this.buttonRegister.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Version1.Properties.Resources.food1;
            this.ClientSize = new System.Drawing.Size(796, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogInForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogInForm_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox password;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}