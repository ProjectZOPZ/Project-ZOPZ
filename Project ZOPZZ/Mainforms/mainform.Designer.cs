using System.Security.Policy;

namespace Project_ZOPZZ
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.Ani = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SideBar = new Guna.UI.WinForms.GunaPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.userdetails = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlNavIndicator = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DotsPanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GunaTIP = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.Trans = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Timer_Sidebar_Menu = new System.Windows.Forms.Timer(this.components);
            this.DragControl_Form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SideBar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TitleBarPanel.SuspendLayout();
            this.DotsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckTimer
            // 
            this.CheckTimer.Interval = 3600000;
            // 
            // Ani
            // 
            this.Ani.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.Ani.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Ani.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.Ani.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(65, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 462);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Black;
            this.SideBar.Controls.Add(this.guna2Panel1);
            this.SideBar.Controls.Add(this.pnlNavIndicator);
            this.SideBar.Controls.Add(this.iconButton7);
            this.SideBar.Controls.Add(this.iconButton6);
            this.SideBar.Controls.Add(this.iconButton5);
            this.SideBar.Controls.Add(this.iconButton4);
            this.SideBar.Controls.Add(this.iconButton2);
            this.SideBar.Controls.Add(this.iconButton1);
            this.SideBar.Controls.Add(this.iconButton3);
            this.Ani.SetDecoration(this.SideBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.SideBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 50);
            this.SideBar.MaximumSize = new System.Drawing.Size(217, 494);
            this.SideBar.MinimumSize = new System.Drawing.Size(55, 494);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(217, 494);
            this.SideBar.TabIndex = 9;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Panel1.BorderRadius = 1;
            this.guna2Panel1.Controls.Add(this.userdetails);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.label14);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Ani.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(217, 59);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint_1);
            // 
            // userdetails
            // 
            this.Ani.SetDecoration(this.userdetails, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.userdetails, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userdetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.userdetails.ForeColor = System.Drawing.Color.White;
            this.userdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userdetails.Location = new System.Drawing.Point(66, 29);
            this.userdetails.Name = "userdetails";
            this.userdetails.Size = new System.Drawing.Size(137, 19);
            this.userdetails.TabIndex = 11;
            this.userdetails.Text = "N/A";
            this.userdetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userdetails.Click += new System.EventHandler(this.userdetails_Click);
            // 
            // pictureBox2
            // 
            this.Trans.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Project_ZOPZZ.Properties.Resources.male_user_48px;
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.Ani.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(65, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Username";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNavIndicator
            // 
            this.pnlNavIndicator.BackColor = System.Drawing.Color.White;
            this.Ani.SetDecoration(this.pnlNavIndicator, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.pnlNavIndicator, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlNavIndicator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlNavIndicator.Location = new System.Drawing.Point(0, 451);
            this.pnlNavIndicator.Name = "pnlNavIndicator";
            this.pnlNavIndicator.Size = new System.Drawing.Size(2, 100);
            this.pnlNavIndicator.TabIndex = 8;
            // 
            // iconButton7
            // 
            this.Ani.SetDecoration(this.iconButton7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.iconButton7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.iconButton7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.iconButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 28;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(4, 393);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton7.Size = new System.Drawing.Size(211, 55);
            this.iconButton7.TabIndex = 6;
            this.iconButton7.Text = "Settings";
            this.guna2HtmlToolTip1.SetToolTip(this.iconButton7, "Settings");
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton6
            // 
            this.Ani.SetDecoration(this.iconButton6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.iconButton6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.iconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 28;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(4, 338);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton6.Size = new System.Drawing.Size(211, 55);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.Text = "Support";
            this.guna2HtmlToolTip1.SetToolTip(this.iconButton6, "Support");
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.Ani.SetDecoration(this.iconButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.iconButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 28;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(4, 283);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton5.Size = new System.Drawing.Size(211, 55);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Text = "Enemy Logger";
            this.guna2HtmlToolTip1.SetToolTip(this.iconButton5, "Enemy Logger");
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.Ani.SetDecoration(this.iconButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.iconButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(4, 229);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton4.Size = new System.Drawing.Size(211, 55);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Live Chat";
            this.guna2HtmlToolTip1.SetToolTip(this.iconButton4, "Live Chat");
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton2
            // 
            this.Ani.SetDecoration(this.iconButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.iconButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(4, 64);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton2.Size = new System.Drawing.Size(211, 55);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Dashboard";
            this.guna2HtmlToolTip1.SetToolTip(this.iconButton2, "Dashboard");
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.Ani.SetDecoration(this.iconButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.iconButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(4, 174);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Size = new System.Drawing.Size(211, 55);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Tool Hub";
            this.guna2HtmlToolTip1.SetToolTip(this.iconButton1, "Tool Hub");
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton3
            // 
            this.Ani.SetDecoration(this.iconButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.iconButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WifiStrong;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 28;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(4, 119);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton3.Size = new System.Drawing.Size(211, 55);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Attack Hub";
            this.guna2HtmlToolTip1.SetToolTip(this.iconButton3, "Attack Hub");
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.Ani.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ZOPZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.Black;
            this.TitleBarPanel.Controls.Add(this.DotsPanel);
            this.TitleBarPanel.Controls.Add(this.label1);
            this.Ani.SetDecoration(this.TitleBarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.TitleBarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(970, 50);
            this.TitleBarPanel.TabIndex = 8;
            this.TitleBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBarPanel_Paint);
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.TitleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseMove);
            // 
            // DotsPanel
            // 
            this.DotsPanel.BackColor = System.Drawing.Color.Black;
            this.DotsPanel.Controls.Add(this.guna2ControlBox3);
            this.DotsPanel.Controls.Add(this.guna2ControlBox2);
            this.Ani.SetDecoration(this.DotsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.DotsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DotsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DotsPanel.Location = new System.Drawing.Point(877, 0);
            this.DotsPanel.Name = "DotsPanel";
            this.DotsPanel.Size = new System.Drawing.Size(93, 50);
            this.DotsPanel.TabIndex = 42;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Ani.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(3, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 50);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.Ani.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(48, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 50);
            this.guna2ControlBox2.TabIndex = 3;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // GunaTIP
            // 
            this.GunaTIP.AllowLinksHandling = true;
            this.GunaTIP.AutomaticDelay = 300;
            this.GunaTIP.BorderColor = System.Drawing.Color.Black;
            this.GunaTIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GunaTIP.ForeColor = System.Drawing.Color.Black;
            this.GunaTIP.MaximumSize = new System.Drawing.Size(0, 0);
            this.GunaTIP.TitleForeColor = System.Drawing.Color.White;
            // 
            // Trans
            // 
            this.Trans.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Trans.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.Trans.DefaultAnimation = animation2;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.Black;
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.Black;
            this.guna2HtmlToolTip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // Timer_Sidebar_Menu
            // 
            this.Timer_Sidebar_Menu.Interval = 10;
            this.Timer_Sidebar_Menu.Tick += new System.EventHandler(this.Timer_Sidebar_Menu_Tick);
            // 
            // DragControl_Form
            // 
            this.DragControl_Form.TargetControl = this.TitleBarPanel;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(970, 526);
            this.ControlBox = false;
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.panel1);
            this.Trans.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project ZOPZ";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.SideBar.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.DotsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CheckTimer;
        private Guna.UI2.WinForms.Guna2Transition Ani;
        private Guna.UI2.WinForms.Guna2Transition Trans;
        private Guna.UI2.WinForms.Guna2HtmlToolTip GunaTIP;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Timer Timer_Sidebar_Menu;
        private Guna.UI.WinForms.GunaDragControl DragControl_Form;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Guna.UI.WinForms.GunaPanel SideBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label userdetails;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlNavIndicator;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel TitleBarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DotsPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}