using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using FrontPizza.ViewModels;
using FrontPizza.JWT;
using PizzaOnline2.BLL.DTOEntities;

namespace FrontPizza.Data
{
    public class AccountService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        public AccountService(
            HttpClient httpClient,
            AuthenticationStateProvider authenticationStateProvider,
            ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }
        public async Task<HttpResponseMessage> CreateUserAsync(UserRegisterViewModel user)
        {
                return await _httpClient.PostAsync("api/account/register", GetStringContentFromObject(user));
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
        public async Task<LoginResult> Login(UserLoginViewModel loginModel)
        {
            var response = await _httpClient.PostAsync("api/account/login", GetStringContentFromObject(loginModel));

            using var responseContent = await response.Content.ReadAsStreamAsync();
            var loginResult = await JsonSerializer.DeserializeAsync<LoginResult>(responseContent);
            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }

            await _localStorage.SetItemAsync("authToken", $"{loginResult.token}");

            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginResult.token);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.token);
            return loginResult;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }       
    }
}
