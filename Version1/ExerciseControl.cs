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
    public partial class ExerciseControl : UserControl
    {
        private static ExerciseControl _instance;

        public static ExerciseControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExerciseControl();
                return _instance;
            }
        }

        public delegate void ExerciseEvent();
        public event ExerciseEvent submitButton_Click;
        public ExerciseControl()
        {
            InitializeComponent();
            buttonSubmit.Click += ButtonSubmit_Click;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            
            submitButton_Click?.Invoke();
        }
    }
}
