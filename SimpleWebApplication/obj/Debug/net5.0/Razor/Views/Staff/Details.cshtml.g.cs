#pragma checksum "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e65d33c9caf9549a43103c62abdc1a406ede104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Details), @"mvc.1.0.view", @"/Views/Staff/Details.cshtml")]
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
#line 1 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\_ViewImports.cshtml"
using SimpleWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\_ViewImports.cshtml"
using SimpleWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e65d33c9caf9549a43103c62abdc1a406ede104", @"/Views/Staff/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"189040b4a1eb08a05457e5559293a1d9c05a429d", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleWebApplication.Models.Staff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Staff</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 64 "C:\Users\User\OneDrive - student.newinti.edu.my\Desktop\INTI BCSCUN\Sem8 Internship\.NET Core Web App\Simple-.NET-Core-Web-App\SimpleWebApplication\Views\Staff\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e65d33c9caf9549a43103c62abdc1a406ede10411152", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleWebApplication.Models.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591
