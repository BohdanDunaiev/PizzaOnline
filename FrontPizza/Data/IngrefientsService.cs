using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FrontPizza.ViewModels;

namespace FrontPizza.Data
{
    public class IngrefientsService
    {
        public HttpClient _httpClient;

        public IngrefientsService(HttpClient httpclient)
        {
            _httpClient = httpclient;
        }
        public async Task<IngradientsViewModel> GetByIdIngredients(int id)
        {
            var response = await _httpClient.GetAsync($"api/ingredient/{id}");
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<IngradientsViewModel>(responseContent);
        }        
    }
}
