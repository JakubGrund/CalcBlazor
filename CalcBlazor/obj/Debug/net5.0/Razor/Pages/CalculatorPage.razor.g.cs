#pragma checksum "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7acc60dca0d4e208e23ecfe8de49797a4f61b026"
// <auto-generated/>
#pragma warning disable 1591
namespace CalcBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using CalcBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\_Imports.razor"
using CalcBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class CalculatorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-ho0ov4hsra>Scientific calculator</h1>\r\n\r\n\r\n\r\n   ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-ho0ov4hsra");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "display");
            __builder.AddAttribute(6, "b-ho0ov4hsra");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "id", "screendisplay");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "placeholder", "0");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                              Result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Result = __value, Result));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(13, "b-ho0ov4hsra");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "buttons");
            __builder.AddAttribute(17, "b-ho0ov4hsra");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "simply");
            __builder.AddAttribute(20, "b-ho0ov4hsra");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.AddAttribute(23, "b-ho0ov4hsra");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btnspace");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                           ClearSpaceBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "b-ho0ov4hsra");
            __builder.AddMarkupContent(28, "???");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "id", "ce");
            __builder.AddAttribute(32, "class", "btnclear");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                                  Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "b-ho0ov4hsra");
            __builder.AddContent(35, "CE");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btnclear");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                           Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "b-ho0ov4hsra");
            __builder.AddContent(41, "C");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.AddMarkupContent(43, "<button class=\"btnplusminus\" b-ho0ov4hsra>??</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row");
            __builder.AddAttribute(47, "b-ho0ov4hsra");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "value");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("7")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "b-ho0ov4hsra");
            __builder.AddContent(52, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "value");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("8")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "b-ho0ov4hsra");
            __builder.AddContent(58, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "class", "value");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("9")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "b-ho0ov4hsra");
            __builder.AddContent(64, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.AddMarkupContent(66, "<button class=\"operator\" b-ho0ov4hsra>??</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                     ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "row");
            __builder.AddAttribute(70, "b-ho0ov4hsra");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "value");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("4")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "b-ho0ov4hsra");
            __builder.AddContent(75, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "value");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("5")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "b-ho0ov4hsra");
            __builder.AddContent(81, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "value");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("6")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "b-ho0ov4hsra");
            __builder.AddContent(87, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddMarkupContent(89, "<button class=\"operator\" b-ho0ov4hsra> ?? </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "row");
            __builder.AddAttribute(93, "b-ho0ov4hsra");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "value");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("1")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "b-ho0ov4hsra");
            __builder.AddContent(98, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "class", "value");
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("2")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "b-ho0ov4hsra");
            __builder.AddContent(104, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "class", "value");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("3")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "b-ho0ov4hsra");
            __builder.AddContent(110, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.AddMarkupContent(112, "<button class=\"operator\" b-ho0ov4hsra>-</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "row");
            __builder.AddAttribute(116, "b-ho0ov4hsra");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "value");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number("0")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "b-ho0ov4hsra");
            __builder.AddContent(121, "0");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.OpenElement(123, "button");
            __builder.AddAttribute(124, "class", "value");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                                          e => Number(".")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "b-ho0ov4hsra");
            __builder.AddContent(127, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                        ");
            __builder.AddMarkupContent(129, "<button id=\"eval\" class=\"btnresult\" b-ho0ov4hsra>=</button>\r\n                        ");
            __builder.AddMarkupContent(130, "<button class=\"operator\" b-ho0ov4hsra>+</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "   \r\n                ");
            __builder.AddMarkupContent(132, @"<div class=""scientic"" b-ho0ov4hsra><div class=""row"" b-ho0ov4hsra><button class=""btnlog"" b-ho0ov4hsra>log</button>
                        <button class=""btnx2"" b-ho0ov4hsra>x^2</button></div>
                    <div class=""row"" b-ho0ov4hsra><button class=""btncos"" b-ho0ov4hsra>cos</button>
                        <button class=""btnx3"" b-ho0ov4hsra>x^3</button></div>
                    <div class=""row"" b-ho0ov4hsra><button class=""btnsinn"" b-ho0ov4hsra>sin</button>
                        <button class=""btnlnx"" b-ho0ov4hsra>ln</button></div> 
                     <div class=""row"" b-ho0ov4hsra><button class=""btntan"" b-ho0ov4hsra>tan</button>
                        <button class=""btn1x"" b-ho0ov4hsra>1/x</button></div>   
                    <div class=""row"" b-ho0ov4hsra><button class=""btnpi"" b-ho0ov4hsra>??</button>
                         <button class=""btnpercentage"" b-ho0ov4hsra>%</button></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
       

        /*RESULT DISPLAY*/

         public string Result { get; set; }

            private double _secondnumber;
            private double _firstnumber;
            private string _operand;

        /*BUTTONS COMPONENTS*/

        // vypsani cisla na display

         public void Number(string n)
         {
            Result += n;
         }

        // button clear and cler all

        public void Clear()
        {
            Result = "";
        }

        // button clear space back 

        public void ClearSpaceBack()
        {
            if (Result.Length > 0)
            {
                Result = Result.Substring(0, Result.Length - 1);
            }
            if (Result.Length < 1)
            {
                Result = " ";
            }
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
