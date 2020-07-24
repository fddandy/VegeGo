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
    public partial class KcalControl : UserControl
    {
        public delegate void KcalEvent();
        public event KcalEvent ShowChart;
        private static KcalControl _instance;
        public static KcalControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KcalControl();
                return _instance;
            }
        }


        public KcalControl()
        {
            InitializeComponent();
            buttonShowChart.Click += ButtonShowChart_Click;
        }

        private void ButtonShowChart_Click(object sender, EventArgs e)
        {
            ShowChart?.Invoke();
        }
    }
}
