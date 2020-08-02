using System;
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
            
            dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PFCdateChanged?.Invoke(dateTimePicker.Value.Date);
        }

    }
}
