using Fusion;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Project_ZOPZZ
{
    public partial class Tickets : UserControl
    {
        private static bool HasATicket = false;
        public Tickets()
        {
            InitializeComponent();
        }
        public static void sendWebHook(string URL, string msg, string username)
        {
            http.Post(URL, new NameValueCollection()
             {
               {
                   "username",
                  username
               },
              {
                 "content",
                   msg
              }
          });
        }
        private void SendNewTicketBTN_Click(object sender, EventArgs e)
        {

        }

        private void TicketBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void host_TextChanged(object sender, EventArgs e)
        {

        }

        private void method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string resp = login.KeyAuthApp.webhook("DTMKjQj1AF", "", "{\"content\": \"Context:" + " " + host.Text + " " + " Problem:" + " " + server.Text + " " + " Username:" + " " +  login.KeyAuthApp.user_data.username + "\",\"embeds\": null}", "application/json");
            if (login.KeyAuthApp.response.success)
            {
                richTextBox1.Text = "Ticket Sent.";
            }
            {
                richTextBox1.Text = resp;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
