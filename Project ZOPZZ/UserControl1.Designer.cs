namespace Project_ZOPZZ
{
    partial class UserControl1
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Trans = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndPortTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StartPortTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.host = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendAttackBTN = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // Trans
            // 
            this.Trans.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Trans.Cursor = null;
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
            animation1.TransparencyCoeff = 1F;
            this.Trans.DefaultAnimation = animation1;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BackColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2GroupBox4.Controls.Add(this.guna2VScrollBar1);
            this.guna2GroupBox4.Controls.Add(this.dataGridView1);
            this.guna2GroupBox4.Controls.Add(this.EndPortTextBox);
            this.guna2GroupBox4.Controls.Add(this.StartPortTextBox);
            this.guna2GroupBox4.Controls.Add(this.host);
            this.guna2GroupBox4.Controls.Add(this.SendAttackBTN);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Trans.SetDecoration(this.guna2GroupBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GroupBox4.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(893, 452);
            this.guna2GroupBox4.TabIndex = 79;
            this.guna2GroupBox4.Text = "Attack Hub";
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.dataGridView1;
            this.Trans.SetDecoration(this.guna2VScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.Black;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(849, 164);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 211);
            this.guna2VScrollBar1.TabIndex = 101;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.White;
            this.guna2VScrollBar1.ThumbSize = 5F;
            this.guna2VScrollBar1.Value = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.Trans.SetDecoration(this.dataGridView1, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridView1.Location = new System.Drawing.Point(40, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(827, 211);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ports Open";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EndPortTextBox
            // 
            this.EndPortTextBox.Animated = true;
            this.EndPortTextBox.BackColor = System.Drawing.Color.Black;
            this.EndPortTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EndPortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Trans.SetDecoration(this.EndPortTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EndPortTextBox.DefaultText = "";
            this.EndPortTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EndPortTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.EndPortTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.FillColor = System.Drawing.Color.Black;
            this.EndPortTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EndPortTextBox.FocusedState.FillColor = System.Drawing.Color.Black;
            this.EndPortTextBox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.EndPortTextBox.ForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EndPortTextBox.HoverState.FillColor = System.Drawing.Color.Black;
            this.EndPortTextBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.Location = new System.Drawing.Point(427, 106);
            this.EndPortTextBox.Name = "EndPortTextBox";
            this.EndPortTextBox.PasswordChar = '\0';
            this.EndPortTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.EndPortTextBox.PlaceholderText = "End Port";
            this.EndPortTextBox.SelectedText = "";
            this.EndPortTextBox.Size = new System.Drawing.Size(440, 36);
            this.EndPortTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EndPortTextBox.TabIndex = 61;
            // 
            // StartPortTextBox
            // 
            this.StartPortTextBox.Animated = true;
            this.StartPortTextBox.BackColor = System.Drawing.Color.Black;
            this.StartPortTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StartPortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Trans.SetDecoration(this.StartPortTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.StartPortTextBox.DefaultText = "";
            this.StartPortTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StartPortTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.StartPortTextBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.FillColor = System.Drawing.Color.Black;
            this.StartPortTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StartPortTextBox.FocusedState.FillColor = System.Drawing.Color.Black;
            this.StartPortTextBox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StartPortTextBox.ForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StartPortTextBox.HoverState.FillColor = System.Drawing.Color.Black;
            this.StartPortTextBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.Location = new System.Drawing.Point(40, 106);
            this.StartPortTextBox.Name = "StartPortTextBox";
            this.StartPortTextBox.PasswordChar = '\0';
            this.StartPortTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.StartPortTextBox.PlaceholderText = "Start Port";
            this.StartPortTextBox.SelectedText = "";
            this.StartPortTextBox.Size = new System.Drawing.Size(381, 36);
            this.StartPortTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.StartPortTextBox.TabIndex = 60;
            // 
            // host
            // 
            this.host.Animated = true;
            this.host.BackColor = System.Drawing.Color.Black;
            this.host.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.host.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Trans.SetDecoration(this.host, Guna.UI2.AnimatorNS.DecorationType.None);
            this.host.DefaultText = "";
            this.host.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.host.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.host.DisabledState.ForeColor = System.Drawing.Color.White;
            this.host.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.host.FillColor = System.Drawing.Color.Black;
            this.host.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.host.FocusedState.FillColor = System.Drawing.Color.Black;
            this.host.FocusedState.ForeColor = System.Drawing.Color.White;
            this.host.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.host.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.host.ForeColor = System.Drawing.Color.White;
            this.host.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.host.HoverState.FillColor = System.Drawing.Color.Black;
            this.host.HoverState.ForeColor = System.Drawing.Color.White;
            this.host.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.host.Location = new System.Drawing.Point(40, 60);
            this.host.Name = "host";
            this.host.PasswordChar = '\0';
            this.host.PlaceholderForeColor = System.Drawing.Color.White;
            this.host.PlaceholderText = "Target";
            this.host.SelectedText = "";
            this.host.Size = new System.Drawing.Size(827, 36);
            this.host.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.host.TabIndex = 59;
            // 
            // SendAttackBTN
            // 
            this.SendAttackBTN.Animated = true;
            this.SendAttackBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SendAttackBTN.BorderThickness = 1;
            this.SendAttackBTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.Trans.SetDecoration(this.SendAttackBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SendAttackBTN.FillColor = System.Drawing.Color.Black;
            this.SendAttackBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SendAttackBTN.ForeColor = System.Drawing.Color.White;
            this.SendAttackBTN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SendAttackBTN.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SendAttackBTN.HoverState.FillColor = System.Drawing.Color.Black;
            this.SendAttackBTN.HoverState.ForeColor = System.Drawing.Color.White;
            this.SendAttackBTN.Location = new System.Drawing.Point(40, 396);
            this.SendAttackBTN.Name = "SendAttackBTN";
            this.SendAttackBTN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SendAttackBTN.Size = new System.Drawing.Size(827, 34);
            this.SendAttackBTN.TabIndex = 9;
            this.SendAttackBTN.Text = "Scan Ports";
            this.SendAttackBTN.Click += new System.EventHandler(this.SendAttackBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guna2GroupBox4);
            this.Trans.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(893, 452);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.guna2GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition Trans;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2TextBox EndPortTextBox;
        private Guna.UI2.WinForms.Guna2TextBox StartPortTextBox;
        private Guna.UI2.WinForms.Guna2TextBox host;
        private Guna.UI2.WinForms.Guna2Button SendAttackBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
