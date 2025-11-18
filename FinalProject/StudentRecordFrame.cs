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
    // Displays student info layout.
    public partial class StudentRecordFrame : Form
    {
        // Initializes components and sets a fixed form size.
        public StudentRecordFrame()
        {
            InitializeComponent();
            this.Size = new Size(1942, 1008);
        }

        // Handles click event to navigate back to the main scanning interface.
        private void btnBackToScan_Click(object sender, EventArgs e)
        {
            ScanScreen scan = new ScanScreen();
            scan.Show();
            this.Close();
        }

        // Handles click event to navigate to the screen showing historical scan records.
        private void btnViewScanHistory_Click(object sender, EventArgs e)
        {
            HistoryScreen history = new HistoryScreen();
            history.Show();
            this.Close();
        }

        // Handles click event to log the user out and return to the login screen.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }
    }
}