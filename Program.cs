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

        Console.WriteLine("Enter the date (dd-mm-yyyy)");
        string dateInput = Console.ReadLine();


    }
}