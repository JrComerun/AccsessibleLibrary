#pragma checksum "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f6ed2530620d64811b715e1685d4821ca97b8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Detail), @"mvc.1.0.view", @"/Views/Books/Detail.cshtml")]
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
#line 1 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\_ViewImports.cshtml"
using AccessibleLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\_ViewImports.cshtml"
using AccessibleLibrary.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\_ViewImports.cshtml"
using AccessibleLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6ed2530620d64811b715e1685d4821ca97b8d8", @"/Views/Books/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4288c1cf7f8eab9946ff4aee23094e0f04653250", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("book-detail-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-center align-items-center flex-column"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/src/css/secondary.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- *-*-*-*-*-*-*-*-*      Most Viewed Start      *-*-*-*-*-*-*-*-* -->
<section id=""Book-Detail"">
    <div class=""container pb-5"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-8 col-md-8"">
                <div class=""book"">
                    <div class=""book-images"">
");
#nullable restore
#line 13 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                         foreach (BookImage img in Model.BookImages)
                        {
                            if (img.Parent == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f6ed2530620d64811b715e1685d4821ca97b8d87115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 594, "~/src/img/bookDetails/", 594, 22, true);
#nullable restore
#line 17 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
AddHtmlAttributeValue("", 616, img.Image, 616, 10, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div id=\"thumbnails\">\r\n");
#nullable restore
#line 22 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                             foreach (BookImage img in Model.BookImages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f6ed2530620d64811b715e1685d4821ca97b8d89375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 920, "~/src/img/bookDetails/", 920, 22, true);
#nullable restore
#line 24 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
AddHtmlAttributeValue("", 942, img.Image, 942, 10, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"to-like\">\r\n");
#nullable restore
#line 29 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                              
                                if (User.Identity.IsAuthenticated)
                                {
                                    if (Model.AppUserBooks.Any(ab => ab.AppUserId == ViewBag.UserId && ab.BookId == Model.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"bookmark-a\">\r\n                                            <i class=\"fas fa-bookmark\"></i>\r\n                                        </a>\r\n");
#nullable restore
#line 37 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"bookmark-a\">\r\n                                            <i class=\"far fa-bookmark\"></i>\r\n                                        </a>\r\n");
#nullable restore
#line 43 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                    }
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a style=\"cursor:pointer\" data-toggle=\"modal\" data-target=\"#Login-Reg\" onclick=\"SwitchToLog()\">\r\n                                        <i class=\"far fa-bookmark\"></i>\r\n                                    </a>\r\n");
#nullable restore
#line 50 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2377, "\"", 2394, 1);
#nullable restore
#line 53 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
WriteAttributeValue("", 2385, Model.Id, 2385, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""book-content d-flex flex-column"">
                        <div class=""book-content-head"">
                            <div class=""icons d-flex justify-content-between"">
                                <div class=""book-name"">");
#nullable restore
#line 59 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"watch-page d-flex justify-content-center align-items-center\">\r\n                                    <i class=\"fas fa-eye\"></i>\r\n                                    <span>");
#nullable restore
#line 62 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                     Write(Model.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"book-content-body\">\r\n                            <div class=\"book-author\"><span>Muəllif : </span> ");
#nullable restore
#line 67 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                                                        Write(Model.Auhtor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"book-language\"><span>Dil : </span> ");
#nullable restore
#line 68 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                                                      Write(Model.BookLanguage.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            <div class=""book-Category""><span>Kateqoriya : </span> Dərslik</div>
                            <div class=""book-Category""><span>Alt Kateqoriya : </span> Digər</div>
                        </div>
                        <div class=""book-content-footer d-flex justify-content-between align-items-center"">
                            <div class=""location"">");
#nullable restore
#line 73 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                             Write(Model.BookDetail.BookCity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"create-time d-flex justify-content-end align-items-center\">\r\n                                Yaranma Tarixi : ");
#nullable restore
#line 75 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                            Write(Model.BookDetail.CreateTime.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4"">
                <div class=""book-contact"">
                    <div class=""contact-head d-flex justify-content-center"">
                        <div class=""book-price"">5 Azn</div>
                    </div>
                    <div class=""contact-body d-flex justify-content-center align-items-center"">
                        <div class=""person-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f6ed2530620d64811b715e1685d4821ca97b8d817709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4547, "~/src/img/users/", 4547, 16, true);
#nullable restore
#line 88 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
AddHtmlAttributeValue("", 4563, Model.AppUser.Image, 4563, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"person-name\">");
#nullable restore
#line 90 "C:\Users\TOSHIBA\Desktop\developback\AccessibleLibrary\AccessibleLibrary\Views\Books\Detail.cshtml"
                                            Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"contact-message\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f6ed2530620d64811b715e1685d4821ca97b8d819795", async() => {
                WriteLiteral(@"
                            <div class=""form-group w-100"">
                                <textarea class=""form-control""
                                          id=""exampleFormControlTextarea1""
                                          rows=""7""
                                          placeholder=""Mesaj ...""></textarea>
                            </div>
                            <div class=""form-group"">
                                <button>Mesajı göndər</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"contact-footer \">\r\n                        <div class=\"whatsapp\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5636, "\"", 5643, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5644, "\"", 5652, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""fab fa-whatsapp""></i>
                                <span> Whatsappdan yaz </span>
                            </a>
                        </div>
                        <div class=""mobil mb-3"">
                            <i class=""fas fa-phone""></i>
                            <span> (+994) 558835613 </span>
                        </div>
                        <div class=""mobil "">
                            <i style=""font-size:27px"" class=""fas fa-at""></i>
                            <span> kamranfn@code.edu.az </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- *-*-*-*-*-*-*-*-*      Most Viewed End      *-*-*-*-*-*-*-*-* -->
<!-- ---------------------------------------------------------- -->
");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f6ed2530620d64811b715e1685d4821ca97b8d823147", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
