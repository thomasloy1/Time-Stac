#pragma checksum "C:\Users\tommy\Documents\GitHub\Time-Stac\alpha\time_stacc_alpha_0_02\time_stacc_alpha_0_02\Pages\Donate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b32673d386302599c72562e5463e6689b23d85c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(time_stacc_alpha_0_02.Pages.Pages_Donate), @"mvc.1.0.razor-page", @"/Pages/Donate.cshtml")]
namespace time_stacc_alpha_0_02.Pages
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
#line 1 "C:\Users\tommy\Documents\GitHub\Time-Stac\alpha\time_stacc_alpha_0_02\time_stacc_alpha_0_02\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tommy\Documents\GitHub\Time-Stac\alpha\time_stacc_alpha_0_02\time_stacc_alpha_0_02\Pages\_ViewImports.cshtml"
using time_stacc_alpha_0_02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tommy\Documents\GitHub\Time-Stac\alpha\time_stacc_alpha_0_02\time_stacc_alpha_0_02\Pages\_ViewImports.cshtml"
using time_stacc_alpha_0_02.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32673d386302599c72562e5463e6689b23d85c7", @"/Pages/Donate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5bed8bb5b63ed1c14a78ecafdd761aecdb80a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Donate : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\tommy\Documents\GitHub\Time-Stac\alpha\time_stacc_alpha_0_02\time_stacc_alpha_0_02\Pages\Donate.cshtml"
  
    ViewData["Title"] = "Donate";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 
<h1>Donate</h1>

<p>
    This web app is made possible with donations from people like you. Please consider donating for using this service.
</p>

<p>
    <button onclick=""window.location.href = 'https://www.paypal.me/legittommyloy';"">PayPal.Me</button>
</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<time_stacc_alpha_0_02.Pages.Shared.DonateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<time_stacc_alpha_0_02.Pages.Shared.DonateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<time_stacc_alpha_0_02.Pages.Shared.DonateModel>)PageContext?.ViewData;
        public time_stacc_alpha_0_02.Pages.Shared.DonateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591