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
        }

        public async Task<UserResponse> GetUser(int id)
        {
            var response = await _httpClient.GetAsync($"users/{id}");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<UserResponse>();
        }
    }
}