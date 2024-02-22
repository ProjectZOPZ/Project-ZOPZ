using KeyAuth;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Alert(string msg, alirt.enmType type)
        {
            alirt frm = new alirt();
            frm.showAlert(msg, type);
        }
        private void attacklogs()
        {

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
        private void ShowResponse(string type)
        {
            Console.WriteLine($"It took {api.responseTime} ms to {type}");
        }
        private void Blacklist()
        {

        }
        private async void server_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendAttackBTN_Click(object sender, EventArgs e)
        {
            string targetIP = host.Text;
            int startPort = int.Parse(StartPortTextBox.Text);
            int endPort = int.Parse(EndPortTextBox.Text);

            for (int port = startPort; port <= endPort; port++)
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    try
                    {
                        tcpClient.Connect(targetIP, port);
                        dataGridView1.Rows.Add($"Port {port} is open.");
                    }
                    catch (SocketException)
                    {
                        // Port is closed or unreachable
                        dataGridView1.Rows.Add($"Port {port} is closed.");
                    }
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void ICMPPingBTN_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
        public static void senddiswebhook(string URL, string json)
        {
            var wr = WebRequest.Create(URL);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
                sw.Write(json);
            wr.GetResponse();
        }
        private async Task UpdateMethods(string appid)
        {


        }
        private async void UserControl1_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
