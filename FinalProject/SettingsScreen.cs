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
    // Displays scanner configuration placeholders.
    public partial class SettingsScreen : Form
    {
        // Initializes the form components.
        public SettingsScreen()
        {
            InitializeComponent();
        }

        // To initialize control values when the form opens.
        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            // Sets the default scanning type option in the ComboBox to the first item.
            cmbDefaultType.SelectedIndex = 0;
            // Code to load saved user settings would go here.
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Handles click event to navigate back to the main Dashboard screen.
        private void btnBackToDash_Click(object sender, EventArgs e)
        {
            // Instantiate and show the DashboardScreen, then close the current form.
            DashboardScreen dashboardScreen = new DashboardScreen();
            dashboardScreen.Show();
            this.Close();
        }

        // Handles click event to log the user out and display the Login screen.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Instantiate and show the LoginScreen, then close the current form.
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }

        private void cmbDefaultType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}