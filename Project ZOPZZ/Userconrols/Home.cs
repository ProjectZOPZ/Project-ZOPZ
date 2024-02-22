using Fusion;
using Newtonsoft.Json;
using Project_ZOPZZ.Models;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        public static async Task<string> FetchPastebinRawData(string pastebinLink)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Make an HTTP GET request to the Pastebin link
                    HttpResponseMessage response = await client.GetAsync(pastebinLink);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the raw data as a string
                        string rawData = await response.Content.ReadAsStringAsync();
                        return rawData;
                    }
                    else
                    {
                        // Handle error if the request is not successful
                        return "Error: Unable to fetch data from Pastebin.";
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during the request
                    return "Error: " + ex.Message;
                }
            }
        }
        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Days " + difference.Hours + " Hours Left");
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

        private async void Home_LoadAsync(object sender, EventArgs e)
        {
            login.KeyAuthApp.check();
            login.KeyAuthApp.fetchStats();
            planname.Text = login.KeyAuthApp.user_data.subscriptions[0].subscription;
            string resp = login.KeyAuthApp.var("tools");
            totaltools.Text = resp;
            string online = login.KeyAuthApp.app_data.numOnlineUsers;
            label3.Text = online;
            totaluserslabel.Text = login.KeyAuthApp.app_data.numUsers;
            string version = login.KeyAuthApp.var("Verson");
            AppVersion.Text = version;
            dataGridView1.Rows.Add("Hello everyone welcome to Project ZOPZ V3 DDOS Panel");
            dataGridView1.Rows.Add("TOS = No Dstats No Spamming Hosts No Hitting Govs an no leaking Logins = Perm Banned User Enjoy The Panel");
            LastUpdateLabel.Text = $"Logged into Project ZOPZ At: {DateTime.Now} Username: {login.KeyAuthApp.user_data.username}";
            userdetails.Text = login.KeyAuthApp.user_data.username;
            exdate.Text = "" + UnixTimeToDateTime(long.Parse(login.KeyAuthApp.user_data.subscriptions[0].expiry));
            var json = await Data.Download($"http://ip-api.com/json/?fields=66846719");
            var result = JsonConvert.DeserializeObject<IpLocationModule>(json);
            SettingsModel settingsModel = SettingsManager.Load();
            SettingsModel settingsModel2 = settingsModel;
            Attacks.Text = settingsModel.TotalAttacks.ToString();
            settingsModel.Concurrents.ToString();
            apcountlabel.Text = login.KeyAuthApp.var("apis");
            if (result.Status == "fail")
            {
                Country.Text = "N/A";
                Protected.Text = "N/A";
                Region.Text = "N/A";
            }
            else
            {
                Country.Text = result.CountryCode;
                Protected.Text = result.Proxy.ToString();
                Region.Text = result.Region;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AnnouncementBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnnouncementBox_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totaltools_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exdate_Click(object sender, EventArgs e)
        {

        }

        private void AnnouncementBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void totaluserslabel_Click(object sender, EventArgs e)
        {

        }

        private void AppVersion_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            LastUpdateLabel.Text = "Cleared All Logs";
        }

        private void AnnouncementBox_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void LastUpdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void userdetails_Click(object sender, EventArgs e)
        {

        }

        private void apcountlabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TargetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

    internal class YourDataClass
    {

        public string Updates { get; internal set; }
    }
}
