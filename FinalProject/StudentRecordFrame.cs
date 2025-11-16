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
    public partial class StudentRecordFrame : Form
    {
        public StudentRecordFrame()
        {
            InitializeComponent();
            this.Size = new Size(1942, 1008);

        }

        private void btnBackToScan_Click(object sender, EventArgs e)
        {
            ScanScreen scan = new ScanScreen();
            scan.Show();
            this.Close();
        }

        private void btnViewScanHistory_Click(object sender, EventArgs e)
        {
           //ScanHistoryFrame scanHis = new ScanHistoryFrame();
           //scanHis.Show();
           //this.Close();
        }
    }
}
