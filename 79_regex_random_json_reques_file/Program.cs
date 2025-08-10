using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

record Purchase(string ProductName, DateTime DT, decimal ProductPrice);

class Test {
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args) {
        string text = "hello";
        string pattern = @"[hH][a-z]{1}llo";

        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.IsMatch(text));
        Console.WriteLine(Regex.IsMatch(text, pattern));

        string html = @"
            <html>
                <body>
                    <script>
                        var videoUrl = ""https://cdn.example.com/stream/video123.m3u8?token=abc123"";
                    </script>
                    <a href='http://media.example.net/live/stream1.m3u8'>Watch</a>
                </body>
            </html>";
        string pattern2 = @"https?:\/\/[^\s""'>]+\.m3u8(?:\?[^\s""'>]*)?";
        
        var matches = Regex.Matches(html, pattern2);
        if (matches.Count > 0)
        {
            Console.WriteLine("Found M3U8 URLs:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No M3U8 URLs found.");
        }

        Random random = new Random();
        Console.WriteLine(random.Next(1, 10));

        var purchase = new Purchase("Orange Juice", DateTime.Now, 2.49m);

        var options = new JsonSerializerOptions();
        options.WriteIndented = true;

        string jsonString = JsonSerializer.Serialize<Purchase>(purchase, options);

        Directory.CreateDirectory("output");
        string path = Path.Combine("output", "purchase.json");
        File.WriteAllText(path, jsonString);

        var purchaseJson = File.ReadAllText(path);

        var purchase2 = JsonSerializer.Deserialize<Purchase>(purchaseJson);
        Console.WriteLine(purchase2?.ProductName);

        var request = new HttpRequestMessage(
            HttpMethod.Get,
            "https://api.ipify.org?format=json"            
        ); 
        request.Headers.Add("accept", "*/*");

        var response = await client.SendAsync(request); // (int)response.StatusCode
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);

        var request2 = new HttpRequestMessage(
            HttpMethod.Post,
            "https://dummyjson.com/posts/add"            
        ); 
        request2.Headers.Add("accept", "*/*");

        var payload = new {
            title = "I am in love with someone.",
            userId = @"5"
        };
        string jsonPayload = JsonSerializer.Serialize(payload);
        request2.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        var response2 = await client.SendAsync(request2); // (int)response.StatusCode
        string responseBody2 = await response2.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody2);

        var client2 = new HttpClient();
        var request3 = new HttpRequestMessage(
            HttpMethod.Post,
            "https://api-dynamic.chorki.com/v2/auth/verify-otp?country=BD&platform=web&language=en"
        );
        
        request3.Headers.Add("origin", "https://www.chorki.com");
        request3.Headers.Add("referer", "https://www.chorki.com/");
        request3.Headers.Add("accept", "application/json");
        request3.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/139.0.0.0 Safari/537.36");

        var payload2 = new {
            email = "temp.usage.29@gmail.com",
            otp = "5555"
        };
        
        var options2 = new JsonSerializerOptions();
        options2.WriteIndented = true;

        string jsonPayload2 = JsonSerializer.Serialize(payload2, options2);
        request3.Content = new StringContent(jsonPayload2, Encoding.UTF8, "application/json");

        var response3 = await client2.SendAsync(request3);
        string response3Body = await response3.Content.ReadAsStringAsync();
        
        var responseDict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response3Body);
        Console.WriteLine(responseDict?["errors"].GetProperty("otp"));

        // GetString(), GetInt32(), GetBoolean(), GetDouble(), EnumerateArray()

        Console.Write("END!");
    }
}