using LiveCharts;
using LiveCharts.Wpf;
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
        private  User user;
        private HealthCard hc;
        private List<Day> list;
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
                WaterControl.Instance.labelWaterDay.Text = water;
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
                        WaterControl.Instance.labelWaterResult.Text = "No data inserted";
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
              
                KcalControl.Instance.ShowChart += Instance_ShowChart;
                KcalControl.Instance.RadioButtonChanged += Instance_RadioButtonChanged;
                
            }
            else
                KcalControl.Instance.BringToFront();
               
        }

        private void Instance_RadioButtonChanged(string sexSelected)
        {
            //labelKcalNecc 
            double ppm = 0.0;
            int age = DateTime.Now.Year - hc.BirthDate.Year;
            if (sexSelected.Equals("Male"))
            {
                ppm = 66.5 +13.75 * hc.Weight + 5.003 * hc.Height - 6.775 * age;
            }
            else if(sexSelected.Equals("Female"))
            {
                ppm = 655.1 + 9.563 * hc.Weight + 1.85 * hc.Height - 4.676 * age;
            }
            KcalControl.Instance.labelKcalNecc.Text= ((int)(Math.Round(ppm * LevelOfActiveness(hc)))).ToString();
            if (KcalControl.Instance.dataGridViewKcal.DataSource != null)
            {
                Instance_ShowChart();
            }
           
        }

        private double LevelOfActiveness(HealthCard hc)
        {
            double PAL = 0.0;
            switch (hc.ActLevel)
            {
                case "Sedentary: little or no exercise":
                    {
                        PAL = 1.2;
                        break;
                    }
                case "Light: exercise 1-3 times a week":
                    {
                        PAL = 1.3;
                        break;
                    }
                case "Moderate: exercise 4-5 times a week":
                    {
                        PAL = 1.4;
                        break;
                    }
                case "Active: daily exercise or intense exercise 3-4 times a week":
                    {
                        PAL = 1.5;
                        break;

                    }
                case "Very active: intense exercise 6-7 times a week":
                    {
                        PAL = 1.6;
                        break;
                    }
                case "Extra active: very intense exercise daily or physical job":
                    {
                        PAL = 1.7;
                        break;
                    }
                default:
                    {
                        PAL = 1.2;
                        break;
                    }
            }
            return PAL;
        }

        private void Instance_ShowChart()
        {
            KcalControl.Instance.dataGridViewKcal.DataSource = getKcalList();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            foreach(DataGridViewRow item in KcalControl.Instance.dataGridViewKcal.Rows) //KcalControl.Instance.dataGridViewKcal lub getKcalList().Rows
            {
                if(Convert.ToInt32(item.Cells[1].Value) < Convert.ToInt32(KcalControl.Instance.labelKcalNecc.Text))  //
                {
                   
                    style.ForeColor = Color.Green;
                    item.Cells[1].Style.ForeColor = Color.Green;
                }
                else if(Convert.ToInt32(item.Cells[1].Value) > Convert.ToInt32(KcalControl.Instance.labelKcalNecc.Text))
                {
                    
                    style.ForeColor = Color.Red;
                    item.Cells[1].Style.ForeColor = Color.Red ;

                }
               // KcalControl.Instance.dataGridViewKcal.Rows.;
            }
            
        }

        private DataTable getKcalList()
        {
            if (KcalControl.Instance.labelKcalNecc.Text != "")
            {
                DB db = new DB();
                DataTable table = new DataTable();
                using (MySqlCommand command = new MySqlCommand("SELECT `date`, `kcal` FROM `day` WHERE `id_person` = @uID ORDER BY 1 asc", db.getConnection()))
                {
                    command.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
                    db.openConnection();

                    MySqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                   
                    db.closeConnection();
                }
                return table;
            }
            else
                MessageBox.Show("Please, choose your sex before loading data.", "Warning");
                return null ;
            
        }

        private void buttonProtein_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonProtein.Height;
            sidePanel.Top = buttonProtein.Top;
            PFCControlShow();
        }

        private void PFCControlShow()
        {
            if (!panelMain.Controls.Contains(PFCControl.Instance))
            {
                panelMain.Controls.Add(PFCControl.Instance);
                PFCControl.Instance.Dock = DockStyle.Fill;
                PFCControl.Instance.BringToFront();

                PFCControl.Instance.PCFButtonChanged += Instance_PCFButtonChanged;

               // loadLiveChart(DateTime.Now.Date);
                PFCControl.Instance.PFCdateChanged += Instance_PFCdateChanged;
            }
            else
                PFCControl.Instance.BringToFront();
        }

        private void Instance_PFCdateChanged(DateTime date)
        {
            
            // znalezc czy w ogole jest taka data zapisana w db
            if(DateExists(date))
            {
                PFCControl.Instance.pieChart1.Refresh();
                loadLiveChart(date);
            }
            else
            {
                MessageBox.Show("There is no data in the database matching your date criterium", "Warning", MessageBoxButtons.OKCancel);
            }
            
            
        }

   
        private bool DateExists(DateTime d)
        {
            DB db = new DB();
            int counter = 0;
            using (MySqlCommand command = new MySqlCommand("SELECT `date` FROM `day` WHERE `id_person` = @uID AND `date` = @uD", db.getConnection()))
            {
                command.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
                command.Parameters.Add("@uD", MySqlDbType.DateTime).Value = d;
                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    counter++;
                }
                db.closeConnection();
                if (counter > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                } 
            }
        }

        private void loadLiveChart(DateTime date)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            PFCControl.Instance.pieChart1.LegendLocation = LegendLocation.Left;

            DB db = new DB();
            using (MySqlCommand command = new MySqlCommand("SELECT `date`, `fat`, `carb`, `protein` FROM `day` WHERE `id_person` = @uID and `date`= @uD", db.getConnection()))
            {
                command.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
                command.Parameters.Add("uD", MySqlDbType.DateTime).Value = date;
                db.openConnection();
                MySqlDataReader reader = command.ExecuteReader();
               
                while(reader.Read())
                {
                    
                        PFCControl.Instance.pieChart1.Series = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "Fat",
                    Values = new ChartValues<float> { reader.GetFloat("fat")},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.LightBlue
                    },
                    new PieSeries
                    {
                        Title = "Carbohydrates",
                    Values = new ChartValues<float> { reader.GetFloat("carb")},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.LightPink
                    },
                    new PieSeries
                    {
                        Title = "Protein",
                        Values = new ChartValues<float> { reader.GetFloat("protein") },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Fill = System.Windows.Media.Brushes.Yellow
                    }

                };
                    
                    
                }
                
                db.closeConnection();
            }
        }

        private void Instance_PCFButtonChanged()
        {
          
           
        }

        private void buttonFat_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFat.Height;
            sidePanel.Top = buttonFat.Top;
            PFCControlShow();
        }

        private void buttonCarb_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonCarb.Height;
            sidePanel.Top = buttonCarb.Top;
            PFCControlShow();
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
