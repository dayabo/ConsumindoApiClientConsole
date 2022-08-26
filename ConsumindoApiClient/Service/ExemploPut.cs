
using System.Text;
using System.Text.Json;


namespace ConsumindoApiClient.Service
{
    static class ExemploPut
    {
        public static void Put()
        {
            Console.WriteLine("Exemplo utilização http cliente - verbo PUT dummy api");

            using var client = new HttpClient();

            var json = JsonSerializer.Serialize(
                new

                {
                    name = "Dayane Barros",
                    salary = "1300",
                    age = 29
                });
            var request = new HttpRequestMessage(
                HttpMethod.Put,
                "http://dummy.restapiexample.com/api/v1/update/21")
            {
                Headers =
                {
                    { "Accept","application/json" }
                },

                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
                using var response = client.Send(request);

            Console.WriteLine("-- Requisição PUT");
            Console.WriteLine();
            Console.WriteLine($"Retorno: ");
            Console.WriteLine();
            Console.WriteLine($"Status Code: {response.StatusCode}");
            Console.WriteLine();
            Console.WriteLine($"Body: {response.Content.ReadAsStringAsync().Result}");
            Console.WriteLine();
            Console.WriteLine($"Headers: {string.Join(',', response.Headers.Select(h => $"{h.Key}={string.Join(',', h.Value)}"))}");
            Console.WriteLine();
        
        }
    }
}
