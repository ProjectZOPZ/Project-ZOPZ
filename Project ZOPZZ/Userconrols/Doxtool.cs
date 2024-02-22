using System;
using System.Net.Http;
using HtmlAgilityPack;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Web.Services.Description;

namespace Project_ZOPZZ
{
    public partial class Doxtool : UserControl
    {
        public Doxtool()
        {
            InitializeComponent();
            InitializeRealNameData();

        }
        private void InitializeRealNameData()
        {

        }
        private void Doxtool_Load(object sender, EventArgs e)
        {



        }

        private void SendAttackBTN_Click(object sender, EventArgs e)
        {
        }

        private void host_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {
        }

        private async void SendAttackBTN_Click_1(object sender, EventArgs e)
        {
            string resp = login.KeyAuthApp.webhook("A8qLWuzyEb", $"?first_name={UsernameTextBox.Text}&last_name={guna2TextBox1.Text}&state={guna2TextBox2.Text}");
            if (login.KeyAuthApp.response.success)
            {
                outbox.Text = resp;
            }
            else
            {
                outbox.Text = resp;
            }
        }
    }
}
