#pragma checksum "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Login/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ee387fde47841b9851059005bc53f17abe70a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee387fde47841b9851059005bc53f17abe70a7a", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Login/Index/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/escan/Desktop/ComputerShop/ComputerShop/Views/Login/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee387fde47841b9851059005bc53f17abe70a7a4071", async() => {
                WriteLiteral(@"
	<title>Admin Panel</title>
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<!--===============================================================================================-->	
	<link rel=""icon"" type=""image/png"" href=""/Login_v6/images/icons/favicon.ico""/>
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/bootstrap/css/bootstrap.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/fonts/iconic/css/material-design-iconic-font.min.css"">
<!--=========================================================================================");
                WriteLiteral(@"======-->
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/animate/animate.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/css-hamburgers/hamburgers.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/animsition/css/animsition.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/select2/select2.min.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""/Login_v6/vendor/daterangepicker/daterangepicker.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" ");
                WriteLiteral("type=\"text/css\" href=\"/Login_v6/css/util.css\">\n\t<link rel=\"stylesheet\" type=\"text/css\" href=\"/Login_v6/css/main.css\">\n<!--===============================================================================================-->\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee387fde47841b9851059005bc53f17abe70a7a7432", async() => {
                WriteLiteral("\n\t\n\t<div class=\"limiter\">\n\t\t<div class=\"container-login100\">\n\t\t\t<div class=\"wrap-login100 p-t-85 p-b-20\">\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee387fde47841b9851059005bc53f17abe70a7a7816", async() => {
                    WriteLiteral(@"
					<span class=""login100-form-title p-b-70"">
						Admin Panel
					</span>
					<span class=""login100-form-avatar"">
						<img src=""/Login_v6/images/4.png"" alt=""AVATAR"">
					</span>

					<div class=""wrap-input100 validate-input m-t-85 m-b-35"" data-validate = ""Enter username"">
						<input class=""input100"" type=""text"" name=""UserName"">
						<span class=""focus-input100"" data-placeholder=""Username""></span>
					</div>

					<div class=""wrap-input100 validate-input m-b-50"" data-validate=""Enter password"">
						<input class=""input100"" type=""Password"" name=""Password"">
						<span class=""focus-input100"" data-placeholder=""Password""></span>
					</div>

					<div class=""container-login100-form-btn"">
						<button class=""login100-form-btn"">
							Login
						</button>
					</div>

					<ul class=""login-more p-t-190"">
						<li class=""m-b-8"">
							<span class=""txt1"">
								Forgot
							</span>

							<a href=""#"" class=""txt2"">
								Username / Password?
							</a>
						</li>

						<li>
							<span clas");
                    WriteLiteral("s=\"txt1\">\n\t\t\t\t\t\t\t\tDon???t have an account?\n\t\t\t\t\t\t\t</span>\n\n\t\t\t\t\t\t\t<a href=\"#\" class=\"txt2\">\n\t\t\t\t\t\t\t\tReturn Showcase\n\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t</li>\n\t\t\t\t\t</ul>\n\t\t\t\t");
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
                WriteLiteral(@"
			</div>
		</div>
	</div>
	

	<div id=""dropDownSelect1""></div>
	
<!--===============================================================================================-->
	<script src=""/Login_v6/vendor/jquery/jquery-3.2.1.min.js""></script>
<!--===============================================================================================-->
	<script src=""/Login_v6/vendor/animsition/js/animsition.min.js""></script>
<!--===============================================================================================-->
	<script src=""/Login_v6/vendor/bootstrap/js/popper.js""></script>
	<script src=""/Login_v6/vendor/bootstrap/js/bootstrap.min.js""></script>
<!--===============================================================================================-->
	<script src=""/Login_v6/vendor/select2/select2.min.js""></script>
<!--===============================================================================================-->
	<script src=""/Login_v6/vendor/daterangepicker/moment.min.js""></script>
	<script src=""/Login_v6/v");
                WriteLiteral(@"endor/daterangepicker/daterangepicker.js""></script>
<!--===============================================================================================-->
	<script src=""/Login_v6/vendor/countdowntime/countdowntime.js""></script>
<!--===============================================================================================-->
	<script src=""/Login_v6/js/main.js""></script>

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
            WriteLiteral("\n</html>");
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
