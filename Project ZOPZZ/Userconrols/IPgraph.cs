using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.NetworkInformation;

namespace Project_ZOPZZ
{
    public partial class IPgraph : UserControl
    {
        public void Alert(string msg, alirt.enmType type)
        {
            alirt frm = new alirt();
            frm.showAlert(msg, type);
        }
        public IPgraph()
        {
            InitializeComponent();
        }

        private async void servertimer_TickAsync(object sender, EventArgs e)
        {

        }

        private async void clearservertimer_TickAsync(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_ClickAsync(object sender, EventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void guna2Button34_Click(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.lookupuser(UsernameTextBox.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.lookuproom(UsernameTextBox.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button21_Click(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.recroomload(UsernameTextBox.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.bio(UsernameTextBox.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button26_Click(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.showcase(UsernameTextBox.Text);
            outbox.Text = scanner;
        }
    }
}
