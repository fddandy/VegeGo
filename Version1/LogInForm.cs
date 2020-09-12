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
    public partial class LogInForm : Form
    {
        User user;
        public LogInForm()
        {
            InitializeComponent();
            
        }

        private void closeButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.GreenYellow;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void LogInForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LogInForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonRegister.ForeColor = Color.DarkGreen;
            string login = loginField.Text;
            string passFromText = passField.Text.ToString();
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `id`, `name` , `surname`, `pass`, `userGuid` from `person`  where `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            db.openConnection();
            MySqlDataReader dr = command.ExecuteReader();
            if(!dr.HasRows) //dr.GetValue(0) == DBNull.Value
            {
                MessageBox.Show("Login is incorrect");
                return;
            }
            while(dr.Read())
            {
                byte[] salt = Convert.FromBase64String(dr.GetString("userGuid"));
                byte[] dbPassword = Convert.FromBase64String(dr.GetString("pass"));
                byte[] hashedPassword = Encryption.ComputeH(passFromText, salt);

                string p1 = Convert.ToBase64String(dbPassword);
                string p2 = Convert.ToBase64String(hashedPassword);
                
                if (p1.Equals(p2))
                {
                    user = new User(dr.GetInt32("id"), dr.GetString("name"), dr.GetString("surname"));
                    this.Hide();
                    MainWindow mainWindow = new MainWindow(user);
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                }   
            }
                    db.closeConnection();
     
        }

        private void RegisterForm_Cilck(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterForm rf = new RegisterForm();
            rf.Show();
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.ForeColor = Color.DarkGreen;
        }
    }
}
