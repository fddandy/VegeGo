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
    public partial class MainWindow : Form
    {
        User user;
        HealthCard hc = new HealthCard();
        List<Day> list;
        public MainWindow(User user)
        {
            InitializeComponent();
            labelLogAs.Text = user.Name + " " + user.SurName;
            this.user = user;
            
            sidePanel2.Height = labelMealTracker.Height;
            sidePanel2.Top = labelMealTracker.Top;
            loadHealthCard();
            list = createDaysList();
            sidepanel1.Visible = true;
        }

        private List<Day> createDaysList()
        {
            DB db = new DB();
            List<Day> list = new List<Day>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `day` WHERE `id_person` = @uID", db.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
            db.openConnection();
            MySqlDataReader rd = command.ExecuteReader();
            while(rd.Read())
            {
                Day day = new Day();
                day.Id = rd.GetInt32("id");
                day.Date = rd.GetDateTime("date").Date;
                if (!rd.IsDBNull(2))
                    day.Water = rd.GetFloat("water");
                else
                    day.Water = 0;
                if (!rd.IsDBNull(3))
                    day.Kcal = rd.GetInt32("kcal");
                else
                    day.Kcal = 0;
                if (!rd.IsDBNull(4))
                    day.Protein = rd.GetFloat("protein");
                else
                    day.Protein = 0;
                if (!rd.IsDBNull(5))
                    day.Fat = rd.GetFloat("fat");
                else
                    day.Fat = 0;
                if (!rd.IsDBNull(6))
                    day.Carb = rd.GetFloat("carb");
                else
                    day.Carb = 0;
                if (!rd.IsDBNull(7))
                    day.Fiber = rd.GetFloat("fiber");
                else
                    day.Fiber = 0;
                if (!rd.IsDBNull(8))
                    day.Exercise = rd.GetString("exercise");
                else
                    day.Exercise = string.Empty;
                day.Id_Person=rd.GetInt32("id_person");
                list.Add(day);
            }

            db.closeConnection();
            return list;
        }
        
        private void loadHealthCard()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand com = new MySqlCommand("select `id`, `birth_date`,`height`, `weight`, `activ_level` from `health_card` where id_person=@id", db.getConnection());
            com.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                hc.Id = reader.GetInt32("id");
                hc.BirthDate = reader.GetDateTime("birth_date").Date;
                hc.Height = reader.GetInt32("height");
                hc.Weight = reader.GetDouble("weight");
                hc.ActLevel = reader.GetString("activ_level");
            }
            db.closeConnection();
            if(dataExists())
            {
                labelH.Text = hc.Height.ToString();
                labelW.Text = hc.Weight.ToString();
                labelBD.Text = hc.BirthDate.ToString();
                labelAL.Text = hc.ActLevel.ToString();
            }
            else
            {
                labelH.Text = "";
                labelW.Text = "";
                labelBD.Text = "";
                labelAL.Text = "";
            }
            
        }

        private bool dataExists()
        {
            if (hc.Id == 0 || hc.Weight == 0.0 ||
               hc.Height == 0 || hc.BirthDate == null)
                return false;
            else
                return true;
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X- lastPoint.X;
                this.Top += e.Y- lastPoint.Y;
            }
        }

        private void LbCard_MouseClick(object sender, MouseEventArgs e)
        {
            this.Controls.Remove(panelWater);
            panelWater.SendToBack();
            panelWater.Visible = false;
            panelMain.BringToFront();
            sidepanel1.Visible = true;
            sidePanel2.Visible = false;
            sidePanel3.Visible = false;
            sidePanel4.Visible = false;
            sidePanel5.Visible = false;
            panelMain.Visible = true;
            comboBoxPeriod.Text = "-----select-----";
            comboBoxChartType.SelectedIndex = 2;
            labelDate.Text = DateTime.Now.Date.ToString();
            
        }

        private void buttonEditHC_Click(object sender, EventArgs e)
        {
            this.Close();
            HealthCardRegister healthCard = new HealthCardRegister(user);
            healthCard.ShowDialog();
        }

        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartWeight.Series["SeriesW"].Points.Clear();
            switch (comboBoxPeriod.SelectedIndex)
            {
                case 0:
                    {
                        drawChart("week");
                        break;
                    }
                case 1:
                    {
                        drawChart("month");
                        break;
                    }
                case 2:
                    {
                        drawChart("year");
                        break;
                    }
            }
        }

        private void drawChart(string sort)
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                DateTime maxDate = DateTime.Now.Date;
                DateTime minDate = DateTime.Now.AddDays(-7).Date; ;
                MySqlCommand command = new MySqlCommand("SELECT `weight`, `update_date` FROM `updates_history` WHERE id_hc = @uID AND update_date BETWEEN @uStart and @uEnd", db.getConnection());
                command.Parameters.Add("@uID", MySqlDbType.Int32).Value = hc.Id;
                switch (sort)
                {
                    case "week":
                        {
                            command.Parameters.Add("@uStart", MySqlDbType.Date).Value = DateTime.Now.AddDays(-7).Date;
                            minDate = DateTime.Now.AddDays(-7).Date;
                            command.Parameters.Add("@uEnd", MySqlDbType.Date).Value = DateTime.Now.Date;
                            chartWeight.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
                            break;
                        }
                    case "month":
                        {
                            command.Parameters.Add("@uStart", MySqlDbType.Date).Value = DateTime.Now.AddDays(-30).Date;
                            minDate = DateTime.Now.AddDays(-30).Date;
                            command.Parameters.Add("@uEnd", MySqlDbType.Date).Value = DateTime.Now.Date;
                            chartWeight.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
                            break;
                        }
                    case "year":
                        {
                            command.Parameters.Add("@uStart", MySqlDbType.Date).Value = DateTime.Now.AddDays(-365).Date;
                            minDate = DateTime.Now.AddDays(-365).Date;
                            command.Parameters.Add("@uEnd", MySqlDbType.Date).Value = DateTime.Now.Date;
                            chartWeight.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
                            break;
                        }
                   
                }

                MySqlDataReader reader;
                reader = command.ExecuteReader();
               // chartWeight.Series["SeriesWeight"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                chartWeight.ChartAreas[0].AxisX.Interval = 1;
                chartWeight.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                chartWeight.Series["SeriesW"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                chartWeight.ChartAreas[0].AxisY.Maximum = 150;
                chartWeight.ChartAreas[0].AxisY.Minimum = 0;
                chartWeight.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
                chartWeight.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                while (reader.Read())
                {
                   // chartWeight.Series["SeriesWeight"].Points.AddXY(reader.GetDateTime("update_date"), reader.GetFloat("weight"));
                    chartWeight.Series["SeriesW"].Points.AddXY(reader.GetDateTime("update_date").Date, reader.GetFloat("weight"));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(db.getConnection().State == ConnectionState.Open)
                {
                    db.closeConnection();
                }
            }
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChartType.SelectedIndex)
            {
                case 0: // column
                    {
                        chartWeight.Series["SeriesW"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        break;
                    }
                case 1: //spline
                    {
                        chartWeight.Series["SeriesW"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                        break;
                    }
                case 2: //line
                    {
                        chartWeight.Series["SeriesW"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        break;
                    }
                case 3: //point
                    {
                        chartWeight.Series["SeriesW"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        break;
                    }
            }

        }

        private void labelBMI_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BMI bmi = new BMI(hc, user);
            bmi.ShowDialog();
        }

        private void labelMealTracker_MouseClick(object sender, MouseEventArgs e)
        {
            this.Controls.Remove(panelWater);
            sidepanel1.Visible = false;
            sidePanel2.Visible = false;
            sidePanel3.Visible = true;
            sidePanel4.Visible = false;
            sidePanel5.Visible = false;

            DayForm dayForm = new DayForm(user, hc);
            dayForm.ShowDialog();
            dayForm.BringToFront();
            panelMain.SendToBack();
            
            
        }

        private void labelAddMeal_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(panelWater);
            sidepanel1.Visible = false;
            sidePanel2.Visible = true;
            sidePanel3.Visible = false;
            sidePanel4.Visible = false;
            sidePanel5.Visible = false;
            AddMealForm addMealForm = new AddMealForm(user);
            addMealForm.ShowDialog();
        }

        private void labelWater_Click(object sender, EventArgs e)
        {
            sidepanel1.Visible = false;
            sidePanel2.Visible = false;
            sidePanel3.Visible = false;
            sidePanel4.Visible = true;
            sidePanel5.Visible = false;
            panelMain.SendToBack();
            panelMain.Visible = false;
            panelWater.BringToFront();
            panelWater.Visible = true;
            
            this.Controls.Add(panelWater);

        }

        private void buttonWaterSubmit_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(numericUpDownWater.Value) == 0.0)
            {
                MessageBox.Show("Add some water", "Warning");
                return;
            }
            else
            {
                
                DB db = new DB();
                
                double waterBefore = CreateDay();
                
                MySqlCommand command = new MySqlCommand("UPDATE `day` SET `water` = @uW WHERE `date` = @uD AND `id_person` = @uID_person", db.getConnection());
                command.Parameters.Add("@uW", MySqlDbType.Double).Value = Math.Round((Convert.ToDouble(numericUpDownWater.Value) + waterBefore), 2);
                command.Parameters.Add("@uD", MySqlDbType.DateTime).Value = DateTime.Now.Date;
                command.Parameters.Add("@uID_person", MySqlDbType.Int32).Value = user.Id;
                db.openConnection();
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Great job, "+numericUpDownWater.Value.ToString()+" litres is an amazing step!", "Success");
                }
                else
                {
                    MessageBox.Show("Oooops...something went wrong,"+Environment.NewLine+" could not add "+numericUpDownWater.ToString()+" litres", "Warning");
                }
                db.closeConnection();
            }

        }

        private double CreateDay()
        {
            List<Day> temp = createDaysList();
            int counter = 0;
            double waterBefore = 0.0;
            foreach (Day day in temp)
            {
                if (day.Date == DateTime.Now.Date)
                {
                    counter++;
                    waterBefore = day.Water;
                }
                else
                {
                    continue;
                }
            }
            if (counter == 0)
            {
                DB db = new DB();
                MySqlCommand com = new MySqlCommand("INSERT INTO `day`(`date`, `id_person`, `water`, `kcal`," +
                    " `protein`, `fat`, `fiber`,`carb`, `exercise`) VALUES" +
                    " (@uD, @uID, @uW, @uK, @uP, @uFt, @uFb, @uC, @uE)", db.getConnection());
                com.Parameters.Add("@uD", MySqlDbType.DateTime).Value = DateTime.Now.Date;
                com.Parameters.Add("@uID", MySqlDbType.Int32).Value = user.Id;
                com.Parameters.Add("@uP", MySqlDbType.Double).Value = 0;
                com.Parameters.Add("@uFt", MySqlDbType.Double).Value = 0;
                com.Parameters.Add("@uFb", MySqlDbType.Double).Value = 0;
                com.Parameters.Add("@uC", MySqlDbType.Double).Value = 0;
                com.Parameters.Add("@uK", MySqlDbType.Int32).Value = 0;
                com.Parameters.Add("@uW", MySqlDbType.Double).Value = numericUpDownWater.Value.ToString();
                com.Parameters.Add("@uE", MySqlDbType.VarChar).Value = string.Empty;
                db.openConnection();
                com.ExecuteNonQuery();
                db.closeConnection();
            }
            return waterBefore;
        }
    }
}

