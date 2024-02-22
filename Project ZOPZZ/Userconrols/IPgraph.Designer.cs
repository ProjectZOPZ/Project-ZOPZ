namespace Project_ZOPZZ
{
    partial class IPgraph
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.servertimer = new System.Windows.Forms.Timer(this.components);
            this.clearservertimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.outbox = new System.Windows.Forms.RichTextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button34 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button26 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button21 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.UsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // servertimer
            // 
            this.servertimer.Interval = 1000;
            this.servertimer.Tick += new System.EventHandler(this.servertimer_TickAsync);
            // 
            // clearservertimer
            // 
            this.clearservertimer.Interval = 20000;
            this.clearservertimer.Tick += new System.EventHandler(this.clearservertimer_TickAsync);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 20000;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Panel9.BorderThickness = 1;
            this.guna2Panel9.Controls.Add(this.guna2Panel5);
            this.guna2Panel9.Controls.Add(this.guna2VScrollBar1);
            this.guna2Panel9.Controls.Add(this.guna2Separator1);
            this.guna2Panel9.Controls.Add(this.label2);
            this.guna2Panel9.Controls.Add(this.outbox);
            this.guna2Panel9.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(893, 459);
            this.guna2Panel9.TabIndex = 108;
            this.guna2Panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel9_Paint);
            // 
            // outbox
            // 
            this.outbox.BackColor = System.Drawing.Color.Black;
            this.outbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.outbox.ForeColor = System.Drawing.Color.White;
            this.outbox.Location = new System.Drawing.Point(7, 48);
            this.outbox.Name = "outbox";
            this.outbox.ReadOnly = true;
            this.outbox.Size = new System.Drawing.Size(391, 382);
            this.outbox.TabIndex = 1;
            this.outbox.Text = "";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Separator1.Location = new System.Drawing.Point(3, 32);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(890, 10);
            this.guna2Separator1.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 117;
            this.label2.Text = "Rec room Tools";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.outbox;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.Black;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.Black;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(380, 48);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 382);
            this.guna2VScrollBar1.TabIndex = 119;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.White;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.UsernameTextBox);
            this.guna2Panel5.Controls.Add(this.guna2Button1);
            this.guna2Panel5.Controls.Add(this.guna2Button34);
            this.guna2Panel5.Controls.Add(this.guna2Button26);
            this.guna2Panel5.Controls.Add(this.guna2Button21);
            this.guna2Panel5.Controls.Add(this.guna2Button4);
            this.guna2Panel5.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel5.Location = new System.Drawing.Point(429, 64);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(441, 366);
            this.guna2Panel5.TabIndex = 121;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button1.Size = new System.Drawing.Size(435, 34);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Lookup Room Name";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button34
            // 
            this.guna2Button34.Animated = true;
            this.guna2Button34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button34.BorderThickness = 1;
            this.guna2Button34.FillColor = System.Drawing.Color.Black;
            this.guna2Button34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button34.ForeColor = System.Drawing.Color.White;
            this.guna2Button34.Location = new System.Drawing.Point(3, 133);
            this.guna2Button34.Name = "guna2Button34";
            this.guna2Button34.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button34.Size = new System.Drawing.Size(435, 34);
            this.guna2Button34.TabIndex = 19;
            this.guna2Button34.Text = "UserID lookup";
            this.guna2Button34.Click += new System.EventHandler(this.guna2Button34_Click);
            // 
            // guna2Button26
            // 
            this.guna2Button26.Animated = true;
            this.guna2Button26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button26.BorderThickness = 1;
            this.guna2Button26.FillColor = System.Drawing.Color.Black;
            this.guna2Button26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button26.ForeColor = System.Drawing.Color.White;
            this.guna2Button26.Location = new System.Drawing.Point(3, 93);
            this.guna2Button26.Name = "guna2Button26";
            this.guna2Button26.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button26.Size = new System.Drawing.Size(435, 34);
            this.guna2Button26.TabIndex = 15;
            this.guna2Button26.Text = "Room Showcase";
            this.guna2Button26.Click += new System.EventHandler(this.guna2Button26_Click);
            // 
            // guna2Button21
            // 
            this.guna2Button21.Animated = true;
            this.guna2Button21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button21.BorderThickness = 1;
            this.guna2Button21.FillColor = System.Drawing.Color.Black;
            this.guna2Button21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button21.ForeColor = System.Drawing.Color.White;
            this.guna2Button21.Location = new System.Drawing.Point(3, 53);
            this.guna2Button21.Name = "guna2Button21";
            this.guna2Button21.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button21.Size = new System.Drawing.Size(435, 34);
            this.guna2Button21.TabIndex = 22;
            this.guna2Button21.Text = "Lookup RoomID";
            this.guna2Button21.Click += new System.EventHandler(this.guna2Button21_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(3, 173);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button4.Size = new System.Drawing.Size(435, 34);
            this.guna2Button4.TabIndex = 14;
            this.guna2Button4.Text = "Display Players Bio";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Animated = true;
            this.UsernameTextBox.BackColor = System.Drawing.Color.Black;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBox.DefaultText = "";
            this.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.FillColor = System.Drawing.Color.Black;
            this.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UsernameTextBox.FocusedState.FillColor = System.Drawing.Color.Black;
            this.UsernameTextBox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UsernameTextBox.HoverState.FillColor = System.Drawing.Color.Black;
            this.UsernameTextBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.Location = new System.Drawing.Point(0, 327);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.UsernameTextBox.PlaceholderText = "Target Info";
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.Size = new System.Drawing.Size(441, 36);
            this.UsernameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UsernameTextBox.TabIndex = 119;
            // 
            // IPgraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guna2Panel9);
            this.Name = "IPgraph";
            this.Size = new System.Drawing.Size(893, 459);
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer servertimer;
        private System.Windows.Forms.Timer clearservertimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private System.Windows.Forms.RichTextBox outbox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button34;
        private Guna.UI2.WinForms.Guna2Button guna2Button26;
        private Guna.UI2.WinForms.Guna2Button guna2Button21;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBox;
    }
}
