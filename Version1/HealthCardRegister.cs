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
                setParameters(command);
                /*
                command.Parameters.Add("@birth_date", MySqlDbType.DateTime).Value = datePick.Value;
                command.Parameters.Add("@weight", MySqlDbType.Float).Value = float.Parse(fieldWeight.Text);
                command.Parameters.Add("@height", MySqlDbType.Int32).Value = int.Parse(fieldHeight.Text);
                command.Parameters.Add("@activ_level", MySqlDbType.VarChar).Value = comboBoxActLevel.SelectedItem;
                command.Parameters.Add("@id_person", MySqlDbType.Int32).Value = user.Id;
               */
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data was succesfully inserted", "Adding");
                    createHealthCard(hc, db);
                }
                else
                    MessageBox.Show("Data was not inserted!", "Adding");
            }
            else // editing an old record
            {
                MySqlCommand command = new MySqlCommand("UPDATE health_card  SET birth_date = @uBD, weight = @uW, height = @uH, activ_level = @uAL WHERE id_person = @id", db.getConnection());
                setParameters(command);
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data was succesfully updated", "Editing");
                    createHealthCard(hc, db);
                }
                else
                {
                    MessageBox.Show("Data was not updated", "Editing");
                }

            }
            db.closeConnection();
        }

        private void setParameters(MySqlCommand command)
        {
            command.Parameters.Add("@uBD", MySqlDbType.DateTime).Value = datePick.Value;
            command.Parameters.Add("@uW", MySqlDbType.Float).Value = float.Parse(fieldWeight.Text);
            command.Parameters.Add("@uH", MySqlDbType.Int32).Value = int.Parse(fieldHeight.Text);
            command.Parameters.Add("@uAL", MySqlDbType.VarChar).Value = comboBoxActLevel.SelectedItem;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
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
