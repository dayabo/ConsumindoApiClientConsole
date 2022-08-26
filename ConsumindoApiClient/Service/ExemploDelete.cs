using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiClient.Service
{
    static class ExemploDelete
    {
        public static void Delete()
        {
            Console.WriteLine("Exemplo utilização http cliente - verbo DELETE dummy api");

            using var client = new HttpClient();

            var request = new HttpRequestMessage(
               HttpMethod.Delete,
               "https://dummy.restapiexample.com/api/v1/delete/2"
               );

            Console.WriteLine("-- Requisição DELETE");
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