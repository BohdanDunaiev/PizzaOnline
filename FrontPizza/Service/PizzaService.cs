using PizzaOnline.BLL.DTOEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaOnlineFront.Service
{
    public class PizzaService
    {
        public HttpClient _httpClient;
        public PizzaService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<DTOPizza>> GetPizzaAsync()
        {
            var res = await _httpClient.GetAsync("api/pizza");
            res.EnsureSuccessStatusCode();

            using var responseContent = await res.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<DTOPizza>>(responseContent);
        }
    }
}
