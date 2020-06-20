using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            fNameField.Text = "Name";
            lNameField.Text = "Last name";
            loginField.Text = "login";
            passField.UseSystemPasswordChar = false;
            passField.Text = "Password";
            repPassField.UseSystemPasswordChar = false;
            repPassField.Text = "Repeat your password";
            
        }

        private void buttonClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void fNameField_Enter(object sender, EventArgs e) //pressing on the field
        {
           if( fNameField.Text == "Name")
            {
                fNameField.Text = "";
                fNameField.ForeColor = Color.Black;
            }
                
        }

        private void fNameField_Leave(object sender, EventArgs e)
        {
            if (fNameField.Text == "")
            {
                fNameField.Text = "Name";
                fNameField.ForeColor = Color.Gray;
            }
        }

        private void lNameField_Enter(object sender, EventArgs e)
        {
            if(lNameField.Text == "Last name")
            {
                lNameField.Text = "";
                lNameField.ForeColor = Color.Black;
            }
        }

        private void lNameField_Leave(object sender, EventArgs e)
        {
            if(lNameField.Text == "")
            {
                lNameField.Text = "Last name";
                lNameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if(loginField.Text == "login")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if(loginField.Text == "")
            {
                loginField.Text = "login";
                loginField.ForeColor = Color.Gray;
            }
               
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if(passField.Text == "Password")
            {
                passField.Text = "";
                passField.UseSystemPasswordChar = true;
                passField.ForeColor = Color.Black;

            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if(passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Password";
                passField.ForeColor = Color.Gray;
            }
        }

        private void repPassField_Enter(object sender, EventArgs e)
        {
            if(repPassField.Text == "Repeat your password")
            {
                repPassField.Text = "";
                repPassField.UseSystemPasswordChar = true;
                repPassField.ForeColor = Color.Black;
            }
        }

        private void repPassField_Leave(object sender, EventArgs e)
        {
            if (repPassField.Text == "")
            {
                repPassField.UseSystemPasswordChar = false;
                repPassField.Text = "Repeat your password";
                repPassField.ForeColor = Color.Gray;
            }
        }
    }
}
