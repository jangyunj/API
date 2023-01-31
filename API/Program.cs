using Newtonsoft.Json.Linq;

var client = new HttpClient();
var makeupURL = "https://makeup-api.herokuapp.com/api/v1/products.json?brand=maybelline";
var makeupResponse = client.GetStringAsync(makeupURL).Result;
var makeupObject = JArray.Parse(makeupResponse);
Console.WriteLine($"Maybe it's {makeupObject[0]["brand"]} ;)");

//Kanye & Ron conversation API

for (var i = 0; i < 5; i++)
{
    var client1 = new HttpClient();
    var ron = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
    var ronResponse = client.GetStringAsync(ron).Result;
    var ronObject = JArray.Parse(ronResponse);

    var client2 = new HttpClient();
    var kanye = "https://api.kanye.rest";
    var kanyeResponse = client.GetStringAsync(kanye).Result;
    var kanyeObject = JObject.Parse(kanyeResponse);

    Console.WriteLine($"Ron says: {ronObject[0]}");
    Console.WriteLine($"Kanye says: {kanyeObject["quote"]}");
}
