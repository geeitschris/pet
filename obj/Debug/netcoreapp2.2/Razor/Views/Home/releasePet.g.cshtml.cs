#pragma checksum "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eb23f50507b2e9118a37498cdd44b5f77a5948c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_releasePet), @"mvc.1.0.view", @"/Views/Home/releasePet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/releasePet.cshtml", typeof(AspNetCore.Views_Home_releasePet))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb23f50507b2e9118a37498cdd44b5f77a5948c", @"/Views/Home/releasePet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c8af637485c4f7cd97a446f99bffe893a9322c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_releasePet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:underline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletePet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("background"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 414, true);
            WriteLiteral(@"
<style>
    .background{
    background-image: url(https://www.worldofwallpaper.com/media/catalog/product/cache/a13f2d0ee5dc2e18e92742d73c48d042/g/d/gdo021_grandeco_eco_stars_wallpaper_grey_ae1.jpg);
    background-repeat: repeat;
    }
    .nav justify-content-end{
        background-color: rgb(187,190,195);
    }
    .container{
        text-align:center;
        max-width:100%;
    }
</style>
");
            EndContext();
            BeginContext(426, 1527, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb23f50507b2e9118a37498cdd44b5f77a5948c6311", async() => {
                BeginContext(451, 499, true);
                WriteLiteral(@"
    <div class=""container"">
        <ul class=""nav justify-content-end"">
            <li class=""nav-item"">
                <a class=""nav-link active"" href=""/dashboard"">Home</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/user/mailbox"">Mail</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/dashboard"">Release Pet</a>
            </li>
            <li class=""nav-item"">
                ");
                EndContext();
                BeginContext(950, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb23f50507b2e9118a37498cdd44b5f77a5948c7214", async() => {
                    BeginContext(1027, 6, true);
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
                BeginContext(1037, 186, true);
                WriteLiteral("\r\n            </li>\r\n        </ul>\r\n        <div class=\"pet\" style=\"display:inline-block;\">\r\n            <p style=\"font-weight:bold;font-family: Poppins-Bold; margin:15px 0px 15px 0px;\">");
                EndContext();
                BeginContext(1224, 13, false);
#line 33 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml"
                                                                                        Write(Model.PetName);

#line default
#line hidden
                EndContext();
                BeginContext(1237, 3, true);
                WriteLiteral(" (#");
                EndContext();
                BeginContext(1241, 11, false);
#line 33 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml"
                                                                                                         Write(Model.PetId);

#line default
#line hidden
                EndContext();
                BeginContext(1252, 23, true);
                WriteLiteral(")</p>\r\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=", 1275, "", 1297, 1);
#line 34 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml"
WriteAttributeValue("", 1280, Model.PetPicture, 1280, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1297, 41, true);
                WriteLiteral(" alt=\"pet image\">\r\n            <p>Level: ");
                EndContext();
                BeginContext(1339, 14, false);
#line 35 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml"
                 Write(Model.PetLevel);

#line default
#line hidden
                EndContext();
                BeginContext(1353, 15, true);
                WriteLiteral(" | Experience: ");
                EndContext();
                BeginContext(1369, 19, false);
#line 35 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml"
                                               Write(Model.PetExperience);

#line default
#line hidden
                EndContext();
                BeginContext(1388, 247, true);
                WriteLiteral("</p>\r\n            <div style=\"margin-top:10px; height: 250px; width:90%; display:inline-block; border:1px solid lightgray; background:white;\">\r\n                <p style=\"font-weight:bold;font-family: Poppins-Bold;\">Pet Bio</p>\r\n                <p>");
                EndContext();
                BeginContext(1636, 12, false);
#line 38 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml"
              Write(Model.PetBio);

#line default
#line hidden
                EndContext();
                BeginContext(1648, 111, true);
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <h2>Are you sure you want to release this pet?</h2>\r\n        ");
                EndContext();
                BeginContext(1759, 173, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb23f50507b2e9118a37498cdd44b5f77a5948c11939", async() => {
                    BeginContext(1853, 72, true);
                    WriteLiteral(" \r\n            <button class=\"btn btn-danger\">Release</button>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-petId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 42 "C:\Users\chris\OneDrive\Desktop\CodingDojo\C# Stack\petpet\Views\Home\releasePet.cshtml"
                                         WriteLiteral(Model.PetId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["petId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-petId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["petId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1932, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591
