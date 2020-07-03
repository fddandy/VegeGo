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
    public partial class MainWindow : Form
    {
        public MainWindow(string userData)
        {
            InitializeComponent();
            labelLogAs.Text = userData;
        }


        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
