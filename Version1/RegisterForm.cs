using MySql.Data.MySqlClient;
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
            fNameField.ForeColor = Color.Gray;
            lNameField.ForeColor = Color.Gray;
            passField.ForeColor = Color.Gray;
            loginField.ForeColor = Color.Gray; 
            repPassField.ForeColor = Color.Gray;
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
            Application.Exit();
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

        private void buttonRegistBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogInForm lf = new LogInForm();
            lf.ShowDialog();
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            buttonRegistBack.ForeColor = Color.Aqua;
            if (fNameField.Text == "Name")
                return;
            if (lNameField.Text == "Last name")
                return;
            if (loginField.Text == "login")
                return;
            if (passField.Text == "Password")
                return;

            if (userExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `person` (`login`, `pass`, `name`, `surname`) VALUES (@login, @password, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = fNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = lNameField.Text; 
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account was succesfully created");
            else
                MessageBox.Show("Account was not created!");


            db.closeConnection();
        }

        

        public Boolean userExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * from `person` where `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Login already exists");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonRegistBack_MouseEnter(object sender, EventArgs e)
        {
            buttonRegistBack.ForeColor = Color.LightSeaGreen;
        }

        private void buttonRegistBack_MouseLeave(object sender, EventArgs e)
        {
            buttonRegistBack.ForeColor = Color.Turquoise;
        }

    }
}
