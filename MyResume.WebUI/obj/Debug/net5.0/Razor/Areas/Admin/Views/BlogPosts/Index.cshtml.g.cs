#pragma checksum "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a830b953ed3369041308ab1a0644ae27a70d653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogPosts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogPosts/Index.cshtml")]
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
#line 3 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ResumeModel.Bio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ResumeModel.Experience;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ProjectsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ProjectCategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a830b953ed3369041308ab1a0644ae27a70d653", @"/Areas/Admin/Views/BlogPosts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e900e6758302126af45b67d030524d2cd7068e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BlogPosts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogPost>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.customize.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a830b953ed3369041308ab1a0644ae27a70d65310162", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"

    <div class=""page-wrapper"">
        <div class=""page-header"">
            <div class=""row align-items-end"">
                <div class=""col-lg-8"">
                    <div class=""page-header-title"">
                        <div class=""d-inline"">
                            <h4>Bootstrap Border Sizes</h4>
                            <span>
                                lorem ipsum dolor sit amet, consectetur adipisicing
                                elit
                            </span>
                        </div> 
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""page-header-breadcrumb"">
                        <ul class=""breadcrumb-title"">
                            <li class=""breadcrumb-item"" style=""float: left;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a830b953ed3369041308ab1a0644ae27a70d65312284", async() => {
                WriteLiteral(" <i class=\"feather icon-home\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </li>

                            <li class=""breadcrumb-item"" style=""float: left;"">
                                <span>BlogPosts</span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""page-body"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5>Horizontal Borders</h5>
                    <span>
                        Example of <code>horizontal</code> table borders. This is a
                        default table border style attached to <code>.table</code> class.
                        All borders have the same grey color and style, table itself doesn't
                        have a border, but you can add this border using
                        <code>.table-framed</code> class added to the table with
                        <code>.table</code> class.
                    </span>

  ");
            WriteLiteral(@"              </div>
                <div class=""card-block table-border-style"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>

                                    </th>
                                    <th>
                                        ");
#nullable restore
#line 66 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 69 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 72 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                    <th class=\"operations\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a830b953ed3369041308ab1a0644ae27a70d65316488", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-plus\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 83 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"image-cell\">\r\n");
#nullable restore
#line 87 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                         if (!string.IsNullOrWhiteSpace(item.ImagePath))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a830b953ed3369041308ab1a0644ae27a70d65318795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3822, "~/uploads/images/", 3822, 17, true);
#nullable restore
#line 89 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
AddHtmlAttributeValue("", 3839, item.ImagePath, 3839, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td class=\"ellipse\">\r\n                                        ");
#nullable restore
#line 93 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"ellipse \">\r\n                                        ");
#nullable restore
#line 96 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                   Write(item.Body.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 99 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td class=\"operations table-imaged\">\r\n");
#nullable restore
#line 103 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                         if (@item.PublishedDate == null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-sm btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4762, "\"", 4808, 6);
            WriteAttributeValue("", 4772, "publishDate(", 4772, 12, true);
#nullable restore
#line 105 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
WriteAttributeValue("", 4784, item.Id, 4784, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4792, ",", 4792, 1, true);
            WriteAttributeValue(" ", 4793, "\'", 4794, 2, true);
#nullable restore
#line 105 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
WriteAttributeValue("", 4795, item.Title, 4795, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4806, "\')", 4806, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-upload\"></i></a>\n");
#nullable restore
#line 106 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a830b953ed3369041308ab1a0644ae27a70d65323715", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pencil\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a830b953ed3369041308ab1a0644ae27a70d65326060", async() => {
                WriteLiteral("<i class=\"fa-solid fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5273, "\"", 5320, 6);
            WriteAttributeValue("", 5283, "removeEntity(", 5283, 13, true);
#nullable restore
#line 109 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
WriteAttributeValue("", 5296, item.Id, 5296, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5304, ",", 5304, 1, true);
            WriteAttributeValue(" ", 5305, "\'", 5306, 2, true);
#nullable restore
#line 109 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
WriteAttributeValue("", 5307, item.Title, 5307, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5318, "\')", 5318, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-trash-can\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 112 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 119 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a830b953ed3369041308ab1a0644ae27a70d65330219", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a830b953ed3369041308ab1a0644ae27a70d65331320", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a830b953ed3369041308ab1a0644ae27a70d65332421", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script class=""removeable"">
        function removeEntity(id, name){
            swal(`Are you sure you want to delete ${name}?`, {
                title: ""Diqqet!"",
                text: `Are you sure you want to delete ${name}?`,
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
           buttons: [""No"", ""Yes""]
            })
               .then((value)=>{

                   if(value == true){

                       let vToken = $('[name=__RequestVerificationToken]').val();

                       let formData = new FormData();
                   formData.set('__RequestVerificationToken', vToken);
                   formData.set('id',id);

                       $.ajax({
                           url: `");
#nullable restore
#line 148 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                            Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                       type: 'POST',
                       data:formData,
                       contentType: false,
                       processData: false,
                           success: function(response){
                               console.log(response)
                               if(response.error == true){
                                   toaster.error(response.message,""Xeta"");
                                   return;
                               }
                               location.reload();
                           },
                           error: function(errorResponse){
                               console.error(errorResponse);
                           }
                       });
                   }


               });

        }

        function publishDate(id, name) {
            swal(`Are you sure you want to publish ${name}?`, {
                title: ""Diqqet!"",
                text: `Are you sure you want to publish ${name}?`");
                WriteLiteral(@",
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
                buttons: [""No"", ""Yes""]
            })
                .then((value) => {

                    if (value == true) {

                        let vToken = $('[name=__RequestVerificationToken]').val();

                        let formData = new FormData();
                        formData.set('__RequestVerificationToken', vToken);
                        formData.set('id', id);

                        $.ajax({
                            url: `");
#nullable restore
#line 192 "C:\Users\ramin\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\BlogPosts\Index.cshtml"
                             Write(Url.Action("Publish"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                            type: 'POST',
                            data: formData,
                            contentType: false,
                            processData: false,
                            success: function (response) {
                                console.log(response)
                                if (response.error == true) {
                                    toaster.error(response.message, ""Xeta"");
                                    return;
                                }
                                location.reload();
                            },
                            error: function (errorResponse) {
                                console.error(errorResponse);
                            }
                        });
                    }


                });

        }
    </script>
     ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogPost>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
