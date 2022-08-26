using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiClient.Service
{
    static class ExemploGet
    {
      public static void Get ()
        {
            Console.WriteLine("Exemplo utilização http cliente - verbo GET dummy api");

            using var client = new HttpClient();

            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "https://dummy.restapiexample.com/api/v1/employee/1"
                );

            Console.WriteLine("-- Requisição GET");
            Console.WriteLine();
            using var response = client.Send(request);

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
