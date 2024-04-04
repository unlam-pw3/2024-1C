using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public static class ApiHelper
{
    private static readonly HttpClient client = new HttpClient();
    private static readonly string baseUrl = "https://localhost:7133";

    public static async Task<string> MakeApiRequest(string endpoint, HttpMethod method, object requestData = null)
    {
        try
        {
            string requestUrl = baseUrl + endpoint;

            var request = new HttpRequestMessage(method, requestUrl);

            if (requestData != null)
            {
                string json = JsonSerializer.Serialize(requestData);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Error en la solicitud HTTP: {e.Message}");
            throw;
        }
    }
}
