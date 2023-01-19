// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;

var client = new HttpClient();

var apiKEY = "ec841c2e708fb6bb7c853a27ba140c2c";

Console.WriteLine("Please enter city");
var cityName = Console.ReadLine();

var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKEY}&units=imperial";
string weatherResponse = client.GetStringAsync(weatherMapURL).Result;
JObject weatherObject = JObject.Parse(weatherResponse);

Console.WriteLine("Weather:");
Console.WriteLine($"It is {weatherObject["main"]["temp"]} degrees F in {cityName}");