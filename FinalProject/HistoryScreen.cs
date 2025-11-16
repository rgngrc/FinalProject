using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class HistoryScreen : Form
    {
        public HistoryScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNavbar_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvRecentScans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            DashboardScreen dashboard = new DashboardScreen();
            dashboard.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }
    }
}
