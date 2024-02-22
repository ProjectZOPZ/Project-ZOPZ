using System;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string chatchannel = "livechat"; // chat channel name

        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
            siticoneLabel1.Text = $"Current Session Validation Status: {Login.KeyAuthApp.response.success}";
            key.Text = "Username: " + Login.KeyAuthApp.user_data.username;
            expiry.Text = "Expiry: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
            subscription.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
            ip.Text = "IP Address: " + Login.KeyAuthApp.user_data.ip;
            hwid.Text = "HWID: " + Login.KeyAuthApp.user_data.hwid;
            createDate.Text = "Creation date: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
            lastLogin.Text = "Last login: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));
            subscriptionDaysLabel.Text = "Expiry in Days: "+ expirydaysleft();
            numUsers.Text = "Number of users: " + Login.KeyAuthApp.app_data.numUsers;
            numOnlineUsers.Text = "Number of online users: " + Login.KeyAuthApp.app_data.numOnlineUsers;
            numKeys.Text = "Number of licenses: " + Login.KeyAuthApp.app_data.numKeys;
            version.Text = "Current version: " + Login.KeyAuthApp.app_data.version;
            customerPanelLink.Text = "Customer panel: " + Login.KeyAuthApp.app_data.customerPanelLink;

            var onlineUsers = Login.KeyAuthApp.fetchOnline();
            onlineUsersBox.Items.Clear();
            foreach (var user in onlineUsers)
            {
                onlineUsersBox.Items.Add(user.credential);
            }
            onlineUsersBox.SelectedIndex = 0;
        }

        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Login.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }
        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
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

        private void sendmsg_Click(object sender, EventArgs e)
        {
            if (Login.KeyAuthApp.chatsend(chatmsg.Text, chatchannel))
            {
                dataGridView1.Rows.Insert(0, Login.KeyAuthApp.user_data.username, chatmsg.Text, UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            }
            else
                chatmsg.Text = "Status: " + Login.KeyAuthApp.response.message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            timer1.Interval = 15000; // get chat messages every 15 seconds
            if (!String.IsNullOrEmpty(chatchannel))
            {
                var messages = Login.KeyAuthApp.chatget(chatchannel);
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
    }
}