#pragma checksum "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c30a49e37fac7eb43ce2911aee747ead3a8c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\_ViewImports.cshtml"
using oxu.news;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\_ViewImports.cshtml"
using oxu.news.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c30a49e37fac7eb43ce2911aee747ead3a8c50", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94afc63c679411d1a7fdee2bf0889fdb036944a", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<oxu.news.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img-static/15964345805842046018_1000x669.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img-static/1593151281479_5g6KhG8i.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img-static/auto.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncreaseLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncreaseDislike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"page-content\">\n    <div class=\"container\">\n        <section class=\"slider\">\n            <div class=\"news-i\"></div>\n            <div class=\"slider-nav\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 264, "\"", 271, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <!-- <span>İri ticarət mərkəzlərinin açılmamasının səbəbi bilindi</span>\n                    <span class=\"valign\"></span> -->\n                </a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 459, "\"", 466, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 491, "\"", 498, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 523, "\"", 530, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 562, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
            </div>
            <div class=""featured"">
                <div class=""prev switch"">
                    <i class=""fas fa-chevron-left""></i>
                </div>
                <div class=""next switch"">
                    <i class=""fas fa-chevron-right""></i>
                </div>
                <div class=""progress-container""></div>
                <div class=""inner"">
                    <a class=""featured-i"" href=""second.html"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3c30a49e37fac7eb43ce2911aee747ead3a8c507862", async() => {
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
            WriteLiteral(@"
                        <div class=""img-content"">
                            <div class=""main-news"">
                                <span class=""date"">3Avg</span>
                                <span class=""time"">17:59</span>
                                <span class=""views"">8448</span>
                            </div>
                            <div class=""text"">
                                <div class=""title2"">İri ticarət mərkəzlərinin açılmamasının səbəbi bilindi</div>
                                <div class=""description""></div>
                            </div>
                        </div>
                    </a>
                    <a class=""featured-i"" href=""second.html"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3c30a49e37fac7eb43ce2911aee747ead3a8c509723", async() => {
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
            WriteLiteral(@"
                        <div class=""img-content"">
                            <div class=""main-news"">
                                <span class=""date"">3Avg</span>
                                <span class=""time"">17:59</span>
                                <span class=""views"">8448</span>
                            </div>
                            <div class=""text"">
                                <div class=""title2"">İri ticarət mərkəzlərinin açılmamasının səbəbi bilindi</div>
                                <div class=""description""></div>
                            </div>
                        </div>
                    </a>
                    <a class=""featured-i"" href=""second.html"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3c30a49e37fac7eb43ce2911aee747ead3a8c5011584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""img-content"">
                            <div class=""main-news"">
                                <span class=""date"">3Avg</span>
                                <span class=""time"">17:59</span>
                                <span class=""views"">8448</span>
                            </div>
                            <div class=""text"">
                                <div class=""title2"">İri ticarət mərkəzlərinin açılmamasının səbəbi bilindi</div>
                                <div class=""description""></div>
                            </div>
                        </div>
                    </a>

                </div>
            </div>
        </section>
        <section class=""new-list row"">
");
#nullable restore
#line 78 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
             foreach (var news in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"news-i col-4\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c30a49e37fac7eb43ce2911aee747ead3a8c5013778", async() => {
                WriteLiteral("\n                    <div class=\"when\">\n                        <div class=\"when-date\">\n                            <div class=\"date-day\">");
#nullable restore
#line 84 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                             Write(news.CreationDate.Day.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                            <div class=\"date-month\">");
#nullable restore
#line 85 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                               Write(news.CreationDate.Month.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                            <div class=\"date-year\">");
#nullable restore
#line 86 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                              Write(news.CreationDate.Year.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        </div>\n                        <div class=\"when-time\">");
#nullable restore
#line 88 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                          Write(news.CreationDate.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 88 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                                                  Write(news.CreationDate.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                    </div>\n                    <div class=\"img-container\">\n                        <div class=\"img\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3c30a49e37fac7eb43ce2911aee747ead3a8c5016011", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4211, "~/images/", 4211, 9, true);
#nullable restore
#line 91 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
AddHtmlAttributeValue("", 4220, news.ImageName, 4220, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\n                    </div>\n                    <div class=\"news-content\">\n                        <div class=\"title3\">");
#nullable restore
#line 94 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                       Write(news.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        <div class=\"description1\"></div>\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                                            WriteLiteral(news.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <div class=\"status\">\n                    <div class=\"like status-i\">\n\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c30a49e37fac7eb43ce2911aee747ead3a8c5020329", async() => {
                WriteLiteral("\n                            <i class=\"fas fa-thumbs-up\"></i>\n                            ");
#nullable restore
#line 103 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                       Write(news.Like);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                                                             WriteLiteral(news.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"dislike status-i\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c30a49e37fac7eb43ce2911aee747ead3a8c5023209", async() => {
                WriteLiteral("\n                            <i class=\"fas fa-thumbs-down\"></i>\n                            ");
#nullable restore
#line 109 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                       Write(news.Dislike);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                                                                WriteLiteral(news.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"view status-i\">\n                        <a><i class=\"fas fa-eye\"></i>");
#nullable restore
#line 113 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
                                                Write(news.View);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 117 "C:\Users\HP\Desktop\asp-net-core-oxu-az-ZumrudAliyeva-master\oxu.news\Views\News\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<oxu.news.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591