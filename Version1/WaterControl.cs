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
    public partial class WaterControl : UserControl
    {
        private static WaterControl _instance;

        public static WaterControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WaterControl();
                return _instance;
            }
        }
        public delegate void WaterEvent();
        public event WaterEvent ComboBoxValueChanged;
     
        public WaterControl()
        {
            InitializeComponent();

            comboBoxWater.SelectedIndexChanged += ComboBoxWater_SelectedIndexChanged;
        }

        private void ComboBoxWater_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxValueChanged?.Invoke();
        }
    }
}
