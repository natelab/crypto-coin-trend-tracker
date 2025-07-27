using System;
using System.Net.Http; //To make API calls/HTTP requests
using System.Threading.Tasks; //For async and await
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Enter cryptocurrency name (eg. Bitcoin); ");
        string coinId = Console.ReadLine();

        Console.WriteLine("Enter the date (dd-MM-yyyy)");
        string dateInput = Console.ReadLine();

        //Now to parse the user's date string
        //If the date string is not inputed correctly then it will show an error message and exit the program

        if (!DateTime.TryParseExact(dateInput, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
        {
            Console.WriteLine("Invalid date format.");
            return;
        }

        Console.WriteLine("\nThe Program is fetching data, please wait patiently...\n"); //Telling the user to wait

        
    }

    static async Task<string> GetCoinPriceOnDate(string coinId, string date)
    {
        string url = $"https://api.coingecko.com/api/v3/coins/{coinId}/history?date={date}"; //This is where the api is found

        using HttpClient client = new();
        var response = await client.GetStringAsync(url) ; //Send GET request
        var json = JObject.Parse(response) ; //Parsing the string into a JObject so that it can be easily accessed via JSON

        var price = json["market_data"]?["current_price"]?["usd"]; //Extracting the usd price from the JSON object
        return price != null ? $"${price}" : "Price not found."; //Return price

    }

    static async Task<string[]> GetNewsForDate(string query, string date)
    {
        string apiKey = "My Unique Api Key"; //Just put a placeholder value for nows
    }
}