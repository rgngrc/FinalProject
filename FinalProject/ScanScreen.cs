using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;          // Required for video capture functionality.
using AForge.Video.DirectShow; // Required to enumerate and select video devices.

namespace FinalProject
{
    // Simulates scanning for Barcode, QR, and RFID (mock input).
    public partial class ScanScreen : Form
    {

        // Collection to store information about all available webcams.
        FilterInfoCollection webcams;
        // Object representing the active video capture device (webcam).
        VideoCaptureDevice cam;

        // Initializes the form components.
        public ScanScreen()
        {
            InitializeComponent();
        }

        // Method to safely stop the running webcam feed.
        private void StopCamera()
        {
            if (cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam.WaitForStop();
                cam = null;
            }
        }

        // Initializes webcam detection and starts the video feed.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Detect all video input devices (webcams).
            webcams = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // If at least one camera is found, initialize and start the feed.
            if (webcams.Count > 0)
            {
                cam = new VideoCaptureDevice(webcams[0].MonikerString);
                cam.NewFrame += Cam_NewFrame; 
                cam.Start();
            }
            // Display an error if no camera is detected.
            else
            {
                MessageBox.Show("No camera detected.");
            }

            // Populate the ComboBox with the available scanning types.
            comboBox1.Items.Add("Barcode");
            comboBox1.Items.Add("QR Code");
            comboBox1.Items.Add("RFID");

            // Set the default scan type to the first item (Barcode).
            comboBox1.SelectedIndex = 0;
        }


        //  Called every time the camera captures a new frame.
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Display the current frame in the PictureBox control.
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        // Handles the click event for navigating to the Student Record screen.
        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            StopCamera(); // Stop the camera before navigating away. 
            StudentRecordFrame studentRecord = new StudentRecordFrame();
            studentRecord.Show();
            this.Close();
        }

        // Handles the click event for navigating back to the main Dashboard screen.
        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            StopCamera(); // Stop the camera before navigating away. 
            DashboardScreen dashboard = new DashboardScreen();
            dashboard.Show();
            this.Close();
        }

        // Handles the click event for logging out and returning to the Login screen.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            StopCamera(); // Stop the camera before logging out.
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }

        // Handles the click event to initiate the code scanning and data display process.
        private void btnScanCode_Click(object sender, EventArgs e)
        {
            // Get the selected scan type (Barcode, QR Code, or RFID).
            string scanType = comboBox1.SelectedItem.ToString();

            // Update status label to show successful scan.
            labelScanStatus.Text = $"Successfully scanned {scanType}!";

            // Manually populate student details (simulating data retrieval after a scan).
            labelStudentName.Text = "Jasper Cedrick Nolo Asi";
            labelStudentNumber.Text = "2300374";
            labelCourse.Text = "Bachelor of Science in information Technology";
            labelSection.Text = "3 IT-A";

            // Attempt to load the student's ID picture from resources.
            try
            {
                pictureBoxStudent.Image = Properties.Resources.idpic;
            }
            catch
            {
                pictureBoxStudent.Image = null; // Clear image on failure.
            }
        }

        private void labelStudentNumber_Click(object sender, EventArgs e)
        {
        }

        private void labelStudentName_Click(object sender, EventArgs e)
        {
        }

        private void labelScanStatus_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}