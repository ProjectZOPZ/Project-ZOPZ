namespace Project_ZOPZZ
{
    partial class login
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.RegistePanel = new System.Windows.Forms.Panel();
            this.Token = new Guna.UI2.WinForms.Guna2TextBox();
            this.Passwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.user = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShowLoginBTN = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RegisterBTN = new Guna.UI2.WinForms.Guna2Button();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Remebermecheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ShowRegBTN = new System.Windows.Forms.Label();
            this.LoginBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DotsPanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Ani = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.DragControl_Form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.RegistePanel.SuspendLayout();
            this.TitleBarPanel.SuspendLayout();
            this.DotsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.RegistePanel);
            this.guna2Panel1.Controls.Add(this.Password);
            this.guna2Panel1.Controls.Add(this.Username);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.Remebermecheck);
            this.guna2Panel1.Controls.Add(this.ShowRegBTN);
            this.guna2Panel1.Controls.Add(this.LoginBTN);
            this.Ani.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(448, 435);
            this.guna2Panel1.TabIndex = 42;
            // 
            // RegistePanel
            // 
            this.RegistePanel.BackColor = System.Drawing.Color.Black;
            this.RegistePanel.Controls.Add(this.Token);
            this.RegistePanel.Controls.Add(this.Passwd);
            this.RegistePanel.Controls.Add(this.user);
            this.RegistePanel.Controls.Add(this.ShowLoginBTN);
            this.RegistePanel.Controls.Add(this.label9);
            this.RegistePanel.Controls.Add(this.RegisterBTN);
            this.Ani.SetDecoration(this.RegistePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RegistePanel.Location = new System.Drawing.Point(0, 56);
            this.RegistePanel.Name = "RegistePanel";
            this.RegistePanel.Size = new System.Drawing.Size(448, 376);
            this.RegistePanel.TabIndex = 36;
            this.RegistePanel.Visible = false;
            this.RegistePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RegistePanel_Paint);
            // 
            // Token
            // 
            this.Token.Animated = true;
            this.Token.BackColor = System.Drawing.Color.Black;
            this.Token.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Token.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.Token, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Token.DefaultText = "";
            this.Token.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Token.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Token.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Token.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Token.FillColor = System.Drawing.Color.Black;
            this.Token.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Token.FocusedState.FillColor = System.Drawing.Color.Black;
            this.Token.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Token.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Token.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Token.ForeColor = System.Drawing.Color.White;
            this.Token.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Token.HoverState.FillColor = System.Drawing.Color.Black;
            this.Token.HoverState.ForeColor = System.Drawing.Color.White;
            this.Token.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Token.Location = new System.Drawing.Point(31, 163);
            this.Token.Name = "Token";
            this.Token.PasswordChar = '\0';
            this.Token.PlaceholderForeColor = System.Drawing.Color.White;
            this.Token.PlaceholderText = "Token";
            this.Token.SelectedText = "";
            this.Token.Size = new System.Drawing.Size(385, 36);
            this.Token.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Token.TabIndex = 94;
            // 
            // Passwd
            // 
            this.Passwd.Animated = true;
            this.Passwd.BackColor = System.Drawing.Color.Black;
            this.Passwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.Passwd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Passwd.DefaultText = "";
            this.Passwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Passwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Passwd.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Passwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Passwd.FillColor = System.Drawing.Color.Black;
            this.Passwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Passwd.FocusedState.FillColor = System.Drawing.Color.Black;
            this.Passwd.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Passwd.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Passwd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Passwd.ForeColor = System.Drawing.Color.White;
            this.Passwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Passwd.HoverState.FillColor = System.Drawing.Color.Black;
            this.Passwd.HoverState.ForeColor = System.Drawing.Color.White;
            this.Passwd.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Passwd.Location = new System.Drawing.Point(33, 101);
            this.Passwd.Name = "Passwd";
            this.Passwd.PasswordChar = '\0';
            this.Passwd.PlaceholderForeColor = System.Drawing.Color.White;
            this.Passwd.PlaceholderText = "Password";
            this.Passwd.SelectedText = "";
            this.Passwd.Size = new System.Drawing.Size(385, 36);
            this.Passwd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Passwd.TabIndex = 93;
            // 
            // user
            // 
            this.user.Animated = true;
            this.user.BackColor = System.Drawing.Color.Black;
            this.user.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.user, Guna.UI2.AnimatorNS.DecorationType.None);
            this.user.DefaultText = "";
            this.user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.user.DisabledState.ForeColor = System.Drawing.Color.White;
            this.user.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.user.FillColor = System.Drawing.Color.Black;
            this.user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.user.FocusedState.FillColor = System.Drawing.Color.Black;
            this.user.FocusedState.ForeColor = System.Drawing.Color.White;
            this.user.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.user.HoverState.FillColor = System.Drawing.Color.Black;
            this.user.HoverState.ForeColor = System.Drawing.Color.White;
            this.user.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(31, 33);
            this.user.Name = "user";
            this.user.PasswordChar = '\0';
            this.user.PlaceholderForeColor = System.Drawing.Color.White;
            this.user.PlaceholderText = "Username";
            this.user.SelectedText = "";
            this.user.Size = new System.Drawing.Size(385, 36);
            this.user.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.user.TabIndex = 92;
            // 
            // ShowLoginBTN
            // 
            this.ShowLoginBTN.AutoSize = true;
            this.Ani.SetDecoration(this.ShowLoginBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowLoginBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ShowLoginBTN.ForeColor = System.Drawing.Color.White;
            this.ShowLoginBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLoginBTN.Location = new System.Drawing.Point(134, 290);
            this.ShowLoginBTN.Name = "ShowLoginBTN";
            this.ShowLoginBTN.Size = new System.Drawing.Size(66, 15);
            this.ShowLoginBTN.TabIndex = 29;
            this.ShowLoginBTN.Text = "Login here";
            this.ShowLoginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLoginBTN.Click += new System.EventHandler(this.ShowLoginBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.Ani.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(28, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Have an account?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Animated = true;
            this.RegisterBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RegisterBTN.BorderThickness = 1;
            this.Ani.SetDecoration(this.RegisterBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RegisterBTN.FillColor = System.Drawing.Color.Transparent;
            this.RegisterBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RegisterBTN.ForeColor = System.Drawing.Color.White;
            this.RegisterBTN.Location = new System.Drawing.Point(31, 225);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.PressedColor = System.Drawing.Color.White;
            this.RegisterBTN.Size = new System.Drawing.Size(385, 37);
            this.RegisterBTN.TabIndex = 24;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.BackColor = System.Drawing.Color.Black;
            this.Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.Password, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Password.FillColor = System.Drawing.Color.Black;
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Password.FocusedState.FillColor = System.Drawing.Color.Black;
            this.Password.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Password.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Password.HoverState.FillColor = System.Drawing.Color.Black;
            this.Password.HoverState.ForeColor = System.Drawing.Color.White;
            this.Password.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(33, 177);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderForeColor = System.Drawing.Color.White;
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(385, 36);
            this.Password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Password.TabIndex = 91;
            // 
            // Username
            // 
            this.Username.Animated = true;
            this.Username.BackColor = System.Drawing.Color.Black;
            this.Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.Username, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Username.FillColor = System.Drawing.Color.Black;
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Username.FocusedState.FillColor = System.Drawing.Color.Black;
            this.Username.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Username.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Username.HoverState.FillColor = System.Drawing.Color.Black;
            this.Username.HoverState.ForeColor = System.Drawing.Color.White;
            this.Username.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(33, 103);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderForeColor = System.Drawing.Color.White;
            this.Username.PlaceholderText = "Username";
            this.Username.SelectedText = "";
            this.Username.Size = new System.Drawing.Size(385, 36);
            this.Username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Username.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.Ani.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(31, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "New user?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Remebermecheck
            // 
            this.Remebermecheck.Animated = true;
            this.Remebermecheck.CheckedState.BorderColor = System.Drawing.Color.White;
            this.Remebermecheck.CheckedState.BorderRadius = 2;
            this.Remebermecheck.CheckedState.BorderThickness = 0;
            this.Remebermecheck.CheckedState.FillColor = System.Drawing.Color.Black;
            this.Ani.SetDecoration(this.Remebermecheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Remebermecheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Remebermecheck.ForeColor = System.Drawing.Color.White;
            this.Remebermecheck.Location = new System.Drawing.Point(33, 234);
            this.Remebermecheck.Name = "Remebermecheck";
            this.Remebermecheck.Size = new System.Drawing.Size(385, 19);
            this.Remebermecheck.TabIndex = 35;
            this.Remebermecheck.Text = "Remeber Me?";
            this.Remebermecheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Remebermecheck.UncheckedState.BorderRadius = 2;
            this.Remebermecheck.UncheckedState.BorderThickness = 0;
            this.Remebermecheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Remebermecheck.CheckedChanged += new System.EventHandler(this.Remebermecheck_CheckedChanged);
            // 
            // ShowRegBTN
            // 
            this.ShowRegBTN.AutoSize = true;
            this.Ani.SetDecoration(this.ShowRegBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowRegBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ShowRegBTN.ForeColor = System.Drawing.Color.White;
            this.ShowRegBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRegBTN.Location = new System.Drawing.Point(94, 349);
            this.ShowRegBTN.Name = "ShowRegBTN";
            this.ShowRegBTN.Size = new System.Drawing.Size(83, 15);
            this.ShowRegBTN.TabIndex = 38;
            this.ShowRegBTN.Text = "Register here";
            this.ShowRegBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRegBTN.Click += new System.EventHandler(this.ShowRegBTN_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.Animated = true;
            this.LoginBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LoginBTN.BorderThickness = 1;
            this.Ani.SetDecoration(this.LoginBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LoginBTN.FillColor = System.Drawing.Color.Transparent;
            this.LoginBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LoginBTN.ForeColor = System.Drawing.Color.White;
            this.LoginBTN.Location = new System.Drawing.Point(33, 281);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.PressedColor = System.Drawing.Color.White;
            this.LoginBTN.Size = new System.Drawing.Size(385, 37);
            this.LoginBTN.TabIndex = 32;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            this.LoginBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBTN_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Ani.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Project ZOPZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Ani.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "| Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.Black;
            this.TitleBarPanel.Controls.Add(this.DotsPanel);
            this.TitleBarPanel.Controls.Add(this.label2);
            this.TitleBarPanel.Controls.Add(this.label1);
            this.Ani.SetDecoration(this.TitleBarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(448, 50);
            this.TitleBarPanel.TabIndex = 29;
            // 
            // DotsPanel
            // 
            this.DotsPanel.BackColor = System.Drawing.Color.Black;
            this.DotsPanel.Controls.Add(this.guna2ControlBox2);
            this.DotsPanel.Controls.Add(this.guna2ControlBox1);
            this.Ani.SetDecoration(this.DotsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DotsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DotsPanel.Location = new System.Drawing.Point(355, 0);
            this.DotsPanel.Name = "DotsPanel";
            this.DotsPanel.Size = new System.Drawing.Size(93, 50);
            this.DotsPanel.TabIndex = 41;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Ani.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(3, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 50);
            this.guna2ControlBox2.TabIndex = 3;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.Ani.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(48, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 50);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // Ani
            // 
            this.Ani.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Ani.Cursor = null;
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
            this.Ani.DefaultAnimation = animation2;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Ani.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 49);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(899, 10);
            this.guna2Separator1.TabIndex = 37;
            // 
            // DragControl_Form
            // 
            this.DragControl_Form.TargetControl = this.TitleBarPanel;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(448, 435);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Ani.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.RegistePanel.ResumeLayout(false);
            this.RegistePanel.PerformLayout();
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.DotsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel RegistePanel;
        private Guna.UI2.WinForms.Guna2Transition Ani;
        private System.Windows.Forms.Label ShowLoginBTN;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button RegisterBTN;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CheckBox Remebermecheck;
        private System.Windows.Forms.Label ShowRegBTN;
        private Guna.UI2.WinForms.Guna2Button LoginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel TitleBarPanel;
        private Guna.UI.WinForms.GunaDragControl DragControl_Form;
        private System.Windows.Forms.Panel DotsPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox Token;
        private Guna.UI2.WinForms.Guna2TextBox Passwd;
        private Guna.UI2.WinForms.Guna2TextBox user;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox Username;
    }
}