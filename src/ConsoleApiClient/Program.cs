using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApiClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task Main(string[] args)
        {
            Console.WriteLine("Machine Client Name: " + Environment.MachineName);
            
            var passwordResponse = await ProcessRepositories();

            Console.WriteLine("API response:  " + passwordResponse.password + "  -  " + passwordResponse.apiVersion + "  -  " + passwordResponse.apiServer);
       }


        private static async Task<PasswordResponse> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", ".NET ConsoleApi Client");

            var streamTask = client.GetStreamAsync("http://localhost:5001/password");
            var passwordResponse = await JsonSerializer.DeserializeAsync<PasswordResponse>(await streamTask);

           return passwordResponse;
        }
    }
}