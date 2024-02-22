namespace Project_ZOPZZ
{
    partial class spambot
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SpamTextBox = new System.Windows.Forms.RichTextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SpamStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.milisec = new Guna.UI2.WinForms.Guna2TrackBar();
            this.SpamBTN = new Guna.UI2.WinForms.Guna2Button();
            this.SpamTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(893, 452);
            this.guna2Panel2.TabIndex = 27;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.SpamTextBox);
            this.guna2Panel3.Controls.Add(this.guna2Separator1);
            this.guna2Panel3.Controls.Add(this.SpamStatus);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.milisec);
            this.guna2Panel3.Controls.Add(this.SpamBTN);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(893, 452);
            this.guna2Panel3.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(199, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(505, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Spam Status: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SpamTextBox
            // 
            this.SpamTextBox.BackColor = System.Drawing.Color.Black;
            this.SpamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpamTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SpamTextBox.ForeColor = System.Drawing.Color.White;
            this.SpamTextBox.Location = new System.Drawing.Point(203, 239);
            this.SpamTextBox.Name = "SpamTextBox";
            this.SpamTextBox.Size = new System.Drawing.Size(501, 89);
            this.SpamTextBox.TabIndex = 22;
            this.SpamTextBox.Text = "Text to spam";
            this.SpamTextBox.TextChanged += new System.EventHandler(this.SpamTextBox_TextChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Separator1.Location = new System.Drawing.Point(3, 32);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(890, 10);
            this.guna2Separator1.TabIndex = 116;
            // 
            // SpamStatus
            // 
            this.SpamStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SpamStatus.ForeColor = System.Drawing.Color.White;
            this.SpamStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SpamStatus.Location = new System.Drawing.Point(199, 116);
            this.SpamStatus.Name = "SpamStatus";
            this.SpamStatus.Size = new System.Drawing.Size(505, 19);
            this.SpamStatus.TabIndex = 25;
            this.SpamStatus.Text = "Off";
            this.SpamStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SpamStatus.Click += new System.EventHandler(this.SpamStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 115;
            this.label2.Text = "Spambot";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(199, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Miliseconds: 1000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // milisec
            // 
            this.milisec.Location = new System.Drawing.Point(203, 200);
            this.milisec.Maximum = 10000;
            this.milisec.Minimum = 100;
            this.milisec.Name = "milisec";
            this.milisec.Size = new System.Drawing.Size(501, 24);
            this.milisec.SmallChange = 0;
            this.milisec.TabIndex = 23;
            this.milisec.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.milisec.Value = 1000;
            this.milisec.Scroll += new System.Windows.Forms.ScrollEventHandler(this.milisec_Scroll);
            // 
            // SpamBTN
            // 
            this.SpamBTN.Animated = true;
            this.SpamBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SpamBTN.BorderRadius = 2;
            this.SpamBTN.BorderThickness = 2;
            this.SpamBTN.FillColor = System.Drawing.Color.Transparent;
            this.SpamBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SpamBTN.ForeColor = System.Drawing.Color.White;
            this.SpamBTN.Location = new System.Drawing.Point(203, 344);
            this.SpamBTN.Name = "SpamBTN";
            this.SpamBTN.PressedColor = System.Drawing.Color.White;
            this.SpamBTN.Size = new System.Drawing.Size(501, 35);
            this.SpamBTN.TabIndex = 16;
            this.SpamBTN.Text = "Start";
            this.SpamBTN.Click += new System.EventHandler(this.SpamBTN_Click);
            // 
            // SpamTimer
            // 
            this.SpamTimer.Interval = 1000;
            this.SpamTimer.Tick += new System.EventHandler(this.SpamTimer_Tick);
            // 
            // spambot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guna2Panel2);
            this.Name = "spambot";
            this.Size = new System.Drawing.Size(893, 459);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SpamStatus;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar milisec;
        private System.Windows.Forms.RichTextBox SpamTextBox;
        private Guna.UI2.WinForms.Guna2Button SpamBTN;
        private System.Windows.Forms.Timer SpamTimer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
    }
}
