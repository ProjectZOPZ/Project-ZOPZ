using Fusion;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    public class Tools
    {
        public static bool IsAuthCheckOk;

        public static void AddNewAttackLog(string Target, string Port, string Time, string Method)
        {
            var Setting = SettingsManager.Load();

            Setting.Target += Target + Environment.NewLine;
            Setting.Port += Port + Environment.NewLine;
            Setting.Time += Time + Environment.NewLine;
            Setting.Method += Method + Environment.NewLine;
            Setting.SentAt += DateTime.Now.ToString() + Environment.NewLine;
            Setting.TotalAttacks++;
            Setting.Save();
        }
        public static string CurrentVersion = "4.1.9";

        public static async Task CheckForUpdate()
        {
            var resp = login.KeyAuthApp.var("Verson");
            if (!resp.Contains("Invalid Var"))
            {
                if (!resp.Contains(CurrentVersion))
                {
                    Mess.Show("Update available", "There is a new update available for Project ZOPZ please download the new one");
                    Process.Start(login.KeyAuthApp.var("UpdateLink"));
                    Environment.Exit(0);
                }
            }
        }

        public static void logger(string host, string label)
        {
            var Setting = SettingsManager.Load();

            Setting.host += host + Environment.NewLine;
            Setting.label += label + Environment.NewLine;
            Setting.Save();
        }
        public static void CheckToMuch()
        {
            var Setting = SettingsManager.Load();

            if (Setting.TotalAttacks >= 100)
            {
                ClearAllAttackLogs();
                MessageBox.Show("Attack logs", "cleared\nReason: Over 100 logs");
            }
        }

        public static void ClearAllAttackLogs()
        {
            var Setting = SettingsManager.Load();

            Setting.Target = string.Empty;
            Setting.Port = string.Empty;
            Setting.Time = string.Empty;
            Setting.Method = string.Empty;
            Setting.SentAt = string.Empty;
            Setting.Save();
        }
        public static async Task<string> GeoLocateAsync(string host)
        {
            var response = await Helpers.Client.Http.Get($"http://ip-api.com/json/{host}?fields=66846719");
            if (!response.Error)
            {
                var json = JsonConvert.DeserializeObject<Helpers.Client.JsonModule.GeoIP>(response.Response);
                if (json.Status == "success")
                {
                    return $"Target: {json.Query}\nContinent: {json.Continent}\nCountry: {json.Country} \nCountryCode: {json.CountryCode} \nRegionName: {json.RegionName} \nReverse: {json.Reverse} \nRegion: {json.Region} \nCity: {json.City}\nISP: {json.Isp}\nORG: {json.Org}\nAS: {json.As} \nAsname: {json.Asname} \nTimezone: {json.Timezone} \nZipcode: {json.Zip} \nOffset: {json.Offset} \nCurrency: {json.Currency}\nMoblile: {json.Mobile}\nHosting: {json.Hosting}\nProxy: {json.Proxy}";
                }
                else
                {
                    return $"Info: {json.Status}\nMessage: {json.Message}\nQuery: {json.Query}";
                }
            }
            else
            {
                return $"Error: {response.Exception.Message}";
            }
        }

        public static string CheckOpenPort(string host, string port)
        {
            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(port)) return "Your missing host or port";

            try
            {
                var client = new TcpClient();
                if (client.ConnectAsync(host, Convert.ToInt32(port)).Wait(500))
                {
                    return $"Port {port} is open on {host}";
                }
                else
                {
                    return $"Port {port} is closed on {host}";
                }
            }
            catch { return "Error happend, try again"; }
        }
        public static string PSNResolver(string UserName)
        {
            string result;
            if (string.IsNullOrWhiteSpace(UserName))
            {
                result = "Invalid UserName";
            }
            else
            {
                try
                {
                    result = Tools.psnreq("https://api.playstationresolver.xyz?ACTION=GAMERTAG_TO_IP&GAMERTAG=", UserName).Replace(",", " \r\n");
                }
                catch
                {
                    result = "PSN API is down!";
                }
            }
            return result;
        }
        internal static string psnreq(string url, string username)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Accept = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";
            httpWebRequest.Proxy = null;
            string value = string.Format("psn={0}", username);
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(value);
                streamWriter.Flush();
                streamWriter.Close();
            }
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                string text = WebUtility.HtmlDecode(streamReader.ReadToEnd());
                result = text;
            }
            return result;
        }
        public static async Task<string> NmapScan(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://webresolver.nl/api.php?key=KC3B9-E9T5K-3TNS9-XDGC9&html=0&action=portscan&string={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }

        public static async Task<string> ZoneLookup(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain)) return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://api.hackertarget.com/zonetransfer/?q={domain}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> recroomload(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://rooms.rec.net/rooms/{domain}");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
        public static async Task<string> showcase(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://rooms.rec.net/showcase/{domain}");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
        public static async Task<string> bio(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://api.rec.net/api/images/v1/{domain}/comments");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
        public static async Task<string> lookuproom(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://rooms.rec.net/rooms?name={domain}");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
        public static async Task<string> lookupuser(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://api.rec.net/api/images/v4/{domain}");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
        public static async Task<string> SubnetScan(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://api.hackertarget.com/subnetcalc/?q={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }

        public static async Task<string> DnsLookup(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain))
                return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://api.hackertarget.com/dnslookup/?q={domain}");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
        public static async Task<string> num(string host)
        {
            if (string.IsNullOrWhiteSpace(host))
                return "Host is null";

            var response = await Helpers.Client.Http.Get($"http://apilayer.net/api/validate?access_key=feea8fd1f565614a1ab4bfd02398a9ed&number={host}&country_code=");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
        public static async Task<string> sd(string host)
        {
            var response = await Helpers.Client.Http.Get($"https://randomuser.me/api/");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> sdf(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain)) return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://api.hackertarget.com/httpheaders/?q={domain}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> whois(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain)) return "Domain is null";

            var response = await Helpers.Client.Http.Get($"https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey=at_ovhn6veSyaKHJyQ9XztngLr2E7H8Z&domainName={domain}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> sdsds(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://mac-address.whoisxmlapi.com/api/v1?apiKey=at_ovhn6veSyaKHJyQ9XztngLr2E7H8Z&macAddress={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> iptopsn(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://api.playstationresolver.xyz?ACTION=IP_TO_GAMERTAG&IP_ADDRESS={host}&JSON=FALSE");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> psntoip(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://api.playstationresolver.xyz?ACTION=GAMERTAG_TO_IP&GAMERTAG={host}&JSON=FALSE");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> IPCount(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://api.playstationresolver.xyz?ACTION=IP_COUNT&JSON=FALSE");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> ReverseDNSLookup(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://api.hackertarget.com/reversedns/?q={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> Pagelinks(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://api.hackertarget.com/pagelinks/?q={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> Skyperesolver(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://webresolver.nl/api.php?key=KC3B9-E9T5K-3TNS9-XDGC9&action=resolve&string={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> IPtoSkype(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://webresolver.nl/api.php?key=KC3B9-E9T5K-3TNS9-XDGC9&action=ip2skype&string={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> EmailtoSkype(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://webresolver.nl/api.php?key=KC3B9-E9T5K-3TNS9-XDGC9&action=email2skype&string={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> WebsiteHeaders(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://webresolver.nl/api.php?key=KC3B9-E9T5K-3TNS9-XDGC9&action=header&string={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> Disposableemailchecker(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://webresolver.nl/api.php?key=KC3B9-E9T5K-3TNS9-XDGC9&action=disposable_email&string={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> netblocks(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Helpers.Client.Http.Get($"https://ip-netblocks.whoisxmlapi.com/api/v2?apiKey=at_ovhn6veSyaKHJyQ9XztngLr2E7H8Z&ip={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
        public static async Task<string> DOX(string name, string state, string city)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Name is null";

            var response = await Helpers.Client.Http.Get($"https://api.peopledatalabs.com/v5/company/{name}");

            if (!response.Error)
            {
                // Deserialize the JSON response into a dynamic object
                dynamic jsonObject = JsonConvert.DeserializeObject(response.Response);

                // Serialize it back into a formatted JSON string
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return prettyJson;
            }
            else
            {
                return response.Exception.Message;
            }
        }
    }
}

       