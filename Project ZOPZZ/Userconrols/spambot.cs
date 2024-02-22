using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    public partial class spambot : UserControl
    {
        public spambot()
        {
            InitializeComponent();
        }
        private void StopSpam()
        {
            SpamTimer.Stop();
            SpamStatus.Text = "Off";
            SpamBTN.Text = "Start";
        }

        private void SpamTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SpamTimer.Enabled) StopSpam();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SpamBTN_Click(object sender, EventArgs e)
        {
            if (SpamBTN.Text == "Start")
            {
                SpamTimer.Interval = milisec.Value;
                SpamStatus.Text = "On";
                SpamTimer.Start();
                SpamBTN.Text = "Stop";
            }
            else StopSpam();
        }

        private void milisec_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = $"Miliseconds: {milisec.Value}";
            if (SpamTimer.Enabled) StopSpam();
        }

        private void SpamTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(SpamTextBox.Text);
            SendKeys.Send("{ENTER}");
        }

        private void SpamStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
