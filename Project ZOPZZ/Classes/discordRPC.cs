using DiscordRPC;
using Project_ZOPZZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZOPZZ
{
    public static class Globals
    {
        public static DiscordRPC.DiscordRpcClient RPCClient = new DiscordRPC.DiscordRpcClient("1119862331250323557");
        public static readonly RichPresence RichPresence = new DiscordRPC.RichPresence
        {
            State = $"Version: 4.1.9",
            Timestamps = Timestamps.Now,
            Assets = new DiscordRPC.Assets
            {
                LargeImageKey = "phonto",
                LargeImageText = "Plans Start at 20$",
            },
            Buttons = new DiscordRPC.Button[]
            {
                new DiscordRPC.Button
                {
                    Label = "Telegram Server",
                    Url = "https://t.me/+QC0GpVEXw2c5OTgx"
                }
            }
        };

        public static void SetRPC()
        {
            var settings = SettingsManager.Load();
            if (settings.ShowDiscordRPC)
            {
                RPCClient.SetPresence(RichPresence);
            }
        }
    }
}