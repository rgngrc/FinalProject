using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DashboardScreen : Form
    {
        public DashboardScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblRecentScans_Click(object sender, EventArgs e)
        {

        }

        private void panelRecentScans_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRecentScans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTodayNum_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanScreen scan = new ScanScreen();
            scan.Show();
            this.Hide();
        }

        private void btnScanHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
