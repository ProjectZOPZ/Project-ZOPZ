using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ThatsThemApi
{
    private readonly HttpClient httpClient;

    public ThatsThemApi()
    {
        httpClient = new HttpClient();
    }

    public async Task<string> GetNameInfo(string name, string last)
    {
        try
        {
            // Construct the URL
            string url = $"https://thatsthem.com/name/{name}-{last}";

            // Send an HTTP GET request
            HttpResponseMessage response = await httpClient.GetAsync(url);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Parse the HTML content
                string htmlContent = await response.Content.ReadAsStringAsync();
                var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(htmlContent);

                // Extract information from the HTML, e.g., using XPath or CSS selectors
                // Example: var info = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='info']").InnerText;

                // Return the extracted information
                return "Parsed information here";
            }
            else
            {
                // Handle the case where the request was not successful
                return "Error: Unable to retrieve data";
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions, e.g., network errors
            return "Error: " + ex.Message;
        }
    }
}
