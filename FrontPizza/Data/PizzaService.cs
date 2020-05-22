using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using FrontPizza.ViewModels;
using PizzaOnline.DAL.Models;
using Newtonsoft.Json;

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
            return await System.Text.Json.JsonSerializer.DeserializeAsync<List<PizzaViewModel>>(responseContent);
        }
        public async Task<PizzaViewModel> SavePizza(PizzaViewModel pizza)
        {
            if (pizza == null)
            {
                return pizza;
            }

            string serializedPizza = JsonConvert.SerializeObject(pizza);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/pizza/AddPizza");
            requestMessage.Content = new StringContent(serializedPizza);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedCategory = JsonConvert.DeserializeObject<PizzaViewModel>(responseBody);

            var res = await Task.FromResult(returnedCategory);
            return pizza;//$"Category {returnedCategory.ToString()} added";
        }
    }
}
