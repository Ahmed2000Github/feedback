#pragma checksum "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c05845437478b03f0e823ad0ca577cc83915cce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetProfile_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GetProfile/Default.cshtml")]
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
#line 1 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\_ViewImports.cshtml"
using Web.ViewsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\_ViewImports.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\_ViewImports.cshtml"
using Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c05845437478b03f0e823ad0ca577cc83915cce", @"/Views/Shared/Components/GetProfile/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7421ce70c6dc4ed13aa69fb6306a40339c290def", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_GetProfile_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetProfileVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
 if (Model !=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"avatar\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c05845437478b03f0e823ad0ca577cc83915cce4553", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 83, "~/Images/Users/", 83, 15, true);
#nullable restore
#line 4 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
AddHtmlAttributeValue("", 98, Model.rater.AvatarUrl, 98, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"info\">\r\n        <h1>");
#nullable restore
#line 7 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
       Write(Model.rater.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
                              Write(Model.rater.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h2>Birth day : ");
#nullable restore
#line 8 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
                   Write(Model.rater.BirthDay.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Email : ");
#nullable restore
#line 9 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
               Write(Model.rater.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Age : ");
#nullable restore
#line 10 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
             Write(Model.rater.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"opertaion\">\r\n        <h3>Number of product commented : ");
#nullable restore
#line 13 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
                                     Write(Model.CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Shared\Components\GetProfile\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetProfileVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
