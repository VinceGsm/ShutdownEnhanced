using System;
using System.Windows.Forms;

namespace ShutdownEnhanced
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            string input = inputTxt.Text;
            int timerInSec = 1800; // default 30mn

            if (!string.IsNullOrEmpty(input))
                timerInSec = int.Parse(input) * 60;

            System.Diagnostics.Process.Start("shutdown", $"/s /t {timerInSec}");         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");
        }
    }
}
