using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using FrontPizza.ViewModels;
using PizzaOnline.DAL.Models;
using Newtonsoft.Json;
using Blazored.LocalStorage;
using System.Text;

namespace FrontPizza.Data
{
    public class PizzaService
    {
        public HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        public PizzaService(HttpClient client, ILocalStorageService localStorage)
        {
            _httpClient = client;
            _localStorage = localStorage;
        }
        public async Task<List<PizzaViewModel>> GetPizzaAsync(PizzaQueryParameters parameters)
        {
            var response = await _httpClient.GetAsync($"api/pizza?PageSize={parameters.PageSize}&PageNumber={parameters.PageNumber}&MinPrice={parameters.MinPrice}&NamePizza={parameters.NamePizza}&MaxPrice={parameters.MaxPrice}&OrderBy={parameters.OrderBy}");
            response.EnsureSuccessStatusCode();

            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await System.Text.Json.JsonSerializer.DeserializeAsync<List<PizzaViewModel>>(responseContent);
        }
        public async Task<PizzaViewModel> GetPizzaById(int id)
        {
            var response = await _httpClient.GetAsync($"api/pizza/{id}");
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await System.Text.Json.JsonSerializer.DeserializeAsync<PizzaViewModel>(responseContent);
        }
        public async Task<HttpResponseMessage> SavePizza(PizzaViewModel pizza)
        {
            string token = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            return await _httpClient.PostAsync("api/pizza", GetStringContentFromObject(pizza));           
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = System.Text.Json.JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");

            return stringContent;
        }
        public async Task<int> GetPizzaCountAsync(PizzaQueryParameters parameters)
        {
            var respone = await _httpClient.GetAsync($"api/pizza/count?minprice={parameters.MinPrice}&NamePizza={parameters.NamePizza}&MaxPrice={parameters.MaxPrice}");
            if (!respone.IsSuccessStatusCode)
                return 0;
            else
                return Int32.Parse(await respone.Content.ReadAsStringAsync());
        }
    }
}
