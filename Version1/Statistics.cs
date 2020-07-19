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
    public partial class Statistics : Form
    {
        public Statistics(User user)
        {
            InitializeComponent();
            drawChart();
        }

        private void drawChart()
        {
            DateTime max = DateTime.Now;
            chartStat.ChartAreas[0].AxisX.Maximum = max.ToOADate();
            
           // chartStat.Series["SeriesStat"].Points.AddXY(4.5, 45);
           // chartStat.Series["SeriesStat"].Points.AddXY(5.2, 68);
           // chartStat.Series["SeriesStat"].Points.AddXY(2.8, 13);
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
