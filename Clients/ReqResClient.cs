using reqresApiTests.Models;
using System;

using System.Net.Http;
using System.Net.Http.Json;

namespace reqresApiTests.Clients
{
    public class ReqResClient
    {
        private readonly HttpClient _httpClient;

        public ReqResClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://reqres.in/api/");
            _httpClient.DefaultRequestHeaders.Add("x-api-key", "pro_e748dd7fd2725b61f8b26eb31e94c5990c4666046ea661492e75d2b747095c2c");
        
        }

        public async Task<UserResponse> GetUser(int id)
        {
            var response = await _httpClient.GetAsync($"users/{id}");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<UserResponse>();

            if (result == null)
                throw new Exception("La respuesta fue null o no se pudo deserializar");

            return result;
        }
    }
}