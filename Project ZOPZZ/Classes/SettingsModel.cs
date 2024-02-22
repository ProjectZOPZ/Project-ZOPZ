using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    public class SettingsModel
    {
        public SettingsModel()
        {

        }

        // Login Saving
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RemeberMe { get; set; }

        public int Concurrents { get; set; }
        // Attack Logs
        public string Target { get; set; }
        public string Port { get; set; }
        public string Time { get; set; }
        public string Method { get; set; }
        public string SentAt { get; set; }
        public int TotalAttacks { get; set; }
        // Token: 0x04000120 RID: 288
        // Settings
        public string PicPath { get; set; } = null;
        public bool ShowDiscordRPC { get; set; } = true;
        public bool AutoLogin { get; set; } = false;
        public bool AppTopMost { get; set; } = false;

        public int TotalAttacksSent { get; set; }
        // logger
        public string host { get; set; }
        public string label { get; set; }
    }
}
