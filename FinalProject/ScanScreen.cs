using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace FinalProject
{
    public partial class ScanScreen : Form
    {

        FilterInfoCollection webcams;
        VideoCaptureDevice cam;

        public ScanScreen()
        {
            InitializeComponent();
        }

        private void StopCamera()
        {
            if (cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam.WaitForStop();
                cam = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcams = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (webcams.Count > 0)
            {
                cam = new VideoCaptureDevice(webcams[0].MonikerString);
                cam.NewFrame += Cam_NewFrame;
                cam.Start();
            }
            else
            {
                MessageBox.Show("No camera detected.");
            }

            comboBox1.Items.Add("Barcode");
            comboBox1.Items.Add("QR Code");
            comboBox1.Items.Add("RFID");

            comboBox1.SelectedIndex = 0;
        }


        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            StopCamera(); 
            StudentRecordFrame studentRecord = new StudentRecordFrame();
            studentRecord.Show();
            this.Close();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            StopCamera();
            DashboardScreen dashboard = new DashboardScreen();
            dashboard.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StopCamera();
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }

        private void btnScanCode_Click(object sender, EventArgs e)
        {
            string scanType = comboBox1.SelectedItem.ToString();

            labelScanStatus.Text = $"Successfully scanned {scanType}!";

            labelStudentName.Text = "Jasper Cedrick Nolo Asi";
            labelStudentNumber.Text = "2300374";
            labelCourse.Text = "Bachelor of Science in information Technology";
            labelSection.Text = "3 IT-A";

            try
            {
                // Loading image from embedded resources
                pictureBoxStudent.Image = Properties.Resources.idpic;
            }
            catch
            {
                pictureBoxStudent.Image = null;
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