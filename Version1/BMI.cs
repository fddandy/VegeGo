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
    public partial class BMI : Form
    {
        public BMI(HealthCard hc)
        {
            InitializeComponent();
            double heightM = hc.Height / 100.0;
            
            double bmi1 = hc.Weight / heightM / heightM;
            labelCustomBMI.Text = bmi1.ToString();
            //MessageBox.Show(bmi1.ToString());
            trackBar.Value = Convert.ToInt32(bmi1);
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
