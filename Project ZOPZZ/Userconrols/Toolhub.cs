using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Net.Mail;
using Newtonsoft.Json;
using System.Text;

namespace Project_ZOPZZ
{
    public partial class Toolhub : UserControl
    {
        private readonly HttpClient httpClient;

        private readonly InstagramSearchTool instaSearchTool;
        public Toolhub()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            // Create a button to start the ping
            Button pingButton = new Button();
            pingButton.Text = "Ping";
            pingButton.Click += guna2Button20_Click;
            this.Controls.Add(pingButton);
        }
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";
        public async Task GetInfo(string username)
        {
            try
            {
                // Create an HttpClient instance.
                using (HttpClient httpClient = new HttpClient())
                {
                    // Set the User-Agent header to mimic a web browser request.
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                    // Construct the URL for the Instagram profile page.
                    string url = $"https://www.instagram.com/{username}/";

                    // Send an HTTP GET request to fetch the profile page HTML content.
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string htmlContent = await response.Content.ReadAsStringAsync();

                        // Implement HTML parsing logic to extract user information from 'htmlContent'.
                        // You can use a library like HtmlAgilityPack or other HTML parsing methods.

                        // Example: Extracting the username from the HTML content.

                        // Set the properties of the InstagramSearchTool class with the extracted data.
                        // Set other properties like Name, Id, ProfilePicHd, etc.
                    }
                    else
                    {
                        // Handle the case where the HTTP request fails.
                        Console.WriteLine("Error: Failed to fetch Instagram profile page.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process.
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void DownloadPictures(string mediaUrl, string path, string filename)
        {
            // Implement logic to download pictures and save them to the specified path with the given filename.
        }
        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTER;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }
        private async void guna2Button1_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.GeoLocateAsync(host.Text);
            outbox.Text = scanner;
        }
        private void ScanPorts(string target)
        {
            string nmapPath = @"C:\Program Files\Nmap\nmap.exe"; // Update with your Nmap path

            if (!File.Exists(nmapPath))
            {
                MessageBox.Show("Nmap executable not found. Please provide the correct path.");
                return;
            }

            // Define the Nmap command with more aggressive scan options
            string nmapCommand = $"-p- -T4 -A -vv {target}";
            // -p- scans all ports, -T4 sets the scan speed to aggressive, -A enables OS and version detection, -vv increases verbosity

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = nmapPath,
                Arguments = nmapCommand,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true
            };

            process.OutputDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Append the scan output to the result TextBox or DataGridView
                    this.Invoke((MethodInvoker)delegate
                    {
                        outbox.AppendText(e.Data + Environment.NewLine);
                    });
                }
            };

            process.Exited += (s, e) =>
            {
                // Handle the scan completion event, if needed
            };

