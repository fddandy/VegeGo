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
    public partial class PFCControl : UserControl
    {
        public delegate void PFCEvent();
        public event PFCEvent PCFButtonChanged;

        public delegate void DateEvent(DateTime date);
        public event DateEvent PFCdateChanged;

        private static PFCControl _instance;
        public static PFCControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PFCControl();
                    return _instance;
            }
        }

        public PFCControl()
        {
            InitializeComponent();
            labelFat.Click += LabelFat_Click;
            labelProtein.Click += LabelProtein_Click;
            labelCarbohydrate.Click += LabelCarbohydrate_Click;
            dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PFCdateChanged?.Invoke(dateTimePicker.Value.Date);
        }

        private void LabelCarbohydrate_Click(object sender, EventArgs e)
        {
            PCFButtonChanged?.Invoke();
        }

        private void LabelProtein_Click(object sender, EventArgs e)
        {
            PCFButtonChanged?.Invoke();
        }

        private void LabelFat_Click(object sender, EventArgs e)
        {
            PCFButtonChanged?.Invoke();
        }

    }
}
