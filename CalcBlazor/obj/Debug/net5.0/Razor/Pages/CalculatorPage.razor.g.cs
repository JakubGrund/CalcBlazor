#pragma checksum "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb8b86840f9accc6ceb3703ff7b9fc852bcd3cb"
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
            __builder.AddMarkupContent(0, "<h1 b-ho0ov4hsra>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "b-ho0ov4hsra");
            __builder.AddContent(3, "Current count: ");
#nullable restore
#line 6 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
__builder.AddContent(4, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-ho0ov4hsra");
            __builder.AddContent(10, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n\r\n   ");
            __builder.AddMarkupContent(12, "<div class=\"container\" b-ho0ov4hsra><div class=\"display\" b-ho0ov4hsra><input id=\"screendisplay\" type=\"text\" placeholder=\"0\" b-ho0ov4hsra></div>\r\n\r\n            <div class=\"buttons\" b-ho0ov4hsra><div class=\"row\" b-ho0ov4hsra><button id=\"ce\" class=\"function\" b-ho0ov4hsra>CE</button>\r\n                    <button class=\"function\" b-ho0ov4hsra>π</button>\r\n                    <button class b-ho0ov4hsra>(</button>\r\n                    <button class b-ho0ov4hsra>)</button>\r\n                    <button class=\"n\" b-ho0ov4hsra>%</button>\r\n                    <button id=\"ac\" class=\"function\" b-ho0ov4hsra>AC</button></div>\r\n\r\n                <div class=\"row\" b-ho0ov4hsra><button class=\"function\" b-ho0ov4hsra>sin</button>\r\n                    <button class=\"function\" b-ho0ov4hsra>ln</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>7</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>8</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>9</button>\r\n                    <button class=\"operator\" b-ho0ov4hsra>÷</button></div>\r\n\r\n                <div class=\"row\" b-ho0ov4hsra><button class=\"function\" b-ho0ov4hsra>cos</button>\r\n                    <button class=\"function\" b-ho0ov4hsra>log</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>4</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>5</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>6</button>\r\n                    <button class=\"operator\" b-ho0ov4hsra> × </button></div>\r\n\r\n                <div class=\"row\" b-ho0ov4hsra><button class=\"function\" b-ho0ov4hsra>tan</button>\r\n                    <button class=\"function\" b-ho0ov4hsra>√</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>1</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>2</button>\r\n                    <button class=\"value\" b-ho0ov4hsra>3</button>\r\n                    <button class=\"operator\" b-ho0ov4hsra>-</button></div>\r\n\r\n                <div class=\"row\" b-ho0ov4hsra><button class=\"function\" b-ho0ov4hsra>e</button>\r\n                    <button class=\"function\" b-ho0ov4hsra>x <span style=\"position: relative; bottom: .4em; right: .1em;\" b-ho0ov4hsra>y</span></button>\r\n                    <button class=\"value\" b-ho0ov4hsra>0</button>\r\n                    <button class b-ho0ov4hsra>.</button>\r\n                    <button id=\"eval\" class=\"operator\" b-ho0ov4hsra>=</button>\r\n                    <button class=\"operator\" b-ho0ov4hsra>+</button></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Jakub\Desktop\CalcBlazor\CalcBlazor\Pages\CalculatorPage.razor"
       

    /*Ukazka*/
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
