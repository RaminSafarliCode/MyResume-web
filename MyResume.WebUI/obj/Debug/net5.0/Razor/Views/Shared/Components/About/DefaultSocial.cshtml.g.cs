#pragma checksum "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd07e1d8e37a2d74d789095718f8768e6f4bd2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_DefaultSocial), @"mvc.1.0.view", @"/Views/Shared/Components/About/DefaultSocial.cshtml")]
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
#line 4 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.WebUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd07e1d8e37a2d74d789095718f8768e6f4bd2d", @"/Views/Shared/Components/About/DefaultSocial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aeb8320b164da628aef5bd4a6a3c516a94df607", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_About_DefaultSocial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h5 class=\"tittle\">Social Profiles</h5>\r\n<div class=\"social-icon bor-btm padding-25\">\r\n    <ul>\r\n");
#nullable restore
#line 7 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
         if (Model.FacebookLink != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 204, "\"", 230, 1);
#nullable restore
#line 10 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
WriteAttributeValue("", 211, Model.FacebookLink, 211, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-facebook\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 12 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
         if (Model.TwitterLink != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 387, "\"", 412, 1);
#nullable restore
#line 16 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
WriteAttributeValue("", 394, Model.TwitterLink, 394, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-twitter\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 18 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
         if (Model.LinkedinLink != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 569, "\"", 595, 1);
#nullable restore
#line 22 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
WriteAttributeValue("", 576, Model.LinkedinLink, 576, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-linkedin\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 24 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
         if (Model.GitHubLink != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 751, "\"", 775, 1);
#nullable restore
#line 28 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
WriteAttributeValue("", 758, Model.GitHubLink, 758, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-github\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 30 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
         if (Model.YoutubeLink != null)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 932, "\"", 957, 1);
#nullable restore
#line 35 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
WriteAttributeValue("", 939, Model.YoutubeLink, 939, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-youtube\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 37 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\DefaultSocial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
