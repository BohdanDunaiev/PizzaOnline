#pragma checksum "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6be75e0e3138f014c4001935583a14b0eb2fdb2a"
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
#line 1 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pizza/{id}")]
    public partial class PizzaId : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
 if (pizza == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "\"");
            __builder.AddContent(3, 
#nullable restore
#line 11 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
         L["Downloads"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, "...\"");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 12 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "body");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "info1");
            __builder.AddContent(11, 
#nullable restore
#line 16 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                            pizza.namePizza

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "tools");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "imga");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 18 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                         pizza.image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "column");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "info2");
            __builder.AddAttribute(26, "style", "font-size: 15pt;\t");
            __builder.AddContent(27, 
#nullable restore
#line 22 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                                                 L["Price"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "cina");
            __builder.AddContent(32, 
#nullable restore
#line 23 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                   pizza.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, " $");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                <br><br>\r\n                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "info2");
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.AddContent(38, 
#nullable restore
#line 26 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Ingradients"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, ":\r\n                        <br>\r\n                        ");
            __builder.AddContent(40, 
#nullable restore
#line 28 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Dough"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, ": ");
            __builder.AddContent(42, 
#nullable restore
#line 28 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                      ingradients.dough

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "<br>\r\n                        ");
            __builder.AddContent(44, 
#nullable restore
#line 29 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Tomate"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(45, ": ");
            __builder.AddContent(46, 
#nullable restore
#line 29 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                       ingradients.tomate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(47, "<br>\r\n                        ");
            __builder.AddContent(48, 
#nullable restore
#line 30 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Meet"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, ": ");
            __builder.AddContent(50, 
#nullable restore
#line 30 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                     ingradients.meet

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "<br>\r\n                        ");
            __builder.AddContent(52, 
#nullable restore
#line 31 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Cheese"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, ": ");
            __builder.AddContent(54, 
#nullable restore
#line 31 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                       ingradients.cheese

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(55, "<br>\r\n                        ");
            __builder.AddContent(56, 
#nullable restore
#line 32 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Sous"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, ": ");
            __builder.AddContent(58, 
#nullable restore
#line 32 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                     ingradients.sous

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(59, "<br>\r\n                        ");
            __builder.AddContent(60, 
#nullable restore
#line 33 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Additionally"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, ": ");
            __builder.AddContent(62, 
#nullable restore
#line 33 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                             ingradients.additionally

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "<br>\r\n                        ");
            __builder.AddContent(64, 
#nullable restore
#line 34 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                         L["Size"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, ": ");
            __builder.AddContent(66, 
#nullable restore
#line 34 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                     pizza.size

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                <br><br>\r\n                ");
            __builder.OpenElement(69, "a");
            __builder.AddAttribute(70, "class", "buy");
            __builder.OpenElement(71, "div");
            __builder.AddContent(72, 
#nullable restore
#line 37 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                     L["Order"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                <br>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "column1");
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "info1");
            __builder.AddContent(80, 
#nullable restore
#line 41 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
                                    L["Our address"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(81, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.AddMarkupContent(83, @"<div class=""map""><iframe width=""400"" height=""320"" src=""https://maps.google.com/maps?width=600&amp;height=320&amp;hl=en&amp;q=%D0%A7%D0%B5%D1%80%D0%BD%D1%96%D0%B2%D1%86%D1%96%2C%20%D0%A3%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D0%B0%2C%205%20%D0%B3%D1%83%D1%80%D1%82%D0%BE%D0%B6%D0%B8%D1%82%D0%BE%D0%BA%20%D0%A7%D0%9D%D0%A3+(%D0%9D%D0%B0%D0%B7%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5)&amp;ie=UTF8&amp;t=&amp;z=10&amp;iwloc=B&amp;output=embed"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""></iframe></div>
                ");
            __builder.AddMarkupContent(84, "<div class=\"info2\">м. Чернівці, вул. Небесної Сотні 4Б Гуртожиток #5 ЧНУ ім. Ю. Федьковича</div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
            __builder.AddContent(88, "    ");
            __builder.AddMarkupContent(89, "<style>\r\n        body {\r\n            background: url(pizza_images/background.png) no-repeat fixed;\r\n        }\r\n\r\n        .info1 {\r\n            font-family: URW Chancery L, cursive;\r\n            font-size: 18pt;\r\n            text-shadow: 2px 2px 10px #757575;\r\n            width: 300px;\r\n            margin-top: 3%;\r\n            margin-left: 1%;\r\n            clear: both;\r\n        }\r\n\r\n        .info2 {\r\n            font-family: URW Chancery L, cursive;\r\n            margin-top: 3%;\r\n            width: 250px;\r\n            font-size: 12pt;\r\n            margin-left: 50px;\r\n            clear: both;\r\n        }\r\n\r\n        .column {\r\n            display: flex;\r\n            flex-direction: column;\r\n        }\r\n\r\n\r\n\r\n        .map {\r\n            margin-top: 3%;\r\n            overflow: hidden;\r\n            width: 375px;\r\n            margin-left: 3%;\r\n        }\r\n\r\n        .imga img {\r\n            float: left;\r\n            margin-top: 20px;\r\n            margin-left: 2%;\r\n            cursor: pointer;\r\n            transition: 0.3s linear;\r\n        }\r\n\r\n            .imga img:hover {\r\n                -webkit-transform: scale(1.1);\r\n                transform: scale(1.1);\r\n            }\r\n\r\n        .cina {\r\n            background-color: #0094ff;\r\n            width: 135px;\r\n            height: 6%;\r\n            margin-left: 6%;\r\n            margin-top: 4%;\r\n            padding: 5px;\r\n            text-align: center;\r\n            font-family: URW Chancery L, cursive;\r\n        }\r\n\r\n        .buy {\r\n            background-color: #ffd800;\r\n            width: 30%;\r\n            height: 30px;\r\n            margin-left: 6%;\r\n            padding: 5px;\r\n            font-family: URW Chancery L, cursive;\r\n            text-align: center;\r\n            color: white;\r\n            cursor: pointer;\r\n            transition: 0.2s linear;\r\n        }\r\n\r\n            .buy :hover {\r\n                color: black;\r\n                transition: 0.4s linear;\r\n            }\r\n\r\n        .column1 {\r\n            background-color: white;\r\n            border-radius: 25px;\r\n            border: 1px solid black;\r\n            width: 425px;\r\n            display: flex;\r\n            flex-direction: column;\r\n        }\r\n    </style>\r\n");
#nullable restore
#line 137 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 139 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
       
    PizzaViewModel pizza;
    IngradientsViewModel ingradients;
    string image;
    [Parameter]
    public string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        pizza = await pizzaService.GetPizzaById(Convert.ToInt32(Id));
        image = pizza.image;
        ingradients = await ingredientService.GetByIdIngredients(pizza.ingredientsId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<PizzaId> L { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.IngrefientsService ingredientService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.PizzaService pizzaService { get; set; }
    }
}
#pragma warning restore 1591
