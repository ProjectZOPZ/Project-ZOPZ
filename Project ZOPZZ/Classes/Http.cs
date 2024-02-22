using System;
using System.Net.Http;
using System.Threading.Tasks;
using Module = Project_ZOPZZ.Helpers.Client.JsonModule.Modules;

namespace Project_ZOPZZ.Helpers.Client
{
    public class Http
    {
        private static HttpClient _client = new HttpClient();

        public static async Task<Module> Get(string uri)
        {
            try
            {
                var resp = await _client.GetAsync(uri);
                return new Module
                {
                    Error = false,
                    Response = await resp.Content.ReadAsStringAsync(),
                    Exception = null
                };
            }
            catch (Exception exception)
            {
                return new Module
                {
                    Error = true,
                    Response = "Response was not vaild",
                    Exception = exception
                };
            }
        }
    }
}
