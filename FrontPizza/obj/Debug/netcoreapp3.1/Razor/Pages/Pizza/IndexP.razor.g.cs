#pragma checksum "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff1eeac72bef1ef7738b6771cb0a98e8f9f1f8c6"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontPizza.Pages.Pizza
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using PizzaOnline.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pizza")]
    public partial class IndexP : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Pizza</h3>\r\n");
#nullable restore
#line 9 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
 if (pizza == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>NamePizza</th>\r\n                <th>Size</th>\r\n                <th>Price</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 25 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
             foreach (var pizza in pizza)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 28 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                         pizza.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 29 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                         pizza.namePizza

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 30 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                         pizza.size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 31 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                         pizza.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 33 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                      PrevPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Prev");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "span");
            __builder.AddContent(34, 
#nullable restore
#line 37 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
           pageNum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                      NextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 39 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Василь\Desktop\Pizza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
       
    List<PizzaViewModel> pizza;
    private int pageNum = 1;
    private int pageSize = 2;
    protected override async Task OnInitializedAsync()
    {
        pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageSize = pageSize, PageNumber = pageNum });

    }
    public async Task NextPage()
    {
        pageNum++;
        pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageNumber = pageNum, PageSize = pageSize });
    }
    public async Task PrevPage()
    {
        if (pageNum > 1)
        {
            pageNum--;
            pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageNumber = pageNum, PageSize = pageSize });
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.PizzaService pizzaService { get; set; }
    }
}
#pragma warning restore 1591
