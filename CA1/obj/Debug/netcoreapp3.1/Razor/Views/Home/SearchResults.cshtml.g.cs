#pragma checksum "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c37c5247fdbf509a16a40ae759bd9926e3a6d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResults), @"mvc.1.0.view", @"/Views/Home/SearchResults.cshtml")]
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
#nullable restore
#line 1 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\_ViewImports.cshtml"
using CA1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\_ViewImports.cshtml"
using CA1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c37c5247fdbf509a16a40ae759bd9926e3a6d35", @"/Views/Home/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dfde0607e7026477d73c5666b1d4060ef7f1c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/product/search.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/shoppingcart/AddToCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
  
    ViewData["Title"] = "Search Results";
    List<Product> products = (List<Product>)ViewData["products"];

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c37c5247fdbf509a16a40ae759bd9926e3a6d354224", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c37c5247fdbf509a16a40ae759bd9926e3a6d355323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<style>
    table {
        width: 100%;
        margin: auto;
        font-family: Comic Sans MS;
    }

    td {
        width: 400px;
    }

    .name {
        text-align: center
    }

    .button {
        background-color: #D3CCCC;
    }

    .badge {
        font-size: 14px !important;
    }

    .img_container {
        position: relative;
    }

    .search {
        text-align: right
    }

    .badge_container {
        position: absolute;
        left: 10px;
        bottom: 10px;
        opacity: 0.7;
    }
</style>

<table>
");
#nullable restore
#line 51 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
     for (int i = 0; i < products.Count; i += 3)
    {
        int j;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 56 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (j = 0; j < 3 && i + j < products.Count; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n");
#nullable restore
#line 59 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
                       string url = products[i + j].PhotoLink; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"img_container\">\r\n                        <img");
            BeginWriteAttribute("src", " src=", 1172, "", 1181, 1);
#nullable restore
#line 61 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
WriteAttributeValue("", 1177, url, 1177, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"350\" height=\"235\" />\r\n\r\n\r\n                    </div>\r\n                </td>\r\n");
#nullable restore
#line 66 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (; j < 3; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 70 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 75 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (j = 0; j < 3 && i + j < products.Count; j++)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <th class=\"name\">\r\n");
#nullable restore
#line 79 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
                       string name = products[i + j].ProductName;

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\r\n");
#nullable restore
#line 83 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (; j < 3; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 87 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 91 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (j = 0; j < 3 && i + j < products.Count; j++)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n");
#nullable restore
#line 95 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
                       string information = products[i + j].Description;

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
                   Write(information);

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n");
#nullable restore
#line 99 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (; j < 3; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 103 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 107 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (j = 0; j < 3 && i + j < products.Count; j++)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"name\">\r\n");
#nullable restore
#line 111 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
                       string price = products[i + j].Price.ToString("0.00"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button class=\"add_button\"");
            BeginWriteAttribute("productId", " productId=", 2692, "", 2720, 1);
#nullable restore
#line 113 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
WriteAttributeValue("", 2703, products[i+j].Id, 2703, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">$");
#nullable restore
#line 113 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
                                                                       Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>Add To Cart</button>\r\n\r\n                </td>\r\n");
#nullable restore
#line 116 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
             for (; j < 3; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 120 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
            WriteLiteral("        <tr>\r\n            <td colspan=\"3\"><hr /></td>\r\n        </tr>\r\n");
#nullable restore
#line 127 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Home\SearchResults.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
