using Newtonsoft.Json.Linq;

namespace OpenWeatherMapExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var apikey = "6395afb0b279b1d494595e722c1ffa44";


            Console.WriteLine("What city would you like to know the wearther for?");
            var cityName = Console.ReadLine();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apikey}&units=imperial";
            var weatherResponse = client.GetStringAsync(weatherURL).Result;
            var weatherObject = JObject.Parse(weatherResponse);



            Console.WriteLine($"{weatherObject["main"]["temp"]} degrees Fahernhiet for {cityName}");
            

        }
    }
}