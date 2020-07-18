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
    
    public partial class HealthCardRegister : Form
    {
        private  User user;
        private  HealthCard hc = new HealthCard();
        public HealthCardRegister(User user)
        {
            InitializeComponent();
            this.user = user;
            if(alreadyExists())
            {
                loadExistingData();
            }
        }

        private void loadExistingData()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand com = new MySqlCommand("select `id`, `birth_date`,`height`, `weight`, `activ_level` from `health_card` where id_person=@id", db.getConnection());
            com.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                fieldHeight.Text = reader.GetInt32("height").ToString();
                fieldWeight.Text = reader.GetFloat("weight").ToString();
                datePick.Value = reader.GetDateTime("birth_date");
                comboBoxActLevel.SelectedItem = reader.GetString("activ_level");
            }
            db.closeConnection();
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow(user);
            mw.ShowDialog();
        }

        private bool dataInserted()
        {
            if (datePick.Value == null )
                return false;
            if (fieldHeight.Text == "")
                return false;
            if (fieldHeight.Text == "")
                return false;
            if (comboBoxActLevel.SelectedItem == null)
                return false;
            else
                return true;
        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            if (!dataInserted())
                return;
            DB db = new DB();
            if(!alreadyExists()) // inserting new record
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `health_card` (`birth_date`, `weight`, `height`, `activ_level`, `id_person`) VALUES (@uBD, @uW, @uH, @uAL, @id)", db.getConnection());
               if(setParameters(command))
                {
                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data was succesfully inserted", "Adding");
                        createHealthCard(hc, db);
                        this.Close();
                        MainWindow mw = new MainWindow(user);
                        mw.ShowDialog();
                    }
                    else
                        MessageBox.Show("Data was not inserted!", "Adding");
                }
               else
                {
                    return;
                }
            }
            else // editing an old record
            {
                MySqlCommand command = new MySqlCommand("UPDATE health_card  SET birth_date = @uBD, weight = @uW, height = @uH, activ_level = @uAL WHERE id_person = @id", db.getConnection());
                if(setParameters(command))
                {
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data was succesfully updated", "Editing");
                        createHealthCard(hc, db);
                        db.closeConnection();
                        updateHistory(hc,db);
                    }
                    else
                    {
                        MessageBox.Show("Data was not updated", "Editing");
                        db.closeConnection();
                    }
                }
                else
                {
                    return;
                }

            }
            db.closeConnection();
        }

        private void updateHistory(HealthCard hc, DB db)
        {
            MySqlCommand comUpdate = new MySqlCommand("INSERT INTO `updates_history` (`update_date`, `weight`, `activ_level`, `id_hc`)" +
                                                                            " VALUES (@uDate, @uW, @uAL, @uID)", db.getConnection());
            comUpdate.Parameters.Add("@uDate", MySqlDbType.DateTime).Value = DateTime.Now;
            comUpdate.Parameters.Add("@uW", MySqlDbType.Float).Value = hc.Weight;
            comUpdate.Parameters.Add("@uAL", MySqlDbType.VarChar).Value = hc.ActLevel;
            comUpdate.Parameters.Add("@uID", MySqlDbType.Int32).Value = hc.Id;
            db.openConnection();
            comUpdate.ExecuteNonQuery();
            db.closeConnection();
        }

        private bool setParameters(MySqlCommand command)
        {
            if (!isDataValid())
            {
                return false;
            }
            else
            {
                command.Parameters.Add("@uBD", MySqlDbType.DateTime).Value = datePick.Value;
                command.Parameters.Add("@uW", MySqlDbType.Float).Value = float.Parse(fieldWeight.Text);
                command.Parameters.Add("@uH", MySqlDbType.Int32).Value = int.Parse(fieldHeight.Text);
                command.Parameters.Add("@uAL", MySqlDbType.VarChar).Value = comboBoxActLevel.SelectedItem;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
                return true;
            }
        }

        private bool isDataValid()
        {
            if (datePick.Value > DateTime.Now.AddYears(-7))
            {
                MessageBox.Show("You must be at least 7 years old to use this application", "Not valid age");
                return false;
            }
            else if (int.Parse(fieldHeight.Text) < 120 || int.Parse(fieldHeight.Text) > 230)
            {
                MessageBox.Show("Cannot accept such few/many cm", "Not valid height");
                return false;
            }

            else if (float.Parse(fieldWeight.Text) < 30.0 || float.Parse(fieldWeight.Text) > 350.0)
            {
                MessageBox.Show("Cannot accept such few/many kg", "Not valid weight");
                return false;
            }
            else
                return true;
                
        }

        private void createHealthCard(HealthCard hc, DB db)
        {
            MySqlCommand com = new MySqlCommand("select `id` from `health_card` where id_person=@id", db.getConnection());
            com.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                hc.Id = reader.GetInt32("id");
            }
            hc.BirthDate = datePick.Value;
            hc.Height = int.Parse(fieldHeight.Text);
            hc.Weight = float.Parse(fieldWeight.Text);
            hc.ActLevel = comboBoxActLevel.SelectedItem.ToString();
            hc.IdPerson = user.Id;
        }

        private bool alreadyExists()
        {
            DB db = new DB();
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * from `health_card` WHERE `id_person` = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if(dataTable.Rows.Count > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
    }
}
