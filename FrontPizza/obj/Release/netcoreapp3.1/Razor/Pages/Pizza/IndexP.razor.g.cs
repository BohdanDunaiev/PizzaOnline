#pragma checksum "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d0e3e7aadd585b501a451ea3e0c6c34be66753"
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
#line 1 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using System.Net.Http;

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
#line 13 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using PizzaOnline.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using FrontPizza.Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
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
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 10 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
     L["Pizza"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "button2");
            __builder.AddAttribute(5, "style", "display:block;");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "href", "/");
            __builder.AddContent(10, 
#nullable restore
#line 12 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                         L["Home"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Roles", "admin");
            __builder.AddAttribute(14, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "class", "btn btn-primary");
                __builder2.AddAttribute(18, "href", "pizza/add");
                __builder2.AddContent(19, 
#nullable restore
#line 15 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                         L["Add pizza"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
            }
            ));
            __builder.AddAttribute(21, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "search");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, "<p style=\"margin: 0\">Search :</p>\r\n    ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "placeholder", (
#nullable restore
#line 24 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                          L["Search"]

#line default
#line hidden
#nullable disable
            ) + "...");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                              inpNamePizza

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inpNamePizza = __value, inpNamePizza));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                      Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-sm btn-primary");
            __builder.AddContent(38, 
#nullable restore
#line 25 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                              L["Search"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n<br>\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "page");
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatPaginator>(44);
            __builder.AddAttribute(45, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                           elementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                    pageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Page", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MatBlazor.MatPaginatorPageEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MatBlazor.MatPaginatorPageEvent>(this, 
#nullable restore
#line 29 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                                     OnPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "orderby");
            __builder.AddMarkupContent(52, "\r\n    ");
            __Blazor.FrontPizza.Pages.Pizza.IndexP.TypeInference.CreateMatSelectItem_0(__builder, 53, 54, 
#nullable restore
#line 34 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                  orderByArray

#line default
#line hidden
#nullable disable
            , 55, 
#nullable restore
#line 34 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                 orderBy

#line default
#line hidden
#nullable disable
            , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => orderBy = __value, orderBy)), 57, () => orderBy);
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "price");
            __builder.AddMarkupContent(62, "\r\n\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "style", "width: auto;  padding: 0");
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "p");
            __builder.AddAttribute(67, "style", "margin: 0");
            __builder.AddContent(68, 
#nullable restore
#line 41 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                              L["Price"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, " :");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "number");
            __builder.AddAttribute(73, "min", "0");
            __builder.AddAttribute(74, "max", 
#nullable restore
#line 42 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                           Decimal.MaxValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(75, "step", "0.01");
            __builder.AddAttribute(76, "placeholder", "Min price");
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                                                minPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minPrice = __value, minPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        -\r\n        ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "number");
            __builder.AddAttribute(82, "min", "0");
            __builder.AddAttribute(83, "max", 
#nullable restore
#line 44 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                           Decimal.MaxValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(84, "step", "0.01");
            __builder.AddAttribute(85, "placeholder", "Max price");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                                                maxPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxPrice = __value, maxPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    <br>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n");
#nullable restore
#line 49 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
 if (pizza == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "    ");
            __builder.OpenElement(92, "p");
            __builder.OpenElement(93, "em");
            __builder.AddContent(94, 
#nullable restore
#line 51 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
            L["Loading"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, "...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 52 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "    ");
            __builder.OpenElement(98, "table");
            __builder.AddAttribute(99, "class", "table");
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.OpenElement(101, "thead");
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.OpenElement(103, "tr");
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.OpenElement(105, "th");
            __builder.AddContent(106, 
#nullable restore
#line 58 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                     L["NamePizza"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "th");
            __builder.AddContent(109, 
#nullable restore
#line 59 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                     L["Size"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "th");
            __builder.AddContent(112, 
#nullable restore
#line 60 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                     L["Price"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.OpenElement(116, "tbody");
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 64 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
             foreach (var pizz in pizza)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "                ");
            __builder.OpenElement(119, "tr");
            __builder.AddAttribute(120, "onclick", "location.href=\"pizza/" + (
#nullable restore
#line 66 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                   pizz.id

#line default
#line hidden
#nullable disable
            ) + "\"");
            __builder.AddAttribute(121, "class", "black");
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.OpenElement(123, "td");
            __builder.AddContent(124, 
#nullable restore
#line 67 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                         pizz.namePizza

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                    ");
            __builder.OpenElement(126, "td");
            __builder.AddContent(127, 
#nullable restore
#line 68 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                         pizz.size

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(128, " см");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.OpenElement(130, "td");
            __builder.AddContent(131, 
#nullable restore
#line 69 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                         pizz.price.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(132, " $");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenElement(134, "td");
            __builder.OpenElement(135, "img");
            __builder.AddAttribute(136, "src", 
#nullable restore
#line 70 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                   pizz.image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 72 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 77 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
                                                   

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(142, "\r\n");
            __builder.AddMarkupContent(143, @"<style>
    .black {
        color: black;
        text-decoration: none;
    }
    .search {
        margin-top: -7%;
        margin-left: 81%;
        width: auto;
        padding: 0
    }
    .page {
        margin-right: 71%;
        margin-top: 6%;
        margin-bottom: -16%
    }
    .price {
        display: flex;
        flex-direction: column;
        align-items: flex-end;
        width: 100%;
        padding: 0;
    }
    .orderby {
        display: flex;
        justify-content: flex-end;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
       
    //public PizzaViewModel pizzaViewModels = new PizzaViewModel();
    //public List<PizzaViewModel> pizza;
    //string orderBy;
    //int elementCount = 0;

    //string[] orderByArray = new[]
    //       {
    //            "Price",
    //            "Price desc",
    //            "Brand",
    //            "Brand desc"
    //        };

    //private int pageNum = 1;
    //private int pageSize = 2;
    //protected override async Task OnInitializedAsync()
    //{
    //    pizzaViewModels = new PizzaViewModel();
    //    pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageSize = pageSize, PageNumber = pageNum });
    //}
    //public async Task NextPage()
    //{
    //    pageNum++;
    //    pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageNumber = pageNum, PageSize = pageSize });
    //}
    //public async Task PrevPage()
    //{
    //    if (pageNum > 1)
    //    {
    //        pageNum--;
    //        pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageNumber = pageNum, PageSize = pageSize });
    //    }
    //}
    int pageSize = 25;
    int pageIndex = 0;

    int elementCount = 0;

    string orderBy;
    string inpNamePizza;

    string[] orderByArray = new[]
        {
                "Price",
                "NamePizza"
        };

    decimal minPrice = 0;
    decimal maxPrice = 1000;



    List<PizzaViewModel> pizza;

    protected override async Task OnInitializedAsync()
    {
        PizzaQueryParameters parameters = new PizzaQueryParameters
        {
            PageNumber = pageIndex + 1,
            PageSize = pageSize,
            MaxPrice = 1000,
            MinPrice = 0
        };
        pizza = await pizzaService.GetPizzaAsync(parameters);
        elementCount = await pizzaService.GetPizzaCountAsync(parameters);
    }

    protected async Task OnPage(MatPaginatorPageEvent e)
    {
        pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters
        {
            PageNumber = e.PageIndex + 1,
            PageSize = e.PageSize,
            NamePizza = inpNamePizza,
            MinPrice = minPrice,
            MaxPrice = maxPrice,
            OrderBy = orderBy
        });
        pageSize = e.PageSize;
        pageIndex = e.PageIndex;
    }

    protected async Task Search()
    {
        PizzaQueryParameters parameters = new PizzaQueryParameters
        {
            PageNumber = pageIndex + 1,
            PageSize = pageSize,
            NamePizza = inpNamePizza,
            MinPrice = minPrice,
            MaxPrice = maxPrice,
            OrderBy = orderBy
        };
        pizza = await pizzaService.GetPizzaAsync(parameters);
        elementCount = await pizzaService.GetPizzaCountAsync(parameters);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.PizzaService pizzaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<IndexP> L { get; set; }
    }
}
namespace __Blazor.FrontPizza.Pages.Pizza.IndexP
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSelectItem_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TValue> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
