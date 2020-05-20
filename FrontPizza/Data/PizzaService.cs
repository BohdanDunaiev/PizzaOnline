using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using FrontPizza.ViewModels;
using PizzaOnline.DAL.Models;

namespace FrontPizza.Data
{
    public class PizzaService
    {
        public HttpClient _httpClient;
        public PizzaService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<PizzaViewModel>> GetPizzaAsync(PizzaQueryParameters parameters)
        {
            var response = await _httpClient.GetAsync($"api/pizza?pageNumber={parameters.PageNumber}&pageSize={parameters.PageSize}");
            response.EnsureSuccessStatusCode();

            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<PizzaViewModel>>(responseContent);
        }        
    }
}
