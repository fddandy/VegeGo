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
        public MainWindow(User user)
        {
            InitializeComponent();
            labelLogAs.Text = user.Name +" "+ user.SurName;
            this.user = user;
            loadHealthCard();
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
                hc.Weight = reader.GetInt32("weight");
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
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LbCard_MouseClick(object sender, MouseEventArgs e)
        {
            panelMain.Visible = true;
        }

        private void buttonEditHC_Click(object sender, EventArgs e)
        {
            this.Close();
            HealthCardRegister healthCard = new HealthCardRegister(user);
            healthCard.ShowDialog();
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartWeight.Series["SeriesWeight"].Points.Clear();
            drawChart();
        }

        private void drawChart()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT `weight`, `update_date` FROM `updates_history` WHERE id_hc = @uID ", db.getConnection());
                command.Parameters.Add("@uID", MySqlDbType.Int32).Value = hc.Id;
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                chartWeight.Series["SeriesWeight"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                chartWeight.ChartAreas[0].AxisX.Interval = 1;
                chartWeight.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
               // chartWeight.ChartAreas[0].AxisX.
                chartWeight.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
               // chartWeight.ChartAreas[0].AxisX.IntervalOffset = 1;
                DateTime maxDate = DateTime.Now;
                DateTime minDate = new DateTime(2020, 07, 10);
                chartWeight.ChartAreas[0].AxisY.Maximum = 350;
                chartWeight.ChartAreas[0].AxisY.Minimum = 0;
                chartWeight.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
                chartWeight.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                while (reader.Read())
                {
                    
                    chartWeight.Series["SeriesWeight"].Points.AddXY(reader.GetFloat("weight"), reader.GetDateTime("update_date"));
                    
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
    }
}
