#pragma checksum "D:\Parmida\portfolio\pot-folio\Views\Home\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3168cb11da2926eb42eac106757731e6cc814a34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contact), @"mvc.1.0.view", @"/Views/Home/contact.cshtml")]
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
#line 1 "D:\Parmida\portfolio\pot-folio\Views\_ViewImports.cshtml"
using pot_folio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Parmida\portfolio\pot-folio\Views\_ViewImports.cshtml"
using pot_folio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3168cb11da2926eb42eac106757731e6cc814a34", @"/Views/Home/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"180724edb54378ba61f21c6296451b522fa3b63a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Parmida\portfolio\pot-folio\Views\Home\contact.cshtml"
  
    ViewData["Title"] = "contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<section class=""ftco-section ftco-no-pt ftco-no-pb"">
    <div class=""container px-md-0"">
        <div class=""row d-flex no-gutters"">
            <div class=""col-lg-8 col-md-7 order-md-last d-flex align-items-stretch"">
                <div class=""contact-wrap w-100 p-md-5 p-4"">
                    <h3 class=""mb-4 heading"">Get in touch</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3168cb11da2926eb42eac106757731e6cc814a345083", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""name"">Full Name</label>
                                    <input type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Name"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""email"">Email Address</label>
                                    <input type=""email"" class=""form-control"" name=""email"" id=""email"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""subject"">Subj");
                WriteLiteral(@"ect</label>
                                    <input type=""text"" class=""form-control"" name=""subject"" id=""subject"" placeholder=""Subject"">
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""#"">Message</label>
                                    <textarea name=""message"" class=""form-control"" id=""message"" cols=""30"" rows=""4"" placeholder=""Message""></textarea>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <input type=""submit"" value=""Send Message"" class=""btn btn-primary"">
                                    <div class=""submitting""></div>
                                </div>
                            </div>
                        </div>");
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            <div class=""col-lg-4 col-md-5 d-flex align-items-stretch"">
                <div class=""info-wrap js-fullheight bg-primary w-100 p-md-5 p-4"">
                    <h3>Let's get in touch</h3>
                    <p class=""mb-4"">We're open for any suggestion or just to have a chat</p>
                    <div class=""dbox w-100 d-flex align-items-start"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span class=""fa fa-map-marker""></span>
                        </div>
                        <div class=""text pl-3"">
                            <p><span>Address:</span> 198 West 21th Street, Suite 721 New York NY 10016</p>
                        </div>
                    </div>
                    <div class=""dbox w-100 d-flex align-items-center"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span ");
            WriteLiteral(@"class=""fa fa-phone""></span>
                        </div>
                        <div class=""text pl-3"">
                            <p><span>Phone:</span> <a href=""tel://1234567920"">+ 1235 2355 98</a></p>
                        </div>
                    </div>
                    <div class=""dbox w-100 d-flex align-items-center"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span class=""fa fa-paper-plane""></span>
                        </div>
                        <div class=""text pl-3"">
                            <p><span>Email:</span> <a href=""mailto:info@yoursite.com"">info@yoursite.com</a></p>
                        </div>
                    </div>
                    <div class=""dbox w-100 d-flex align-items-center"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span class=""fa fa-globe""></span>
                        </div>
    ");
            WriteLiteral(@"                    <div class=""text pl-3"">
                            <p><span>Website</span> <a href=""#"">yoursite.com</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row d-flex no-gutters"">
            <div id=""map"" class=""map""></div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-no-pt ftco-no-pb"">
    <div class=""container px-md-0"">
        <div class=""row d-flex no-gutters"">
            <div class=""col-lg-8 col-md-7 order-md-last d-flex align-items-stretch"">
                <div class=""contact-wrap w-100 p-md-5 p-4"">
                    <h3 class=""mb-4 heading"">Get in touch</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3168cb11da2926eb42eac106757731e6cc814a3411911", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""name"">Full Name</label>
                                    <input type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Name"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""email"">Email Address</label>
                                    <input type=""email"" class=""form-control"" name=""email"" id=""email"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""subject"">Subj");
                WriteLiteral(@"ect</label>
                                    <input type=""text"" class=""form-control"" name=""subject"" id=""subject"" placeholder=""Subject"">
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label class=""label"" for=""#"">Message</label>
                                    <textarea name=""message"" class=""form-control"" id=""message"" cols=""30"" rows=""4"" placeholder=""Message""></textarea>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <input type=""submit"" value=""Send Message"" class=""btn btn-primary"">
                                    <div class=""submitting""></div>
                                </div>
                            </div>
                        </div>");
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            <div class=""col-lg-4 col-md-5 d-flex align-items-stretch"">
                <div class=""info-wrap js-fullheight bg-primary w-100 p-md-5 p-4"">
                    <h3>Let's get in touch</h3>
                    <p class=""mb-4"">We're open for any suggestion or just to have a chat</p>
                    <div class=""dbox w-100 d-flex align-items-start"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span class=""fa fa-map-marker""></span>
                        </div>
                        <div class=""text pl-3"">
                            <p><span>Address:</span> 198 West 21th Street, Suite 721 New York NY 10016</p>
                        </div>
                    </div>
                    <div class=""dbox w-100 d-flex align-items-center"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span ");
            WriteLiteral(@"class=""fa fa-phone""></span>
                        </div>
                        <div class=""text pl-3"">
                            <p><span>Phone:</span> <a href=""tel://1234567920"">+ 1235 2355 98</a></p>
                        </div>
                    </div>
                    <div class=""dbox w-100 d-flex align-items-center"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span class=""fa fa-paper-plane""></span>
                        </div>
                        <div class=""text pl-3"">
                            <p><span>Email:</span> <a href=""mailto:info@yoursite.com"">info@yoursite.com</a></p>
                        </div>
                    </div>
                    <div class=""dbox w-100 d-flex align-items-center"">
                        <div class=""icon d-flex align-items-center justify-content-center"">
                            <span class=""fa fa-globe""></span>
                        </div>
    ");
            WriteLiteral(@"                    <div class=""text pl-3"">
                            <p><span>Website</span> <a href=""#"">yoursite.com</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</section>

");
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
