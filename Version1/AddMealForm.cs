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
    public partial class AddMealForm : Form
    {
        private User user;
        public AddMealForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
        Point lastPoint;
        private void AddMealForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddMealForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(dataValid())
            {
                DB db = new DB();
                int dayID = 0;
                MySqlCommand com = new MySqlCommand("SELECT `id` FROM `day` WHERE `id_person` = @uID AND `date` = @uD",db.getConnection());
                com.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
                com.Parameters.Add("@uD", MySqlDbType.DateTime).Value = datePicker.Value.Date;
                db.openConnection();
                MySqlDataReader reader = com.ExecuteReader();
                if(reader.HasRows)
                {
                    dayID = reader.GetInt32("id");
                    db.closeConnection();
                }
                
                else
                {
                    db.closeConnection();
                    using (MySqlCommand c = new MySqlCommand("INSERT INTO `day`(`id`,`date`, `id_person`) " +
                        "VALUES (@id, @uD, @uID_person)", db.getConnection()))
                    {
                        db.openConnection();
                        c.Parameters.Add("@uD", MySqlDbType.DateTime).Value = datePicker.Value.Date;
                        c.Parameters.Add("@uID_person", MySqlDbType.Int32).Value = user.Id;
                        c.Parameters.Add("@id", MySqlDbType.Int32).Value = 85;
                        //c.Parameters.Add("@uID", MySqlDbType.Int32).Direction = ParameterDirection.ReturnValue;
                        dayID = 80;  //Convert.ToInt32(c.Parameters["@uID"].Value);
                        c.ExecuteNonQuery();

                        db.closeConnection();
                    }
                }

                

                using(MySqlCommand command = new MySqlCommand("INSERT INTO `meal`(`type`, `foodConsumed`, `weight`, " +
                    "`kcal`, `protein`, `fat`, `carb`, `fiber`, `amount`, `id_day`) VALUES (@uT, @uFC, @uW, @uK," +
                    " @uP, @uFt, @uC, @uFb, @uAm, @uID_day)", db.getConnection()))
                {
                    command.Parameters.Add("@uT", MySqlDbType.VarChar).Value = Convert.ToString(comboBoxType.SelectedText);
                    command.Parameters.Add("@uFC", MySqlDbType.VarChar).Value = textBoxFood.Text;
                    command.Parameters.Add("@uW", MySqlDbType.Float).Value = Convert.ToDouble(maskedTextBoxWeight.Text);
                    command.Parameters.Add("@uK", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBoxKcal.Text);
                    command.Parameters.Add("@uP", MySqlDbType.Float).Value = Convert.ToDouble(maskedTextBoxProtein.Text);
                    command.Parameters.Add("@uFt", MySqlDbType.Float).Value = Convert.ToDouble(maskedTextBoxFat.Text);
                    command.Parameters.Add("@uC", MySqlDbType.Float).Value = Convert.ToDouble(maskedTextBoxCarbs.Text);
                    command.Parameters.Add("@uFb", MySqlDbType.Float).Value = Convert.ToDouble(maskedTextBoxFiber.Text);
                    command.Parameters.Add("@uAm", MySqlDbType.Float).Value = Convert.ToDouble(maskedTextBoxWeight.Text);
                    command.Parameters.Add("@uID_day", MySqlDbType.Int32).Value = dayID;
                    db.openConnection();
                   
                    if(command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Your meal was uploaded", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Ooops...could not load your meal", "Try again");
                    }


                    db.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Please, list the food you have eaten in a given day.","Shortage of data");
            }
        }

        private bool dataValid()
        {
            if(textBoxFood.Text.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxQuantity.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxWeight.Visible = true;
        }
    }
}
