#pragma checksum "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678e6389e5bef92877f783f96c20403776d1fc7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_History_Index), @"mvc.1.0.view", @"/Views/History/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678e6389e5bef92877f783f96c20403776d1fc7e", @"/Views/History/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dfde0607e7026477d73c5666b1d4060ef7f1c4", @"/Views/_ViewImports.cshtml")]
    public class Views_History_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
  
    List<OrderDetail> orderDetails = (List<OrderDetail>)ViewData["OrderDetails"];
    List<Order> orders = (List<Order>)ViewData["Order"];
    List<Product> products = (List<Product>)ViewData["Products"];

    var iter = from eachorder in orderDetails
               group eachorder by eachorder.ProductId;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    /*body {
            font-family: Comic Sans MS;
        }*/
    table {
        width: 100%;
        margin: auto;
        font-family: Comic Sans MS;
    }

    td {
        width: 400px;
    }

    .badge {
        font-size: 14px !important;
    }

    .like_icon {
        width: 40px;
        height: 40px;
        position: absolute;
        top: 5px;
        right: 30px;
        cursor: pointer;
    }

    .img_container {
        position: relative;
    }

    .button {
        background-color: #D3CCCC;
    }

    .search {
        text-align: right
    }
</style>

<h1>My Purchase</h1>
<br/>
<br/>

<table>
");
#nullable restore
#line 55 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
     foreach (var type in iter)
    {
        Product product = products.FirstOrDefault(x => x.Id == type.Key);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n\n            <td>\n                <img");
            BeginWriteAttribute("src", " src=", 1111, "", 1134, 1);
#nullable restore
#line 62 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
WriteAttributeValue("", 1116, product.PhotoLink, 1116, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"350\" height=\"235\" />\n            </td>\n            <td>\n                <h4 style=\"font-weight:bold\">");
#nullable restore
#line 65 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
                                        Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></h4>\n                <h6>Activation Code:</h6>\n                <select name=\"Activation Codes\">\n");
#nullable restore
#line 68 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
                     foreach (OrderDetail item in type)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678e6389e5bef92877f783f96c20403776d1fc7e5752", async() => {
#nullable restore
#line 70 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
                                                      Write(item.ActivationCode);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
                          WriteLiteral(item.ActivationCode);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 71 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\n            </td>\n\n        </tr>\n        <tr>\n            <td colspan=\"2\">\n                <br />\n                <hr />\n            </td>\n        </tr>\n");
#nullable restore
#line 82 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\History\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>");
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
