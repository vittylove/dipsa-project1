#pragma checksum "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f643463195206414ee7430536249a8e531486f81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f643463195206414ee7430536249a8e531486f81", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dfde0607e7026477d73c5666b1d4060ef7f1c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Register/SaveToDatabase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Register\Index.cshtml"
  
    ViewData["Registering"] = "menu_hilite";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        window.onload = function () {
            let form = document.getElementById(""form"");
            let errDiv = document.getElementById(""err_msg"");
            form.onsubmit = function () {
                //let c = true;
                let elemNUname = document.getElementById(""newUsername"");
                let elemPwd1 = document.getElementById(""newPassword1"");
                let elemPwd2 = document.getElementById(""newPassword2"");
                let nUname = elemNUname.value.trim();
                let nPwd1 = elemPwd1.value.trim();
                let nPwd2 = elemPwd2.value.trim();
                if (nUname.length === 0 || nPwd1.length === 0 || nPwd2.length === 0) {
                    errDiv.innerHTML = ""Please fill up all fields."";
                    return false;	// cancel form submission
                }
                if (!(nPwd1 === nPwd2)) {
                errDiv.innerHTML = ""Passwords do not match.""
                return false;
                }
                UserNam");
                WriteLiteral(@"eChecker(nUname);
                //if (UserNameChecker(nUname) == ""0"") {
                //    return false;
                //}
                return true;
            }

            let elems = document.getElementsByClassName(""form-control"");
            for (let i = 0; i < elems.length; i++) {
                // remove our error message as long as any
                // of the input boxes have focus
                elems[i].onfocus = function () {
                    errDiv.innerHTML = """";
                }
            }
        }
        function UserNameChecker(nUname) {
            let xhr = new XMLHttpRequest();

            xhr.open(""POST"", ""/Register/CheckUserName"");
            xhr.setRequestHeader(""Content-Type"", ""application/json; charset=utf8"");
            xhr.onreadystatechange = function () {
                if (this.readyState == XMLHttpRequest.DONE) {
                    if (this.status == 200) {
                        data = JSON.parse(this.responseText);
                        if (data");
                WriteLiteral(@".status == ""DuplicatedUserName"") {

                            alert(""asdfasdasdf"");
                            return ""0"";
                            //errDiv.innerHTML = ""User name already taken, please enter another username"";
                            //return false;
                        }
                    }
                }
            };
            xhr.send(JSON.stringify({
                ""newUsername"": nUname,
            })
            );
        }
    </script>

");
            }
            );
            WriteLiteral("\n\n<style>\n    #err_msg {\n        color: red;\n        font-weight: bold;\n        padding: 10px;\n    }\n</style>\n\n<p></p>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f643463195206414ee7430536249a8e531486f817362", async() => {
                WriteLiteral(@"
    <table align=""center"">
        <tr>
            <td>
                Username:
            </td>
            <td>
                <input id=""newUsername"" name=""newUsername""
                       class=""form-control"" />
            </td>
        </tr>
        <tr>
            <td>
                Password:
            </td>
            <td>
                <input id=""newPassword1"" name=""newPassword1""
                       type=""password"" class=""form-control"" />
            </td>
        </tr>
        <tr>
            <td>
                Confirm:
            </td>
            <td>
                <input id=""newPassword2"" name=""newPassword2""
                       type=""password"" class=""form-control"" />
            </td>
        </tr>

        <tr>
            <td colspan=""2"" align=""right"">
                <input id=""submitBtn"" type=""submit"" class=""btn btn-success"" />
            </td>
        </tr>
        <tr>
            <td colspan=""2"" align=""center"">
                <div id=""err_msg"">
              ");
                WriteLiteral("      ");
#nullable restore
#line 119 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Register\Index.cshtml"
               Write(ViewData["errMsg"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 120 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Register\Index.cshtml"
                     if ((string)ViewData["register"] == "unsuccessful")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                         <div align=\"center\" style=\"color:red;font-weight:bold\">The username \"");
#nullable restore
#line 122 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Register\Index.cshtml"
                                                                                         Write(ViewData["username_input"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" has already been taken.<br /> Please try a new username.</div>\n");
#nullable restore
#line 123 "G:\NUS\ASP.NET\CA\CA_DotNetCore-master\CA_DotNetCore-master\CA1\Views\Register\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\n                    </td>\n                    </tr>\n                </table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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