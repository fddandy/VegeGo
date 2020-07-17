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
            String login = loginField.Text;
            String pass = passField.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * from `person` where `login`=@uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            if(adapter == null)
            {
                MessageBox.Show("Please, provide data");
            }
            else 
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
               // string temp = "";
                db.openConnection();
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
