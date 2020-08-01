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
    public enum Type {Int, Double}
    public partial class AddMealForm : Form
    {
        private User user;
        private int metrics= 0; // 0 stands for weight, 1 for amount
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
                int counter = 0;
                MySqlCommand com = new MySqlCommand("SELECT `id` FROM `day` WHERE `id_person` = @uID AND `date` = @uD", db.getConnection());
                com.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
                com.Parameters.Add("@uD", MySqlDbType.DateTime).Value = datePicker.Value.Date;
                db.openConnection();
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                }
                if (counter > 0)
                {
                    dayID = reader.GetInt32("id");
                   db.closeConnection();
                    insertMeal(db, dayID);
                    db.closeConnection();
                }
                else
                { // if date doesnt exist in a DAY table
                    db.closeConnection();
                    MySqlCommand c = new MySqlCommand("INSERT INTO `day`(`date`, `water`, `kcal`, `protein`, `fat`," +
                        " `carb`, `fiber`, `exercise`, `id_person`) " + "VALUES (@uD, @uW, @uK, @uP, @uFt, @uC, @uFb, @uE, @uID_person)", db.getConnection());
                    try
                    {
                        db.openConnection();
                        c.Parameters.Add("@uD", MySqlDbType.DateTime).Value = datePicker.Value.Date;
                        c.Parameters.Add("@uID_person", MySqlDbType.Int32).Value = user.Id;
                        c.Parameters.Add("@uW", MySqlDbType.Double).Value = 0;
                        c.Parameters.Add("@uE", MySqlDbType.VarChar).Value = string.Empty;
                        // assign the rest to inserted data instead of NULL

                        validParam(c, textBoxKcal, "@uK", MySqlDbType.Int32);
                        validParam(c, textBoxProtein, "@uP", MySqlDbType.Double);
                        validParam(c, textBoxFat, "@uFt", MySqlDbType.Double);
                        validParam(c, textBoxCarbs, "@uC", MySqlDbType.Double);
                        validParam(c, textBoxFiber, "@uFb", MySqlDbType.Double);
                       
                        c.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                        using (MySqlCommand command = new MySqlCommand("INSERT INTO `meal`(`type`, `foodConsumed`, `weight`, " +
                                "`kcal`, `protein`, `fat`, `carb`, `fiber`, `amount`, `id_day`) VALUES (@uT, @uFC, @uW, @uK," +
                                " @uP, @uFt, @uC, @uFb, @uAm, LAST_INSERT_ID())", db.getConnection()))
                        {
                            if(!setParametres(command))
                                return;

                            if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your meal was uploaded", "Success");
                            clearmealForm();
                        }
                        else
                            {
                                MessageBox.Show("Ooops...could not load your meal", "Try again");
                            }
                            db.closeConnection();
                        }
                }

            }
            else
            {
                return;
            }
        }

        private void clearmealForm()
        {
            comboBoxType.SelectedIndex = 0;
            textBoxCarbs.Text = string.Empty;
            textBoxFat.Text = string.Empty;
            textBoxFiber.Text = string.Empty;
            textBoxFood.Text = string.Empty;
            textBoxKcal.Text = string.Empty;
            textBoxProtein.Text = string.Empty;
            textBoxWeiQua.Text = string.Empty;
        }

        private bool setParametres(MySqlCommand command)
        {
            try
            {
                command.Parameters.Add("@uT", MySqlDbType.VarChar).Value = Convert.ToString(comboBoxType.SelectedText);
                command.Parameters.Add("@uFC", MySqlDbType.VarChar).Value = textBoxFood.Text;

                validParam(command, textBoxKcal, "@uK", MySqlDbType.Int32);
                validParam(command, textBoxProtein, "@uP", MySqlDbType.Double);
                validParam(command, textBoxFat, "@uFt", MySqlDbType.Double);
                validParam(command, textBoxCarbs, "@uC", MySqlDbType.Double);
                validParam(command, textBoxFiber, "@uFb", MySqlDbType.Double);

                if (metrics == 1) // quantity
                {
                    if(textBoxWeiQua.Text == string.Empty)
                    {
                        command.Parameters.Add("@uAm", MySqlDbType.Double).Value = 0;
                        command.Parameters.Add("@uW", MySqlDbType.Double).Value = 0;
                        return true;
                    }
                    else
                    {
                        if(QuantityValid())
                        {
                            command.Parameters.Add("@uAm", MySqlDbType.Double).Value = Convert.ToDouble(textBoxWeiQua.Text);
                            command.Parameters.Add("@uW", MySqlDbType.Double).Value = 0;
                            return true;
                        }
                        else
                            return false;
                    }
                }
                else //weight
                {
                    if (textBoxWeiQua.Text == string.Empty)
                    {
                        command.Parameters.Add("@uAm", MySqlDbType.Double).Value = 0;
                        command.Parameters.Add("@uW", MySqlDbType.Double).Value = 0;
                        return true;
                    }
                    else
                    {
                        if(WeightValid())
                        {
                            command.Parameters.Add("@uW", MySqlDbType.Double).Value = Convert.ToDouble(textBoxWeiQua.Text);
                            command.Parameters.Add("@uAm", MySqlDbType.Double).Value = 0;
                            return true;
                        }
                        else
                            return false;
                    }

                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
                
        }
        private bool isParInRange(string text, double max, string textBox)
        {
            if (!double.TryParse(text, out _))
            {
                MessageBox.Show("Please enter a decimal number.", textBox + " is invalid");
                return false;
            }
            else if (double.TryParse(text, out _) &&
                (Convert.ToDouble(text) > max || Convert.ToDouble(text) < 0))
            {
                MessageBox.Show(textBox + " might be max " + max, textBox + " is invalid");
                
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool QuantityValid()
        {
            if (!int.TryParse(textBoxWeiQua.Text, out _))
            {
                MessageBox.Show("Please enter a number.", "Quantity is invalid");
                return false;
            }
            else if (int.TryParse(textBoxWeiQua.Text, out _) &&
                (Convert.ToInt32(textBoxWeiQua.Text) > 100 || Convert.ToInt32(textBoxWeiQua.Text) < 0))
            {
                MessageBox.Show("Quantity might be max 100", "Quantity is invalid");
                return false;
            }
            else
            {
                buttonSubmit.Enabled = true;
                return true;
            }
        }

        private bool WeightValid()
        {
            if (!double.TryParse(textBoxWeiQua.Text, out _))
            {
                MessageBox.Show("Please enter a decimal number.", "Weight is invalid");
                return false;

            }
            else if (double.TryParse(textBoxWeiQua.Text, out _) &&
                (Convert.ToDouble(textBoxWeiQua.Text) > 2.0 || Convert.ToDouble(textBoxWeiQua.Text) < 0))
            {
                MessageBox.Show("Weight might be max 2 kg", "Weight is invalid");
                return false;
            }
            else
            {
                buttonSubmit.Enabled = true;
                return true;
            }
        }

        private void validParam(MySqlCommand command, TextBox textbox , string name, MySqlDbType type)
        {
            if (textbox.Text != "")
            {
                if (type == MySqlDbType.Int32)
                    command.Parameters.Add(name, type).Value = Convert.ToInt32(textbox.Text);
                else
                    command.Parameters.Add(name, type).Value = Convert.ToDouble(textbox.Text);
            }   
            else
            {
                    command.Parameters.Add(name,type).Value = 0;
            }
                
        }
        private void insertMeal(DB db, int dayID)
        {
            using (MySqlCommand command = new MySqlCommand("INSERT INTO `meal`(`type`, `foodConsumed`, `weight`, " +
                                "`kcal`, `protein`, `fat`, `carb`, `fiber`, `amount`, `id_day`) VALUES (@uT, @uFC, @uW, @uK," +
                                " @uP, @uFt, @uC, @uFb, @uAm, @uID_day)", db.getConnection()))
            {
                if (!setParametres(command))
                    return;

                command.Parameters.Add("@uID_day", MySqlDbType.Int32).Value = dayID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Your meal was uploaded", "Success");
                    clearmealForm();
                }
                else
                {
                    MessageBox.Show("Ooops...could not load your meal", "Try again");
                }


                db.closeConnection();
            }
        }

        private string AdaptTextBox(TextBox textBox)
        {
            if(textBox.Text == string.Empty)
            {
                return "0";
            }else
            {
                return textBox.Text;
            }
        }
        private bool dataValid()
        {
            if(textBoxFood.Text.Length != 0)
            {

                if (isParInRange(AdaptTextBox(textBoxFat), 100, "Fat") &&
                    isParInRange(AdaptTextBox(textBoxKcal), 1500, "Kcal") &&
                    isParInRange(AdaptTextBox(textBoxCarbs), 350, "Carbohydrates") &&
                    isParInRange(AdaptTextBox(textBoxFiber), 60, "Fiber") &&
                    isParInRange(AdaptTextBox(textBoxProtein), 100, "Protein"))
                    return true;
                else
                    return false;


                /*
                    if (!int.TryParse(AdaptTextBox(textBoxKcal), out _))
                    {
                        return false;
                    }
                    else if (!double.TryParse(AdaptTextBox(textBoxFat), out _))
                    {
                        return false;
                    }
                    else if (!double.TryParse(AdaptTextBox(textBoxCarbs), out _))
                    {
                        return false;
                    }
                    else if (!double.TryParse(AdaptTextBox(textBoxFiber), out _))
                    {
                        return false;
                    }
                    else if (!double.TryParse(AdaptTextBox(textBoxProtein), out _))
                    {
                        return false;
                    }
                    else if (!double.TryParse(AdaptTextBox(textBoxWeiQua), out _))
                    {
                        return false ;
                    }
                    else
                        return true;
                */
            }
            else
            {
                return false;
            }
        }
        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWeiQua.Visible = true;
            metrics = 1;
            textBoxWeiQua.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWeiQua.Visible = true;
            metrics = 0;
            textBoxWeiQua.Text = "";
        }
    }
}
