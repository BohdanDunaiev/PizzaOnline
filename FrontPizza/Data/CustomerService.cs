using Blazored.LocalStorage;
using FrontPizza.ViewModels;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FrontPizza.Data
{
    public class CustomerService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        public CustomerService(HttpClient client, ILocalStorageService localStorage)
        {
            _httpClient = client;
            _localStorage = localStorage;
        }
        public async Task<CustomerViewModel> GetCustomerByIdAsync(int id)
        {
            string token = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync($"api/customer/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<CustomerViewModel>(responseContent);
        }
        public async Task<HttpResponseMessage> UpdateCustomerAsync(CustomerViewModel customer)
        {
            string token = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            return await _httpClient.PutAsync($"api/customer", GetStringContentFromObject(customer));
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
