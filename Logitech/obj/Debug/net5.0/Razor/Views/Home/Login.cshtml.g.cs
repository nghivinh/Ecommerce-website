#pragma checksum "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a85e71464333d7f50ccb5fb18a69382e0bc35e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "D:\Nam4\Ecommerce-website\Logitech\Views\_ViewImports.cshtml"
using Logitech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam4\Ecommerce-website\Logitech\Views\_ViewImports.cshtml"
using Logitech.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a85e71464333d7f50ccb5fb18a69382e0bc35e9", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a64b83697e1bc30402c55bd214a09c061f76ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Logitech.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/facebook.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Facebook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("auth-form_socials--icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/google.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Google"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Đăng nhập";
    Layout = "~/Views/Shared/_LayoutHeader.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"auth-form\">\r\n    <div class=\"auth-form__top\">\r\n        <div class=\"auth-form__header\">\r\n            <h3 class=\"auth-form__heading\">Đăng nhập</h3>\r\n            <span class=\"auth-form__switch-btn\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 396, 1);
#nullable restore
#line 12 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
WriteAttributeValue("", 366, Url.Action("Register","Home"), 366, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đăng Ký</a>\r\n            </span>\r\n        </div>\r\n");
#nullable restore
#line 15 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
         using (Html.BeginForm("Login", "Home", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"auth-form__form\">\r\n                <div class=\"auth-form__group\">\r\n                    ");
#nullable restore
#line 20 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
               Write(Html.TextBoxFor(a => a.UserName, "", new { @class = "auth-form__input", @placeholder = "Tên người dùng" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"auth-form__group\">\r\n                    ");
#nullable restore
#line 23 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
               Write(Html.PasswordFor(a => a.Password, new { @class = "auth-form__input", @placeholder = "Mật khẩu của bạn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"auth-form__aside\">\r\n                <div class=\"auth-form__help\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1143, "\"", 1150, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"auth-form__help-link auth-form__help-link--forgot\">Quên mật khẩu</a>\r\n                    <span class=\"bulkhead mlf-16\">|</span>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1311, "\"", 1318, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"auth-form__help-link\">Cần trợ giúp?</a>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"auth-form_controls\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1478, "\"", 1512, 1);
#nullable restore
#line 36 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
WriteAttributeValue("", 1485, Url.Action("Index","Home"), 1485, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn--back\">TRỞ LẠI</a>\r\n                <button type=\"submit\" class=\"btn btn--primary\">ĐĂNG NHẬP</button>\r\n            </div>\r\n");
#nullable restore
#line 39 "D:\Nam4\Ecommerce-website\Logitech\Views\Home\Login.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"auth-form_socials\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1729, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn--with-icon btn--facebook\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a85e71464333d7f50ccb5fb18a69382e0bc35e98769", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"auth-form_socials--text\">Kết nối với Facebook</span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1964, "\"", 1971, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn--with-icon btn--google\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a85e71464333d7f50ccb5fb18a69382e0bc35e910269", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"auth-form_socials--text\">Kết nối với Google</span>\r\n        </a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Logitech.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
