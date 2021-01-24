using System;
using System.Windows.Forms;

namespace ShutdownEnhanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            lblShutdown.Text = "Ciao !";
        }
    }
}
