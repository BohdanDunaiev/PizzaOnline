#pragma checksum "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "111ff33fb30b59d66eb22eaab8800d9053d77108"
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
#line 2 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
using PizzaOnline.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
using FrontPizza.Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pizza/add")]
    public partial class PizzaAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>Pizza Add</b></h3>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                      pizzaViewModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                                       SavePizza

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<FrontPizza.Validation.FluentValidator<PizzaValidator>>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-12 row");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<label class=\"col-2 font-weight-bold\">Name Pizza :</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "placeholder", "Name Pizza");
                __builder2.AddAttribute(14, "class", "form-control col-3");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                                                                        pizzaViewModels.namePizza

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pizzaViewModels.namePizza = __value, pizzaViewModels.namePizza))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pizzaViewModels.namePizza));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.FrontPizza.Pages.Pizza.PizzaAdd.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 20 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                    () => pizzaViewModels.namePizza

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-12 row");
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.AddMarkupContent(26, "<label class=\"col-2 font-weight-bold\">Size :</label>\r\n            ");
                __Blazor.FrontPizza.Pages.Pizza.PizzaAdd.TypeInference.CreateInputNumber_1(__builder2, 27, 28, "form-control col-3", 29, 
#nullable restore
#line 25 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                                                 pizzaViewModels.size

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pizzaViewModels.size = __value, pizzaViewModels.size)), 31, () => pizzaViewModels.size);
                __builder2.AddMarkupContent(32, "\r\n            ");
                __Blazor.FrontPizza.Pages.Pizza.PizzaAdd.TypeInference.CreateValidationMessage_2(__builder2, 33, 34, 
#nullable restore
#line 26 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                    () => pizzaViewModels.size

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-12 row");
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.AddMarkupContent(40, "<label class=\"col-2 font-weight-bold\">Price :</label>\r\n            ");
                __Blazor.FrontPizza.Pages.Pizza.PizzaAdd.TypeInference.CreateInputNumber_3(__builder2, 41, 42, "form-control col-3", 43, 
#nullable restore
#line 31 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                                                 pizzaViewModels.price

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pizzaViewModels.price = __value, pizzaViewModels.price)), 45, () => pizzaViewModels.price);
                __builder2.AddMarkupContent(46, "\r\n            ");
                __Blazor.FrontPizza.Pages.Pizza.PizzaAdd.TypeInference.CreateValidationMessage_4(__builder2, 47, 48, 
#nullable restore
#line 32 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                    () => pizzaViewModels.price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-12 row");
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.AddMarkupContent(54, "<label class=\"col-2 font-weight-bold\">IngredientsId :</label>\r\n            ");
                __Blazor.FrontPizza.Pages.Pizza.PizzaAdd.TypeInference.CreateInputNumber_5(__builder2, 55, 56, "form-control col-3", 57, 
#nullable restore
#line 36 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                                                 pizzaViewModels.ingredientsId

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pizzaViewModels.ingredientsId = __value, pizzaViewModels.ingredientsId)), 59, () => pizzaViewModels.ingredientsId);
                __builder2.AddMarkupContent(60, "\r\n            ");
                __Blazor.FrontPizza.Pages.Pizza.PizzaAdd.TypeInference.CreateValidationMessage_6(__builder2, 61, 62, 
#nullable restore
#line 37 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                                    () => pizzaViewModels.ingredientsId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        <br>\r\n        ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(65);
                __builder2.AddAttribute(66, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 40 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                             HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 41 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
         if (file != null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(68, "            ");
                __builder2.OpenElement(69, "p");
                __builder2.AddContent(70, "Dowland file : ");
                __builder2.AddContent(71, 
#nullable restore
#line 43 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
                               file.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n");
#nullable restore
#line 44 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(73, "        <br>\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(74, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n        ");
                __builder2.AddMarkupContent(75, "<a class=\"btn btn-primary\" href=\"/pizza\">View pizza</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaAdd.razor"
           
        public PizzaViewModel pizzaViewModels { get; set; } = new PizzaViewModel();
        IFileListEntry file;

        public string Error { get; set; }

        void HandleFileSelected(IFileListEntry[] files)
        {
            file = files.FirstOrDefault();
        }

        protected async Task SavePizza()
        {
            Error = "";
            try
            {
                string Image;
                if (file == null)
                    throw new Exception("File not found");
                if (file.Type != "image/jpeg")
                    throw new Exception("File in the wrong format! Please use .jpg");

                Image = await AddFile(file);
                pizzaViewModels.image = Image;

                var result = await pizzaService.SavePizza(pizzaViewModels);
                if (!result.IsSuccessStatusCode)
                    throw new Exception(result.StatusCode.ToString());
                ClearFields();
            }
            catch (Exception e)
            {
                Error = e.Message;
            }
        }
        protected void ClearFields()
        {
            pizzaViewModels.namePizza = "";
            pizzaViewModels.ingredientsId = 0;
            pizzaViewModels.size = 0;
            pizzaViewModels.price = 0;
            file = null;
        }
        protected async Task<string> AddFile(IFileListEntry uploadedFile)
        {
            if (uploadedFile != null)
            {
                var newFile = await uploadedFile.ToImageFileAsync("image/jpeg", 1280, 720); ;

                var date = DateTime.Now;
                string path = "/pizza_images/"
                    + $"{date.Year}_{date.Month}_{date.Day}_{date.Hour}_{date.Minute}_{date.Second}_"
                    + newFile.Name;

                using (var filestream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await newFile.Data.CopyToAsync(filestream);
                }

                return path;
            }
            else
                return null;
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.PizzaService pizzaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment _appEnvironment { get; set; }
    }
}
namespace __Blazor.FrontPizza.Pages.Pizza.PizzaAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
