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
    public partial class DayForm : Form
    {
        User user;
        HealthCard hc;
        List<Day> list;
        public DayForm(User user, HealthCard hc)
        {
            this.user = user;
            this.hc = hc;
            list = createDaysList();
            InitializeComponent();
            labelDate.Text = DateTime.Now.Date.ToString();

        }

        private List<Day> createDaysList()
        {
            DB db = new DB();
            List<Day> list = new List<Day>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `day` WHERE `id_person` = @uID", db.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
            db.openConnection();
            MySqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                Day day = new Day();
                day.Id = rd.GetInt32("id");
                day.Date = rd.GetDateTime("date").Date;
                day.Water = rd.GetFloat("water");
                day.Kcal = rd.GetInt32("kcal");
                day.Protein = rd.GetFloat("protein");
                day.Fat = rd.GetFloat("fat");
                day.Carb = rd.GetFloat("carb");
                day.Fiber = rd.GetFloat("fiber");
                day.Exercise = rd.GetString("exercise");
                day.Id_Person = rd.GetInt32("id_person");
                list.Add(day);
            }

            db.closeConnection();
            return list;
        }

        private void buttonWater_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonWater.Height;
            sidePanel.Top = buttonWater.Top;

            if (!panelMain.Controls.Contains(WaterControl.Instance))
            {
                panelMain.Controls.Add(WaterControl.Instance);
                WaterControl.Instance.Dock = DockStyle.Fill;
                WaterControl.Instance.BringToFront();
                WaterControl.Instance.ComboBoxValueChanged += Instance_ComboBoxValueChanged;
                initializeLabelDayWater();
                initializeLabelWaterNecc();
            }
            else
                WaterControl.Instance.BringToFront();

            void initializeLabelDayWater()
            {
                string water = "0";
                foreach (Day day in list)
                {
                    if (day.Date.Equals(DateTime.Now.Date))
                        water = day.Water.ToString();
                    else
                        continue;
                    WaterControl.Instance.labelWaterDay.Text = water + " litres";
                }
               
            }

            void initializeLabelWaterNecc()
            {
                double waterNecc = hc.Weight * 0.03;
                WaterControl.Instance.labelWaterNecc.Text = waterNecc.ToString() + " litres a day" ;
            }
        }

        private void Instance_ComboBoxValueChanged()
        {
            switch(WaterControl.Instance.comboBoxWater.SelectedIndex)
            {
                case 0:
                    {
                        ShowStaticstics(0);
                        break;
                    }

                case 1:
                    {
                        ShowStaticstics(1);
                        break;
                    }
                case 2:
                    {
                        ShowStaticstics(2);
                        break;
                    }
            }
        }

        private void ShowStaticstics(int v)
        {
            double necc = hc.Weight * 0.03;
            
            
                if( v == 0)

                {
                foreach (Day day in list)
                {
                    if (day.Date.Equals(DateTime.Now.Date))
                    {
                        if (day.Water < necc)
                        {
                            double rest = necc - day.Water;
                            WaterControl.Instance.labelWaterResult.ForeColor = Color.DarkRed;
                            WaterControl.Instance.labelWaterResult.Text = "You need to drink  " + rest.ToString() + " litres more";
                        }
                        else
                        {
                            WaterControl.Instance.labelWaterResult.ForeColor = Color.DarkOliveGreen;
                            WaterControl.Instance.labelWaterResult.Text = "Your water balance is fine";
                        }
                    }
                }
                    
             
                }

                else if(v == 1)

                {
                double sum = 0.0;
                DateTime weekAgo = DateTime.Now.AddDays(-7);
                int counter = 0;
                foreach (Day day in list)
                {
                    if (day.Date >= weekAgo && day.Date <= DateTime.Now)
                    {
                        sum += day.Water;
                        counter++;
                    }
                }
                double avg = Math.Round(sum / Convert.ToDouble(counter), 2); 
                    if(sum >= necc* Convert.ToDouble(counter))
                {
                    WaterControl.Instance.labelWaterResult.ForeColor = Color.DarkGreen;
                    WaterControl.Instance.labelWaterResult.Text = "Throughout last week your water balance was FINE. Your average is " + avg+ " a day";
                }
                    else
                {
                    WaterControl.Instance.labelWaterResult.ForeColor = Color.DarkRed;
                    WaterControl.Instance.labelWaterResult.Text = "Throughout last week your water balance was NOT FINE. Your average is " + avg+ " a day ";
                }
            }
                else
                {
                double sum = 0.0;
                int counter = 0;
                DateTime monthAgo = DateTime.Now.AddDays(-30);
                foreach (Day day in list)
                {
                    if (day.Date >= monthAgo && day.Date <= DateTime.Now)
                    {
                        sum += day.Water;
                        counter++;
                    }
                }
                double avg = Math.Round(sum / Convert.ToDouble(counter), 2);
                if (sum >= necc * Convert.ToDouble(counter))
                {
                    WaterControl.Instance.labelWaterResult.ForeColor = Color.DarkGreen;
                    WaterControl.Instance.labelWaterResult.Text = "Throughout last month your water balance was FINE. Your average is " + avg + " a day";
                }
                else
                {
                    WaterControl.Instance.labelWaterResult.ForeColor = Color.DarkRed;
                    WaterControl.Instance.labelWaterResult.Text = "Throughout last month your water balance was NOT FINE. Your average is " + avg + " a day ";
                }
            }
        
        }

        private void buttonKcak_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonKcak.Height;
            sidePanel.Top = buttonKcak.Top;
            if (!panelMain.Controls.Contains(KcalControl.Instance))
            {
                panelMain.Controls.Add(KcalControl.Instance);
                KcalControl.Instance.Dock = DockStyle.Fill;
                KcalControl.Instance.BringToFront();
              //  initializeNeccButt();
                KcalControl.Instance.ShowChart += Instance_ShowChart;
            }
            else
                KcalControl.Instance.BringToFront();
               
        }

        private void initializeNeccButt()
        {
            throw new NotImplementedException();
        }

        private void Instance_ShowChart()
        {
            KcalControl.Instance.dataGridViewKcal.DataSource = getKcalList();
        }

        private DataTable getKcalList()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            using (MySqlCommand command = new MySqlCommand("SELECT `date`, `kcal` FROM `day` WHERE `id_person` = @uID", db.getConnection()))
            {
                command.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();
                table.Load(reader);
                

                db.closeConnection();
            }
            return table;
        }

        private void buttonProtein_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonProtein.Height;
            sidePanel.Top = buttonProtein.Top;
        }

        private void buttonFat_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFat.Height;
            sidePanel.Top = buttonFat.Top;
        }

        private void buttonCarb_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonCarb.Height;
            sidePanel.Top = buttonCarb.Top;
        }

        private void buttonFiber_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFiber.Height;
            sidePanel.Top = buttonFiber.Top;
        }

        private void buttonExercise_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonExercise.Height;
            sidePanel.Top = buttonExercise.Top;
        }
        Point lastPoint;
        private void DayForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DayForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }

        private void labelBackDay_Click(object sender, EventArgs e)
        {
            
        }

        private void labelNextDay_Click(object sender, EventArgs e)
        {

        }

    }
}
