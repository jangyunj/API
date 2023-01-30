using Newtonsoft.Json.Linq;

var client = new HttpClient();
var makeupURL = "https://makeup-api.herokuapp.com/api/v1/products.json?brand=maybelline";
var makeupResponse = client.GetStringAsync(makeupURL).Result;
var makeupObject = JArray.Parse(makeupResponse);
Console.WriteLine($"Maybe it's {makeupObject[0]["brand"]} ;)");
