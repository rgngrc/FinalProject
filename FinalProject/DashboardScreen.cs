using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    // Displays scan overview, user info, and simulated connection status.
    public partial class DashboardScreen : Form
    {
        // Initializes the form components.
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

        // To set initial states for dashboard controls.
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Sets the selected item in the dropdown to the first index.
            cmbType.SelectedIndex = 0;
            // Code to load statistics (e.g., today's scan count) and recent scan data would go here.
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

        // Handles click event for navigating to the Scan Screen.
        private void btnScan_Click(object sender, EventArgs e)
        {
            // Opens the ScanScreen form.
            ScanScreen scan = new ScanScreen();
            scan.Show();
            // Hides the current Dashboard form.
            this.Hide();
        }

        // Handles click event for navigating to the Scan History screen.
        private void btnScanHistory_Click(object sender, EventArgs e)
        {
            // Opens the HistoryScreen form.
            HistoryScreen history = new HistoryScreen();
            history.Show();
            // Hides the current Dashboard form.
            this.Hide();
        }

        // Handles click event for navigating to the Settings screen.
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Opens the SettingsScreen form.
            SettingsScreen settings = new SettingsScreen();
            settings.Show();
            // Hides the current Dashboard form.
            this.Hide();
        }

        // Handles click event for logging out.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Opens the LoginScreen form.
            LoginScreen login = new LoginScreen();
            login.Show();
            // Closes the current Dashboard form.
            this.Close();
        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}