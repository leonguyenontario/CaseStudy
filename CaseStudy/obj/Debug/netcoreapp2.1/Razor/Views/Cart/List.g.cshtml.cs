#pragma checksum "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdbc82063da6aa3032eb476e74c96ea6875e8e5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_List), @"mvc.1.0.view", @"/Views/Cart/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/List.cshtml", typeof(AspNetCore.Views_Cart_List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy;

#line default
#line hidden
#line 2 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Models;

#line default
#line hidden
#line 3 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Utils;

#line default
#line hidden
#line 4 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdbc82063da6aa3032eb476e74c96ea6875e8e5d", @"/Views/Cart/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be391ecc98a96d33b0c2948e08797b31802bbf57", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/vuemodal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cartlist.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 135, true);
            WriteLiteral("<!-- development version, includes helpful console warnings -->\r\n<script src=\"https://cdn.jsdelivr.net/npm/vue/dist/vue.js\"></script>\r\n");
            EndContext();
            BeginContext(222, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c812c86554740fda4f7691f11916e1f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(273, 1035, true);
            WriteLiteral(@"
<div id=""carts"">
    <div class=""mt-5"">
        <div class=""card"">
            <div class=""card-title text-center mt-3"">
                <h3>Past Ordered</h3>
            </div>
            <div class=""card-body"">
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <td>Id</td>
                            <th class=""text-center"">Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr href=""#"" v-for=""cart in carts"" v-on:click=""cartForModal=cart;loadAndShowModal();"">
                            <td>{{cart.id}}</td>
                            <td>{{formatDate(cart.orderDate)}}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <modal v-if=""showModal"" v-on:close=""showModal = false"" :cart=""cartForModal"" :details=""detailsForModal""></modal");
            WriteLiteral(">\r\n</div>\r\n");
            EndContext();
            BeginContext(1308, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "915109479c514a33bf7d7f9e0556510d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1348, 3165, true);
            WriteLiteral(@"
<!-- template for the modal component -->
<script type=""text/x-template"" id=""modal-template"">
    <transition name=""modal"">
        <div class=""modal-mask"">
            <div class=""modal-wrapper"">
                <div class=""modal-container"">
                    <button type=""button"" class=""close"" style=""font-size:xx-large;"" v-on:click=""$emit('close')"">
                        X
                    </button>
                    <div class=""text-center"" style=""font-size:larger;"">
                        <h3>Order:{{cart.id}}</h3>
                        {{formatDate(cart.orderDate)}}<p></p>
                        <img src=""../images/cart.png"" style=""height:60px;width:60px;margin:10px;"" />
                        <ul class=""list-group vuerow"">
                            <li class=""list-group-item vuerow"" style=""background-color:lightgray;"">
                                <span class=""vuecol20 text-center"">Name</span>
                                <span class=""vuecol20 text-center"">MSRP</s");
            WriteLiteral(@"pan>
                                <span class=""vuecol20 text-center"">QtyS</span>
                                <span class=""vuecol20 text-center"">QtyO</span>
                                <span class=""vuecol20 text-center"">QtyB</span>
                                <span class=""vuecol20 text-center"">Extended</span>
                            </li>
                            <li v-for=""detail in details"" class=""list-group-item vuerow"">
                                <span class=""vuecol20 text-center"">{{detail.name}}</span>
                                <span class=""vuecol20 text-center"">{{detail.msrp | toCurrency}}</span>
                                <span class=""vuecol20 text-center"">{{detail.qty}}</span>
                                <span class=""vuecol20 text-center"">{{detail.qtyO}}</span>
                                <span class=""vuecol20 text-center"">{{detail.qtyB}}</span>
                                <span class=""vuecol20 text-center"">{{detail.qty * detail.msrp | toCur");
            WriteLiteral(@"rency}}</span>
                            </li>
                        </ul>
                        <div v-if=""details[0]"" class=""text-right"">
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Sub:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].orderAmount | toCurrency}}</div>
                            </div>
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Tax:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].orderAmount *0.13 | toCurrency}}</div>
                            </div>
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Total:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].orderAmount* 1.13 | toCurrency}}</div>
                            </div>                           
                        </div>
                    </div>");
            WriteLiteral("\n                </div>\r\n            </div>\r\n        </div>\r\n    </transition>\r\n</script>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
