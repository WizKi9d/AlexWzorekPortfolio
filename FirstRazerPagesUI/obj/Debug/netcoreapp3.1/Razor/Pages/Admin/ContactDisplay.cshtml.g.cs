#pragma checksum "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f099fef724585bfc559f3f2cb78de8aa4dd32ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FirstRazerPagesUI.Pages.Admin.Pages_Admin_ContactDisplay), @"mvc.1.0.razor-page", @"/Pages/Admin/ContactDisplay.cshtml")]
namespace FirstRazerPagesUI.Pages.Admin
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
#line 1 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\_ViewImports.cshtml"
using FirstRazerPagesUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f099fef724585bfc559f3f2cb78de8aa4dd32ab", @"/Pages/Admin/ContactDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3cfaa10cb0b408499a1fda66fadcd11136d41b3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_ContactDisplay : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
  
    ViewData["Title"] = "ContactDisplay";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <h4>Hi Alex</h4>\r\n    </div>\r\n    <div class=\"mt-4 container\">\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 12 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
                 for (int i = 0; i < Model.getAllItems.Count(); i++)
                {
                    /*
                        <div class="mx-5 alert alert-success" role="alert">
                            <div class="justify-content-between d-flex">
                                <h4 class="alert-heading">Name: @Model.getAllItems[i].FirstName @Model.getAllItems[i].LastName</h4>
                                <small>@Model.getAllItems[i].Date</small>
                            </div>
                            <p class="pt-3 pb-2">Message: @Model.getAllItems[i].Message</p>
                            <hr>
                            <p class="mb-0">Email: @Model.getAllItems[i].Email</p>
                        </div>
                        */


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"list-group-item list-group-item-action alert-primary\">\r\n                        <div class=\"d-flex w-100 justify-content-between\">\r\n                            <h5 class=\"mb-1\">");
#nullable restore
#line 28 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
                                        Write(Model.getAllItems[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
                                                                        Write(Model.getAllItems[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 29 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
                                                 Write(Model.getAllItems[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                        <p class=\"mb-1\">");
#nullable restore
#line 31 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
                                   Write(Model.getAllItems[i].Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <small class=\"text-muted\">Email: ");
#nullable restore
#line 32 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
                                                    Write(Model.getAllItems[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Users\smgalexwzorek\Desktop\Github reps\AlexWzorekPortfolio\FirstRazerPagesUI\Pages\Admin\ContactDisplay.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstRazerPagesUI.Pages.ContactDisplayModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstRazerPagesUI.Pages.ContactDisplayModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstRazerPagesUI.Pages.ContactDisplayModel>)PageContext?.ViewData;
        public FirstRazerPagesUI.Pages.ContactDisplayModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
