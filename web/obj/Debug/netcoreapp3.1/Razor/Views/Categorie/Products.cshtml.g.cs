#pragma checksum "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Categorie\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fd6e482138e1f8862f6828fe33f035e6cedc68d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorie_Products), @"mvc.1.0.view", @"/Views/Categorie/Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd6e482138e1f8862f6828fe33f035e6cedc68d", @"/Views/Categorie/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7421ce70c6dc4ed13aa69fb6306a40339c290def", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categorie_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Css/Products.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Css/Search.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Js/Search.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Categorie\Products.cshtml"
  
    Layout = "_Layout1";
    ViewData["Title"] = ViewBag.Category;

#line default
#line hidden
#nullable disable
            DefineSection("OptionalCSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fd6e482138e1f8862f6828fe33f035e6cedc68d5635", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fd6e482138e1f8862f6828fe33f035e6cedc68d6813", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            DefineSection("OptionalJS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fd6e482138e1f8862f6828fe33f035e6cedc68d8115", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(""#search"").keyup(function (e) {
            if (!isValidKey(e.keyCode)) {
                e.preventDefault()
                var text = $(""#search"").val().replace(new RegExp(e.key, 'g'), """")
                $(""#search"").val(text)
            }
            var text = $(""#search"").val();
            if (text == """") {
                $("".suggetion"").css(""display"", ""none"");
            } else {
                $("".suggetion"").css(""display"", ""block"");
            }
            // ajax handler

            $.ajax({
                type: ""post"",
                url: """);
#nullable restore
#line 31 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Categorie\Products.cshtml"
                 Write(Url.Action("GetInfo","Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                data: { name: text },
                dataType: ""json"",
                success: function (response) {
                    $("".suggetion ul li"").remove();
                    $.each(response, function (index, element) {
                        var id 
                        var ProductName
                        var c =0
                        $.each(element, function (key, value) {
                            if (c==0) {
                                id = value.toString()
                            }
                            if ( c == 1) {
                                ProductName = value.toString()
                            }
                            c++
                        });
                    var url = """);
#nullable restore
#line 49 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Categorie\Products.cshtml"
                          Write(Url.Action("GetProduct", "Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" +""/"" + id
                        var text1 = '<li><a href=""' + url + '"">' + ProductName + '</a></li>';
            $("".suggetion ul"").append(text1);
                    });
                    if ($("".suggetion ul"").is(':empty')) {
                        $("".suggetion"").css(""display"", ""none"");
                    }
                },
                error: function (response, status, error) {
                    console.log(error.toString())
                }
            });
        });
        function isValidKey(keyCode) {
            if ((keyCode >= 65 && keyCode <= 90) ||
                (keyCode <= 57 && keyCode >= 48) ||
                keyCode == 54 || keyCode == 52 ||
                keyCode == 16 || keyCode == 16 || keyCode == 50) {
                return true
            }
            return false
        }
    </script>
");
            }
            );
            DefineSection("OptionalTitle", async() => {
                WriteLiteral("\r\n        <div class=\"cat-name\">");
#nullable restore
#line 75 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Categorie\Products.cshtml"
                         Write(ViewBag.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n    ");
            }
            );
            WriteLiteral("   ");
#nullable restore
#line 78 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Categorie\Products.cshtml"
Write(await Component.InvokeAsync("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 79 "C:\Users\ahmed\Desktop\Projects\spring-react\web\Views\Categorie\Products.cshtml"
Write(await Component.InvokeAsync("GetProduct", ViewBag.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
