#pragma checksum "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\showMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89865e2110b7a5b5d2320b562f4bb8a2fcb51980"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_showMail), @"mvc.1.0.view", @"/Views/Home/showMail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/showMail.cshtml", typeof(AspNetCore.Views_Home_showMail))]
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
#line 1 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\_ViewImports.cshtml"
using petpet;

#line default
#line hidden
#line 2 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\_ViewImports.cshtml"
using petpet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89865e2110b7a5b5d2320b562f4bb8a2fcb51980", @"/Views/Home/showMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c8af637485c4f7cd97a446f99bffe893a9322c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_showMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:underline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "replyMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline-block;float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 1340, true);
            WriteLiteral(@"<style>
    html{
    background-image: url(https://www.worldofwallpaper.com/media/catalog/product/cache/a13f2d0ee5dc2e18e92742d73c48d042/g/d/gdo021_grandeco_eco_stars_wallpaper_grey_ae1.jpg);
    background-repeat: repeat;
    width:100%;
    height:100%;
    }
    .background{
    background-image: url(https://www.worldofwallpaper.com/media/catalog/product/cache/a13f2d0ee5dc2e18e92742d73c48d042/g/d/gdo021_grandeco_eco_stars_wallpaper_grey_ae1.jpg);
    background-repeat: repeat;
    width:100%;
    height:100%;
    }
    html
    .nav justify-content-end{
        background-color: rgb(187,190,195);
    }
    .container{
        text-align:center;
        max-width:100%;
    }
    #content{
        margin-bottom:30px;
    }
    table{
        text-align: none;
    }
</style>

<div class=""background"">
    <div class=""container"">
        <ul class=""nav justify-content-end"">
            <li class=""nav-item"">
                <a class=""nav-link active"" href=""/dashboard"">Home</a>
");
            WriteLiteral(@"            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/user/mailbox"">Mail</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/dashboard"">Release Pet</a>
            </li>
            <li class=""nav-item"">
                ");
            EndContext();
            BeginContext(1353, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89865e2110b7a5b5d2320b562f4bb8a2fcb519806641", async() => {
                BeginContext(1430, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1440, 273, true);
            WriteLiteral(@"
            </li>
        </ul>
        <div style=""width:90%; display:inline-block; margin-top:20px; border:1px solid gray; border-radius:5px; padding: 5px;"">
            <table class=""table table-striped"">
                <thead>
                    <tr><h4>From: ");
            EndContext();
            BeginContext(1714, 16, false);
#line 50 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\showMail.cshtml"
                             Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(1730, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1734, 15, false);
#line 50 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\showMail.cshtml"
                                                 Write(Model.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1749, 49, true);
            WriteLiteral("</h4></tr>\r\n                    <tr><h4>Subject: ");
            EndContext();
            BeginContext(1799, 13, false);
#line 51 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\showMail.cshtml"
                                Write(Model.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(1812, 111, true);
            WriteLiteral("</h4></tr>\r\n                    <tr><h4 style=\"font-size:12pt; font-weight:none;\" id=\"content\"><p>Message:</p> ");
            EndContext();
            BeginContext(1924, 13, false);
#line 52 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\showMail.cshtml"
                                                                                              Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1937, 68, true);
            WriteLiteral("</h4></tr>\r\n                </thead>\r\n            </table>\r\n        ");
            EndContext();
            BeginContext(2005, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89865e2110b7a5b5d2320b562f4bb8a2fcb5198010206", async() => {
                BeginContext(2129, 5, true);
                WriteLiteral("Reply");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mailId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\showMail.cshtml"
                                       WriteLiteral(Model.MailId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mailId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mailId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mailId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2138, 35, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mail> Html { get; private set; }
    }
}
#pragma warning restore 1591
