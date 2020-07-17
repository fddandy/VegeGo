using MySql.Data.MySqlClient;
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
        User user;
        HealthCard hc = new HealthCard();
        public MainWindow(User user)
        {
            InitializeComponent();
            labelLogAs.Text = user.Name +" "+ user.SurName;
            this.user = user;
            loadHealthCard();
        }

        private void loadHealthCard()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand com = new MySqlCommand("select `id`, `birth_date`,`height`, `weight`, `activ_level` from `health_card` where id_person=@id", db.getConnection());
            com.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                hc.Id = reader.GetInt32("id");
                hc.BirthDate = reader.GetDateTime("birth_date");
                hc.Height = reader.GetInt32("height");
                hc.Weight = reader.GetInt32("weight");
                hc.ActLevel = reader.GetString("activ_level");
            }
            db.closeConnection();
            labelH.Text = hc.Height.ToString();
            labelW.Text = hc.Weight.ToString();
            labelBD.Text = hc.BirthDate.ToString();
            labelAL.Text = hc.ActLevel.ToString();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LbCard_MouseClick(object sender, MouseEventArgs e)
        {
            panelMain.Visible = true;
        }

        private void buttonEditHC_Click(object sender, EventArgs e)
        {
            HealthCardRegister healthCard = new HealthCardRegister(user);
            healthCard.ShowDialog();
        }
    }
}
