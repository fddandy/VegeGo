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
            trackBar.Value = Convert.ToInt32(bmi1);
            colorResult(bmi1);
        }

        private void colorResult(double bmi)
        {
                if( bmi < 18.5)
                    {
                       labelCustomBMI.ForeColor = Color.Orange;
                       labelInform.ForeColor = Color.Orange;
                       labelInform.Text = "You are underweight. Gain some weight!";
                    }
                else if (bmi >= 18.5 && bmi <= 25)
                    {
                       labelCustomBMI.ForeColor = Color.Green;
                       labelInform.ForeColor = Color.Green;
                       labelInform.Text = "Your weight is fine!";
            }
                else if (bmi > 25.0)
                    {
                       labelCustomBMI.ForeColor = Color.Red;
                       labelInform.ForeColor = Color.Red;
                       labelInform.Text = "You are obese! Lose some weight. ";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        Point lastPoint;
        private void BMI_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void BMI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
