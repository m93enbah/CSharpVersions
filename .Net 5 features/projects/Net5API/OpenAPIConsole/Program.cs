using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenAPIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {

            SampleSwaggerClient client = new("https://localhost:44360/", new HttpClient());
            var forecasts = await client.WeatherForecastAsync();

            foreach (var weatherForecase in forecasts) 
            {
                Console.WriteLine($"Date : {weatherForecase.Date} , Sumamry : {weatherForecase.Summary}");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
