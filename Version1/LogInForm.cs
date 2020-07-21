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
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `id`, `name` , `surname`, `pass`, `userGuid` from `person`  where `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            db.openConnection();
            MySqlDataReader dr = command.ExecuteReader();
            if(dr == null)
            {
                MessageBox.Show("Login is incorrect");
            }
            while(dr.Read())
            {
                byte[] salt = Convert.FromBase64String(dr.GetString("userGuid"));
                byte[] dbPassword = Convert.FromBase64String(dr.GetString("pass"));
                byte[] hashedPassword = Encryption.ComputeH(passFromText, salt);

                string p1 = Convert.ToBase64String(dbPassword);
                string p2 = Convert.ToBase64String(hashedPassword);
                /*
                //string dbPassword = Convert.ToString(dr["pass"]);
                //  string dbUserGuid = Convert.ToString(dr["userGuid"]);
                string dbPassword = dr.GetString("pass");
                string dbUserGuid = dr.GetString("userGuid");

                //string hashedOnlyPasswordFromField = Encryption.hashMD5(pass);
                string hashedPassword = Encryption.hashMD5(passFromText, dbUserGuid);
                */
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
            /*
            
            if (table.Rows.Count > 0)
            {
               // string temp = "";
               
                MySqlCommand com = new MySqlCommand("SELECT `id`, `name`, `surname` from `person` where `login`=@uL AND `pass` = @uP", db.getConnection());
                com.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                com.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                   // temp = reader.GetString("name") +" "+ reader.GetString("surname");
                    user = new User(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("surname"));
                }

                this.Hide();
                
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.Show();
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Login or password are incorrect");
            }
            */
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
