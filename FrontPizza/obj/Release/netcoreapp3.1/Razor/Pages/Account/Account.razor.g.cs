#pragma checksum "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9246c9e2bd4fb75df9a9816ee07c8de4247a251"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontPizza.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
 if (customer != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3>[\"Account\"]</h3>\r\n    <hr>\r\n    ");
            __builder.AddMarkupContent(2, @"<style>
        img {
            height: 150px;
            width: 150px;
            border-radius: 50%;
        }

        .headBlock {
            display: flex;
            align-items: center;
            width: auto;
        }

            .headBlock > h3 {
                margin: 20px;
                width: auto;
            }

        .dataBlock {
            background-color: rgb(248,248,248);
            padding: 10px;
            border-radius: 20px;
            width: auto;
        }
    </style>
    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "dataBlock");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "headBlock");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 36 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
             if (base64string == null || string.IsNullOrEmpty(base64string) || customer.photo == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "                <img src=\"/default_images/defaultUser.jpg\">\r\n");
#nullable restore
#line 39 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", "data:image/jpeg;base64," + (
#nullable restore
#line 42 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                                  base64string

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 43 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "h3");
            __builder.AddContent(16, 
#nullable restore
#line 45 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                 Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(19, "<a href=\"/myaccount/photo\" class=\"btn btn-sm btn-primary\">[\"Change photo\"]</a>\r\n        <br>\r\n        <br>\r\n        <hr>\r\n\r\n        ");
            __builder.AddMarkupContent(20, "<h4>[\"Personal information\"] :</h4>\r\n        ");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "<b>[\"Last name\"]: </b>");
            __builder.AddContent(23, 
#nullable restore
#line 54 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                  customer.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "<b>[\"First name\"]: </b>");
            __builder.AddContent(27, 
#nullable restore
#line 55 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                   customer.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "p");
            __builder.AddMarkupContent(30, "<b>[\"Second name\"]: </b>");
            __builder.AddContent(31, 
#nullable restore
#line 56 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                    customer.secondName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "p");
            __builder.AddMarkupContent(34, "<b>[\"Address\"]: </b>");
            __builder.AddContent(35, 
#nullable restore
#line 57 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                customer.adress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "p");
            __builder.AddMarkupContent(38, "<b>[\"Phone number\"]: </b>");
            __builder.AddContent(39, 
#nullable restore
#line 58 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                     customer.phoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, "<a class=\"btn btn-primary\" href=\"/myaccount/modify\">[\"Modify\"]</a>\r\n        <br>\r\n        <br>\r\n        <hr>\r\n\r\n        ");
            __builder.AddMarkupContent(42, "<h4>[\"Account information\"]:</h4>\r\n        ");
            __builder.OpenElement(43, "p");
            __builder.AddMarkupContent(44, "<b>[\"Username\"]: </b>");
            __builder.AddContent(45, 
#nullable restore
#line 65 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                 Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "p");
            __builder.AddMarkupContent(48, "<b>[\"Email\"]: </b>");
            __builder.AddContent(49, 
#nullable restore
#line 66 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                              Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<a class=\"btn btn-primary\" href=\"/myaccount/changePassword\">[\"Change password\"]</a>\r\n        <br>\r\n        <br>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 72 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
       
    CustomerViewModel customer { get; set; } = new CustomerViewModel();
    string Username { get; set; }
    string Email { get; set; }
    string base64string = null;
    protected override async Task OnInitializedAsync()
    {
        var authState = await authentificationStateProvider.GetAuthenticationStateAsync();
        var clientId = authState.User.Claims.First(x => x.Type == "customerId").Value;
        Username = authState.User.Identity.Name;
        Email = authState.User.Claims.First(x => x.Type == "email").Value;
        customer = await customerService.GetClientsByIdAsync(Int32.Parse(clientId));
        base64string = Convert.ToBase64String(customer.photo);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentificationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FrontPizza.Data.CustomerService customerService { get; set; }
    }
}
#pragma warning restore 1591