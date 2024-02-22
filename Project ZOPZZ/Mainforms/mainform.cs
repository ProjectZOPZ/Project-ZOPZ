using Fusion;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    public partial class mainform : Form
    {
        bool sideBar_Expand = true;

        public mainform()
        {
            InitializeComponent();
            pnlNavIndicator.Height = iconButton2.Height;
            pnlNavIndicator.Top = iconButton2.Top;
            pnlNavIndicator.Left = iconButton2.Left;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        private void LoadSettings()
        {
            var settings = SettingsManager.Load();

            base.TopMost = settings.AppTopMost;

            if (settings.ShowDiscordRPC)
            {

            }
            else
            {

            }
        }
        private void LoadControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Visible = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            Trans.Show(panel1);
            LoadSettings();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            this.LoadPfp();
            Timer_Sidebar_Menu.Start();
            userdetails.Text = $"{login.KeyAuthApp.user_data.username}";
            Home uc = new Home();
            LoadControl(uc);
        }

        private void ShowHomeBTN_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
        }

        private void ShowMenuBTN_Click_1(object sender, EventArgs e)
        {

        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TitleBarPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void ShowTicketBTN_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar.Width -= 100000;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sideBar_Expand = true;
                    Timer_Sidebar_Menu.Stop();
                }
            }
        }
        public void LoadPfp()
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SettingsModel settingsModel = SettingsManager.Load();
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                openFileDialog.ShowDialog();
                string fileName = openFileDialog.FileName;
                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    settingsModel.PicPath = fileName;
                    settingsModel.Save();

                }
            }
            catch
            {
            }
        }
        private void guna2Button7_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click_4(object sender, EventArgs e)
        {
            LoadControl(new Tickets());
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.None;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = iconButton2.Height;
            pnlNavIndicator.Top = iconButton2.Top;
            pnlNavIndicator.Left = iconButton2.Left;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Home());
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = iconButton3.Height;
            pnlNavIndicator.Top = iconButton3.Top;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Attackhub());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = iconButton1.Height;
            pnlNavIndicator.Top = iconButton1.Top;
            pnlNavIndicator.Left = iconButton1.Left;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Toolhub()); 
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = iconButton4.Height;
            pnlNavIndicator.Top = iconButton4.Top;
            pnlNavIndicator.Left = iconButton4.Left;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Livechat());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = iconButton5.Height;
            pnlNavIndicator.Top = iconButton5.Top;
            pnlNavIndicator.Left = iconButton5.Left;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Logger());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = iconButton6.Height;
            pnlNavIndicator.Top = iconButton6.Top;
            pnlNavIndicator.Left = iconButton6.Left;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Tickets());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = iconButton7.Height;
            pnlNavIndicator.Top = iconButton7.Top;
            pnlNavIndicator.Left = iconButton7.Left;
            panel1.Controls.Clear();
            panel1.Controls.Add(new settings());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userdetails_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 

            }
        }

        private void ShowMenuBTN_Click(object sender, EventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenDiscordBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void MinmizeBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