            process.Start();
            process.BeginOutputReadLine();
        }

        private async void guna2Button2_ClickAsync(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UserControl1());
        }

        private async void guna2Button7_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Features.ProxyDetector(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button5_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.DnsLookup(host.Text);
            outbox.Text = scanner;
        }
        private async void guna2Button6_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.SubnetScan(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button4_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.whois(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button3_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.ZoneLookup(host.Text);
            outbox.Text = scanner;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            outbox.Text = "Checking...";
            string scanner = Features.CustomPortScan(host.Text, port.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button9_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.num(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button10_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Checking...";
            string scanner = await Tools.sd(host.Text);
            outbox.Text = scanner;
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            string url = host.Text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            outbox.Text = sr.ReadToEnd();
            sr.Close();
            

        }

        private void outbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrackBTN_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void LeghtLBL_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            outbox.Text = "Waiting for imput...";
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            try { Clipboard.SetText(outbox.Text); } catch { }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new spambot());
        }

        private async void guna2Button16_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.GeoLocateAsync(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button17_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.sdf(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button15_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.sdsds(host.Text);
            outbox.Text = scanner;
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button31_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button19_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = Tools.PSNResolver(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button20_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.iptopsn(host.Text);
            outbox.Text = scanner;
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            var accounts = new WebClient().DownloadString("https://pastebin.com/raw/6fQtUeBv").Split('\n');
            outbox.Text = accounts[new Random().Next(0, accounts.Length)];
        }

        private async void guna2Button26_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.Pagelinks(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button28_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.IPtoSkype(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button30_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.EmailtoSkype(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button29_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.EmailtoSkype(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button27_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.WebsiteHeaders(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button25_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.Disposableemailchecker(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button22_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.ReverseDNSLookup(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button23_ClickAsync(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.netblocks(host.Text);
            outbox.Text = scanner;
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new IPgraph());
        }

        private void guna2Button32_Click(object sender, EventArgs e)
        {
            var accounts = new WebClient().DownloadString("https://pastebin.com/raw/6fQtUeBv").Split('\n');
            outbox.Text = accounts[new Random().Next(0, accounts.Length)];
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {

        }

        private void Toolhub_Load(object sender, EventArgs e)
        {
            panel6.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button34_Click(object sender, EventArgs e)
        {
            panel6.Show();
        }

        private void guna2Button35_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Doxtool());
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button36_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button36_Click_1(object sender, EventArgs e)
        {
            var accounts = new WebClient().DownloadString("https://pastebin.com/raw/1hZxBSgm").Split('\n');
            outbox.Text = accounts[new Random().Next(0, accounts.Length)];
        }

        private async void guna2Button37_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            string target = host.Text.Trim();

            if (string.IsNullOrEmpty(target))
            {
                MessageBox.Show("Please enter a target IP address or hostname.");
                return;
            }

            ScanPorts(target);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click_1(object sender, EventArgs e)
        {
            panel6.Hide();
        }

        private void host_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<string, List<string>> UserDomainData = new Dictionary<string, List<string>>
        {
            { "example_user1", new List<string> { "example.com", "example.org" } },
            { "example_user2", new List<string> { "test.com", "test.org" } },
            // Add more username-domain data as needed
        };
        private async void guna2Button5_Click(object sender, EventArgs e)
        {
            string resp = login.KeyAuthApp.webhook("BxsLr7n54d", $"{host.Text}");
            if (login.KeyAuthApp.response.success)
            {
                outbox.Text = resp;
            }
            else
            {
                outbox.Text = resp;
            }
        }
        private async Task SearchPlatform(string platform, string apiUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    // Process the result and update your DataGridView with the data.
                    // You may need to parse JSON responses or other formats depending on the API.
                }
                else
                {
                    outbox.Text = $"{host.Text} not found on {platform}.";
                }
            }
        }
        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            string username = host.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            await SearchPlatform("GitHub", $"https://api.github.com/users/{username}");
            await SearchPlatform("Twitter", $"https://api.twitter.com/users/{username}"); // Example URL
            await SearchPlatform("Instagram", $"https://api.instagram.com/users/{username}"); // Example URL
        }
        private void guna2Button16_Click(object sender, EventArgs e)
        {
            label2.Text = "Tools (Page 1)";
            guna2Panel5.Show();
            guna2Button16.Hide();
            guna2Button17.Show();
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            label2.Text = "Tools (Page 2)";
            guna2Panel5.Hide();
            guna2Button17.Hide();
            guna2Button16.Show();
        }

        private async void guna2Button19_Click(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.ReverseDNSLookup(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button31_Click_1(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.DnsLookup(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button23_Click(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.IPtoSkype(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button32_Click_1(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.Skyperesolver(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button30_Click(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.EmailtoSkype(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button22_Click(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.WebsiteHeaders(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button29_Click(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.iptopsn(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button27_Click(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.ZoneLookup(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button33_Click_1(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.NmapScan(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button24_Click_1(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.IPtoSkype(host.Text);
            outbox.Text = scanner;
        }

        private async void guna2Button25_Click(object sender, EventArgs e)
        {
            outbox.Text = "Scanning, please wait...";
            string scanner = await Tools.Disposableemailchecker(host.Text);
            outbox.Text = scanner;
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            string targetHost = host.Text; // Replace with your target hostname or IP address

            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send(targetHost);

                    if (reply.Status == IPStatus.Success)
                    {
                        outbox.Text = $"Ping to {targetHost} succeeded. Reply from {reply.Address}: " + $"Roundtrip time = {reply.RoundtripTime}ms";
                    }
                    else
                    {

                        outbox.Text = $"Ping to {targetHost} failed. Status: {reply.Status}";
                    }
                }
                catch (Exception ex)
                {
                    outbox.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void DisplayPingResult(string result)
        {
            // Invoke the RichTextBox update on the UI thread
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() => DisplayPingResult(result)));
            }
            else
            {
                // Append the ping result to the RichTextBox
                outbox.Text = result + Environment.NewLine;
            }
        }
        private void guna2Button18_Click_1(object sender, EventArgs e)
        {
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

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
