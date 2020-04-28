using System;
using System.Net.Http;

namespace CoVID19
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = GetJSONData("https://api.covid19india.org/raw_data.json");
            Console.WriteLine(json.Content.ReadAsStringAsync().Result);
        }

        static HttpResponseMessage GetJSONData(string uri)
        {
            using var client = new HttpClient();
            var result = client.GetAsync(uri);
            return result.Result;
        }
    }
}
