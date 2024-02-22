using System;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using DiscordRPC;
using System.IO;
using Fusion;
using System.Web.UI.WebControls;

namespace Project_ZOPZZ
{
    public partial class settings : UserControl
    {
        public void Alert(string msg, alirt.enmType type)
        {
            alirt frm = new alirt();
            frm.showAlert(msg, type);
        }
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            login.KeyAuthApp.fetchStats();
            string version = login.KeyAuthApp.var("Verson");
            subscriptionDaysLabel.Text = version;
            var onlineUsers = login.KeyAuthApp.fetchOnline();
            if (onlineUsers != null)
            {
                foreach (var user in onlineUsers)
                {
                    dataGridView1.Rows.Add(user.credential);
                }
            }
            string appvar = login.KeyAuthApp.getvar("cons");
            if (!login.KeyAuthApp.response.success)
            {
                label3.Text = appvar;
            }
            else
                label3.Text = appvar;
            string appvars = login.KeyAuthApp.getvar("Attacktime");
            if (!login.KeyAuthApp.response.success)
            {
                boottime.Text = appvars;
            }
            else
                boottime.Text = appvars;
            label7.Text = login.KeyAuthApp.user_data.username;
            lev.Text = login.KeyAuthApp.user_data.subscriptions[0].subscription;
            hwidtb.Text = login.KeyAuthApp.user_data.hwid;
            lastLogin.Text = "1.1.1.1";
            Regday.Text = "" + UnixTimeToDateTime(long.Parse(login.KeyAuthApp.user_data.createdate));
            var settings = SettingsManager.Load();
            DiscordCheck.Checked = settings.ShowDiscordRPC;
            apptopmost.Checked = settings.AppTopMost;
            guna2ToggleSwitch2.Checked = settings.AutoLogin;

        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }
        private void DiscordCheck_CheckedChangedAsync(object sender, EventArgs e)
        {

            var settings = SettingsManager.Load();
            settings.ShowDiscordRPC = DiscordCheck.Checked;
            settings.Save();
        }

        private void apptopmost_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.AppTopMost = apptopmost.Checked;
            settings.Save();
        }

        private void YoutubeBTN_ClickAsync(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/projectzopz");
        }

        private void DiscordLinkBTn_ClickAsync(object sender, EventArgs e)
        {
            Process.Start("https://t.me/+QC0GpVEXw2c5OTgx");
        }

        private void WebsiteLinkBTn_ClickAsync(object sender, EventArgs e)
        {
            Process.Start("https://doxbin.com/user/ZOPZ/pastes");
        }

        private void InstagramlibkBTN_ClickAsync(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/fireoppzk");
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void lev_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.ShowDiscordRPC = DiscordCheck.Checked;
            settings.Save();
            if (settings.ShowDiscordRPC)
            {
                if (Globals.RPCClient.IsInitialized)
                {
                    Globals.RPCClient.SetPresence(Globals.RichPresence);
                }
                else
                {
                    Globals.RPCClient.Initialize();
                    Globals.RPCClient.SetPresence(Globals.RichPresence);
                }
            }
            else
            {
                if (Globals.RPCClient.IsInitialized)
                {
                    Globals.RPCClient.ClearPresence();
                }
                else
                {
                    Globals.RPCClient.Initialize();
                    Globals.RPCClient.ClearPresence();
                }
            }
        }

        private void apptopmost_CheckedChanged_1(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            _ = settings.AppTopMost;
            settings.AppTopMost = apptopmost.Checked;
            settings.Save();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boottime_Click(object sender, EventArgs e)
        {

        }

        private void hwidtb_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ip_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lastLogin_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customerPanelLink_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        private void apptopmost_CheckedChanged_2(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.AppTopMost = apptopmost.Checked;
            settings.Save();
        }

        private void DiscordCheck_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.ShowDiscordRPC = DiscordCheck.Checked;
            settings.Save();
            if (settings.ShowDiscordRPC)
            {
                if (Globals.RPCClient.IsInitialized)
                {
                    Globals.RPCClient.SetPresence(Globals.RichPresence);
                }
                else
                {
                    Globals.RPCClient.Initialize();
                    Globals.RPCClient.SetPresence(Globals.RichPresence);
                }
            }
            else
            {
                if (Globals.RPCClient.IsInitialized)
                {
                    Globals.RPCClient.ClearPresence();
                }
                else
                {
                    Globals.RPCClient.Initialize();
                    Globals.RPCClient.ClearPresence();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void subscriptionDaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private async void SendAttackBTN_Click(object sender, EventArgs e)
        {

        }

        private void host_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            string filePath = "enemy_logs.json";

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    this.Alert("Logs Have Been Cleared", alirt.enmType.Success);
                }
                else
                {
                    this.Alert("Logs Failed To Clear", alirt.enmType.Success);
                }
            }
            catch (Exception ex)
            {
                this.Alert($"An error occurred: {ex.Message}", alirt.enmType.Success);
            }
        }

        private void customerPanelLink_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.AutoLogin = guna2ToggleSwitch2.Checked;
            settings.Save();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}