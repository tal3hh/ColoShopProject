#pragma checksum "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163fdf7c27189fdd8b4d17e1089e47c1a93b4d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ColoShop.UI.Areas.AdminPanel.Views.Shared.Product.Areas_AdminPanel_Views_Product_Details), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Product/Details.cshtml")]
namespace ColoShop.UI.Areas.AdminPanel.Views.Shared.Product
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
#line 1 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using ServiceLayer.DTOs.Gender;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using ServiceLayer.DTOs.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
using ServiceLayer.DTOs.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163fdf7c27189fdd8b4d17e1089e47c1a93b4d6f", @"/Areas/AdminPanel/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9d01354ef48012a87c313693471c67cf904312", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:35%;height:35%;border-radius:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12 grid-margin\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Mehsul</h4>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "163fdf7c27189fdd8b4d17e1089e47c1a93b4d6f6950", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Mehsul Adi :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 17 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Cinsiyyet :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 27 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.GenderName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Qiymet :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 40 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Kateqoriya :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 50 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Foto :</label>
                                <div style=""width:35%;height:35%;border-radius:100%;"" class=""col-sm-9"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "163fdf7c27189fdd8b4d17e1089e47c1a93b4d6f10930", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2884, "~/AdminPanel/img/product/", 2884, 25, true);
#nullable restore
#line 61 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 2909, Model.Image, 2909, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Etiket :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 70 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.Ticket.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <p class=""card-description"">
                        Mehsul Detallari
                    </p>

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Reng :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 86 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.Color.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Beden :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 96 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.Size.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Etiket :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 108 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.Ticket.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Say :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 118 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Movcuddur? :</label>
                                <div class=""col-sm-9"">
");
#nullable restore
#line 129 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                     if (Model.Availability)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p class=\"form-control\">\r\n                                            Aktiv\r\n                                        </p>\r\n");
#nullable restore
#line 134 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                    }
                                    else 
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p class=\"form-control\">\r\n                                            Aktiv Deyil\r\n                                        </p>\r\n");
#nullable restore
#line 140 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group row"">
                                <label class=""col-sm-3 col-form-label"">Reyting :</label>
                                <div class=""col-sm-9"">
                                    <p class=""form-control"">
                                        ");
#nullable restore
#line 149 "C:\Users\HP\Desktop\ColoShop\OnionArch\ColoShop\ColoShop.UI\Areas\AdminPanel\Views\Product\Details.cshtml"
                                   Write(Model.StarCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "163fdf7c27189fdd8b4d17e1089e47c1a93b4d6f19740", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
