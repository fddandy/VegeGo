using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class DayControl : UserControl
    {
        WaterControl wc;
        public delegate string DayEvent();
        public event DayEvent DayWaterCombo;
        public event DayEvent DayWaterDay;
        public event DayEvent DayWaterNecc;
        public DayControl(WaterControl wc)
        {
            InitializeComponent();
            this.wc = wc;
            sidePanel.Height = buttonWater.Height;
            sidePanel.Top = buttonWater.Top;
           //waterControl.WaterNecc += WaterControl_WaterNecc;
           // waterControl.WaterDay += WaterControl_WaterDay;
           // waterControl.ComboBoxValueChanged += WaterControl_ComboBoxValueChanged;
           // wc.comboBoxWater
        }

        private string WaterControl_ComboBoxValueChanged()
        {
            return DayWaterCombo();
        }

        private string WaterControl_WaterDay()
        {
           return  DayWaterDay();
        }

        private string WaterControl_WaterNecc()
        {
           return  DayWaterNecc();
        }

        private void buttonWater_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonWater.Height;
            sidePanel.Top = buttonWater.Top;
            //waterControl.BringToFront();
        }

        private void buttonKcak_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonKcak.Height;
            sidePanel.Top = buttonKcak.Top;
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
    }
}
