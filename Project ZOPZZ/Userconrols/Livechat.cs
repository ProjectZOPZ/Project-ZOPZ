using DiscordRPC;
using Fusion;
using System;
using System.ServiceModel.ComIntegration;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace Project_ZOPZZ
{
    public partial class Livechat : UserControl
    {
        private delegate string CurrentLabelCallback();
        public Livechat()
        {
            InitializeComponent();
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Copy");
            contextMenuStrip1.Items.Add(copyMenuItem);
        }
        string chatchannel = "livechat"; // chat channel name
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

        private void host_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Livechat_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            timer1.Interval = 15000; // get chat messages every 15 seconds
            if (!String.IsNullOrEmpty(chatchannel))
            {
                var messages = login.KeyAuthApp.chatget(chatchannel);
                if (messages == null)
                {
                    dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
                }
                else
                {
                    foreach (var message in messages)
                    {
                        dataGridView1.Rows.Insert(0, message.author, message.message, UnixTimeToDateTime(long.Parse(message.timestamp)));
                    }
                }
            }
            else
            {
                timer1.Stop();
                dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearAllMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            this.Alert($"All Messages Cleared", alirt.enmType.Success);
        }
        public void Alert(string msg, alirt.enmType type)
        {
            alirt frm = new alirt();
            frm.showAlert(msg, type);
        }
        private void copyMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 1)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[1].RowIndex;
                int selectedColumnIndex = dataGridView1.SelectedCells[1].ColumnIndex;

                // Get the value from the selected cell
                object cellValue = dataGridView1[selectedColumnIndex, selectedRowIndex].Value;

                // Copy the value to the clipboard
                if (cellValue != null)
                {
                    Clipboard.SetText(cellValue.ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Days " + difference.Hours + " Hours Left");
        }
        private async void host_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (login.KeyAuthApp.chatsend(host.Text, chatchannel))
                {
                    dataGridView1.Rows.Insert(0, login.KeyAuthApp.user_data.username, host.Text, UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
                }
                else
                    host.Text = "";

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void nukeChatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void host_KeyDown_3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (login.KeyAuthApp.chatsend(host.Text, chatchannel))
                {
                    dataGridView1.Rows.Insert(0, login.KeyAuthApp.user_data.username, host.Text, UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
                }
                else
                    host.Text = "";

            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
