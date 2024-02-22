using Fusion;
using KeyAuth;
using Project_ZOPZZ.Properties;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Input;

namespace Project_ZOPZZ
{
    public partial class login : Form
    {
        public static api KeyAuthApp = new api(
            name: "Project ZOPZ",
            ownerid: "PH2Z3ApDrO",
            secret: "7a56bfc43786bf4e638df141817fb388181d27f6b60367c44cef7f98206c27dd",
            version: "2.8.4"
        );
        private void ShowResponse(string type)
        {
            MessageBox.Show($"It took {api.responseTime} msg to {type}");
        }
        public void Alert(string msg, alirt.enmType type)
        {
            alirt frm = new alirt();
            frm.showAlert(msg, type);
        }
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
{
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Environment.Exit(0);
            }
            
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }       
            var settings = SettingsManager.Load();
            if (settings.RemeberMe)
            {
                Username.Text = settings.Username;
                Password.Text = settings.Password;
                Remebermecheck.Checked = true;
            }

            base.TopMost = settings.AppTopMost;

            if (settings.AutoLogin) LoginBTN_Click(null,null);
            SettingsModel settingsModel = SettingsManager.Load();
            SettingsModel settingsModel2 = settingsModel;
            int totalAttacksSent = settingsModel2.Concurrents;
            settingsModel2.Concurrents = totalAttacksSent = 0;
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
        private void ShowLoginBTN_Click(object sender, EventArgs e)
        {
            label2.Text = "| Login";
            Ani.Hide(RegistePanel);
        }

        private void ShowRegBTN_Click(object sender, EventArgs e)
        {
            label2.Text = "| Register";
            Ani.Show(RegistePanel);
        }

        private async void LoginBTN_Click(object sender, EventArgs e)
        {
            if (LoginBTN.Text != "Login") return;

            LoginBTN.Text = "Signing you in...";
            KeyAuthApp.login(Username.Text, Password.Text);
            if (KeyAuthApp.response.success)
            {
                SettingsModel settingsModel = SettingsManager.Load();
                SettingsModel settingsModel2 = settingsModel;
                int totalAttacksSent = settingsModel2.Concurrents;
                settingsModel2.Concurrents = totalAttacksSent = 0;
                this.Alert($"Welcome To Project ZOPZ", alirt.enmType.Success);
                var settings = SettingsManager.Load();
                settings.Username = Username.Text;
                settings.Password = Password.Text;
                settings.RemeberMe = Remebermecheck.Checked;
                settings.Save();
                await Tools.CheckForUpdate();
                mainform main = new mainform();
                main.Show();
                this.Hide();
            }
            else
            {
                LoginBTN.Text = "Login";
                this.Alert($"{KeyAuthApp.response.message}", alirt.enmType.Success);
            }
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            if (RegisterBTN.Text != "Register") return;

            RegisterBTN.Text = "Checking...";
            KeyAuthApp.register(user.Text, Passwd.Text, Token.Text);
            if (KeyAuthApp.response.success)
            {
                this.Alert($"{KeyAuthApp.response.message}", alirt.enmType.Success);
            }
            else
            {
                RegisterBTN.Text = "Register";
                this.Alert($"{KeyAuthApp.response.message}", alirt.enmType.Success);
            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RegisterBTN_Click_1(object sender, EventArgs e)
        {

        }

        private void ShowRegBTN_Click_1(object sender, EventArgs e)
        {
            Ani.Show(RegistePanel);
        }

        private void ShowLoginBTN_Click_1(object sender, EventArgs e)
        {
            Ani.Hide(RegistePanel);
        }

        private void RegistePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Remebermecheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
