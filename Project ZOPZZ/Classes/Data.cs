using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZOPZZ
{
    public class Data
    {
        public static async Task<string> NewsText() //News box           
        {
            try
            {
                var client = new HttpClient();
                var content = await client.GetStringAsync("https://pastebin.com/raw/fpG0Y8TS");
                client.Dispose();
                return content;
            }
            catch
            {
                return "N/A";
            }
        }
        public static async Task<string> Download(string url) //Usage Data.Download(url)
        {
            using (var client = new HttpClient())
            {
                var value = await client.GetStringAsync(url);
                return value;
            }
        }
    }
}
