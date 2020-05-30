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
            var response = await _httpClient.GetAsync($"api/pizza?pageNumber={parameters.PageNumber}&pageSize={parameters.PageSize}");
            response.EnsureSuccessStatusCode();

            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await System.Text.Json.JsonSerializer.DeserializeAsync<List<PizzaViewModel>>(responseContent);
        }



        public async Task<HttpResponseMessage> SavePizza(PizzaViewModel pizza)
        {
            string token = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            return await _httpClient.PostAsync("api/pizza/AddPizza", GetStringContentFromObject(pizza));
            //if (pizza == null)
            //{
            //    return pizza;
            //}

            //string serializedPizza = JsonConvert.SerializeObject(pizza);

            //var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/pizza/AddPizza");
            //requestMessage.Content = new StringContent(serializedPizza);

            //requestMessage.Content.Headers.ContentType
            //    = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            //var response = await _httpClient.SendAsync(requestMessage);

            //var responseStatusCode = response.StatusCode;
            //var responseBody = await response.Content.ReadAsStringAsync();

            //var returnedCategory = JsonConvert.DeserializeObject<PizzaViewModel>(responseBody);

            //var res = await Task.FromResult(returnedCategory);
            //return pizza;//$"Category {returnedCategory.ToString()} added";
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = System.Text.Json.JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");

            return stringContent;
        }
    }
}
