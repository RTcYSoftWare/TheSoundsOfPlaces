#pragma checksum "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb604634bd8a4e665c1f904c9592e3713e2dd026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TheSoundsOfPlaces.Pages.Login.Areas_Administration_Views_Login_Index), @"mvc.1.0.view", @"/Areas/Administration/Views/Login/Index.cshtml")]
namespace TheSoundsOfPlaces.Pages.Login
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
#line 1 "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\_ViewImports.cshtml"
using TheSoundsOfPlaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\_ViewImports.cshtml"
using TheSoundsOfPlaces.Areas.Administration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb604634bd8a4e665c1f904c9592e3713e2dd026", @"/Areas/Administration/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ebb98ff33d04a705075fb4109726c70428fe26", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb604634bd8a4e665c1f904c9592e3713e2dd0264671", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>The Sounds Of Places - Admin</title>\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 293, "\"", 303, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"keywords\">\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 332, "\"", 342, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""description"">

    <!-- Favicon -->
    <link href=""img/favicon.ico"" rel=""icon"">

    <!-- Google Web Fonts -->
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Heebo:wght@400;500;600;700&display=swap"" rel=""stylesheet"">

    <!-- Icon Font Stylesheet -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css"" rel=""stylesheet"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css"" rel=""stylesheet"">

    <!-- Libraries Stylesheet -->
    <link href=""lib/owlcarousel/assets/owl.carousel.min.css"" rel=""stylesheet"">
    <link href=""lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css"" rel=""stylesheet"" />

    <!-- Customized Bootstrap Stylesheet -->
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Template Stylesheet -->
    <link href=""css/style.css""");
                WriteLiteral(" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb604634bd8a4e665c1f904c9592e3713e2dd0267283", async() => {
                WriteLiteral(@"
    <div class=""container-xxl position-relative bg-white d-flex p-0"">
        <!-- Spinner Start -->
        <div id=""spinner"" class=""show bg-white position-fixed translate-middle w-100 vh-100 top-50 start-50 d-flex align-items-center justify-content-center"">
            <div class=""spinner-border text-primary"" style=""width: 3rem; height: 3rem;"" role=""status"">
                <span class=""sr-only"">Loading...</span>
            </div>
        </div>
        <!-- Spinner End -->
        <!-- Sign In Start -->
        <div class=""container-fluid"">
            <div class=""row h-100 align-items-center justify-content-center"" style=""min-height: 100vh;"">
                <div class=""col-12 col-sm-8 col-md-6 col-lg-5 col-xl-4"">
                    <div class=""bg-light rounded p-4 p-sm-5 my-4 mx-3"">
                        <div class=""d-flex align-items-center justify-content-between mb-3"">
                            <a href=""index.html""");
                BeginWriteAttribute("class", " class=\"", 2362, "\"", 2370, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <h3 class=\"text-primary\"><i class=\"fa fa-hashtag me-2\"></i>YÖNETİM</h3>\r\n                            </a>\r\n                            <h3>Giriş Yap</h3>\r\n                        </div>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb604634bd8a4e665c1f904c9592e3713e2dd0268938", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\Login\Index.cshtml"
                             if (Model.Error != null)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <div class=\"alert alert-danger\" role=\"alert\">\r\n                                    ");
#nullable restore
#line 64 "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\Login\Index.cshtml"
                               Write(Model.Error);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" \r\n                                </div>\r\n");
#nullable restore
#line 66 "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\Login\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                            <div class=""form-floating mb-3"">
                                <input type=""email"" class=""form-control"" name=""email"" id=""floatingInput"" placeholder=""name@example.com"">
                                <label for=""floatingInput"">Email address</label>
                            </div>
                            <div class=""form-floating mb-4"">
                                <input type=""password"" class=""form-control"" name=""password"" id=""floatingPassword"" placeholder=""Password"">
                                <label for=""floatingPassword"">Password</label>
                            </div>
                            <div class=""d-flex align-items-center justify-content-between mb-4"">
                                <div class=""form-check"">
                                    <input type=""checkbox"" class=""form-check-input"" name=""rememberMe"" id=""exampleCheck1"">
                                    <label class=""form-check-label"" for=""exampleCheck1"">Check me out</label>
");
                    WriteLiteral("                                </div>\r\n                                <a");
                    BeginWriteAttribute("href", " href=\"", 4110, "\"", 4117, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Forgot Password</a>\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-primary py-3 w-100 mb-4\">Giriş Yap</button>\r\n                            <p class=\"text-center mb-0\">Don\'t have an Account? <a");
                    BeginWriteAttribute("href", " href=\"", 4367, "\"", 4374, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Sign Up</a></p>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\turan\source\repos\TheSoundsOfPlaces\TheSoundsOfPlaces\Areas\Administration\Views\Login\Index.cshtml"
                                                                                 WriteLiteral(Context.Request.Query["returnUrl"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        </div>
        <!-- Sign In End -->
    </div>

    <!-- JavaScript Libraries -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""lib/chart/chart.min.js""></script>
    <script src=""lib/easing/easing.min.js""></script>
    <script src=""lib/waypoints/waypoints.min.js""></script>
    <script src=""lib/owlcarousel/owl.carousel.min.js""></script>
    <script src=""lib/tempusdominus/js/moment.min.js""></script>
    <script src=""lib/tempusdominus/js/moment-timezone.min.js""></script>
    <script src=""lib/tempusdominus/js/tempusdominus-bootstrap-4.min.js""></script>

    <!-- Template Javascript -->
    <script src=""js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
