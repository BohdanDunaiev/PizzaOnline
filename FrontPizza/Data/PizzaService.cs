using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using FrontPizza.ViewModels;

namespace FrontPizza.Data
{
    public class PizzaService
    {
        public HttpClient _httpClient;
        public PizzaService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<PizzaViewModel>> GetPizzaAsync()
        {
            var response = await _httpClient.GetAsync("api/pizza");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<PizzaViewModel>>(responseContent);
        }        
    }
}
