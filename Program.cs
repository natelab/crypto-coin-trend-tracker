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
        string url = $"https://api.coingecko.com/api/v3/coins/{coinId}/history?date={date}";

        

    }
}