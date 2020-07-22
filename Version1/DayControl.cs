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
        public DayControl()
        {
            InitializeComponent();
            sidePanel.Height = buttonWater.Height;
            sidePanel.Top = buttonWater.Top;

        }

        private void buttonWater_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonWater.Height;
            sidePanel.Top = buttonWater.Top;
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
