#pragma checksum "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c22019f4e496b24a5feca4b5be1bef33e7e381d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pressures_Index), @"mvc.1.0.view", @"/Views/Pressures/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pressures/Index.cshtml", typeof(AspNetCore.Views_Pressures_Index))]
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
#line 1 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\_ViewImports.cshtml"
using ManualAuth;

#line default
#line hidden
#line 2 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\_ViewImports.cshtml"
using ManualAuth.Models;

#line default
#line hidden
#line 3 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\_ViewImports.cshtml"
using ManualAuth.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c22019f4e496b24a5feca4b5be1bef33e7e381d", @"/Views/Pressures/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ff57cfe37046da854dfa212dbf9e8f92c14b72", @"/Views/_ViewImports.cshtml")]
    public class Views_Pressures_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ManualAuth.Models.Pressure>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 36, true);
            WriteLiteral("\r\n<h1>My pressures</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c22019f4e496b24a5feca4b5be1bef33e7e381d5050", async() => {
                BeginContext(150, 94, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Add new result\" class=\"btn btn-outline-success\" />\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(248, 55, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<thead>\r\n    <tr>\r\n        <th>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
               int systolic = 0;
                int diastolic = 0;

                double systolic_std = 0;
                double diastolic_std = 0;

                int count = 0;
                foreach (var item in Model)
                {
                    count++;
                    systolic += item.PressureSYSValue;
                    diastolic += item.PressureDIAValue;
                }
                if (count > 0)
                {
                    systolic /= count;
                    diastolic /= count;

                    if (count > 1)
                    {
                        double sys_calc = 0;
                        double dia_calc = 0;

                        foreach (var item in Model)
                        {
                            sys_calc += Math.Pow(item.PressureSYSValue - systolic, 2);
                            dia_calc += Math.Pow(item.PressureDIAValue - diastolic, 2);

                        }

                        systolic_std = Math.Sqrt(sys_calc / count - 1);
                        systolic_std = Math.Round(systolic_std, 3);

                        diastolic_std = Math.Sqrt(dia_calc / count - 1);
                        diastolic_std = Math.Round(diastolic_std, 3);


                    }

                }




            

#line default
#line hidden
            BeginContext(1655, 234, true);
            WriteLiteral("\r\n        </th>\r\n\r\n    </tr>\r\n</thead>\r\n\r\n\r\n<div class=\"row\" >\r\n    <div class=\"col-sm-6\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <center>\r\n                    Mean Systolic Pressure Level:  ");
            EndContext();
            BeginContext(1890, 8, false);
#line 81 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
                                              Write(systolic);

#line default
#line hidden
            EndContext();
            BeginContext(1898, 99, true);
            WriteLiteral("\r\n                    &nbsp;\r\n                    <br />\r\n                    Standard Deviation:  ");
            EndContext();
            BeginContext(1998, 12, false);
#line 84 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
                                    Write(systolic_std);

#line default
#line hidden
            EndContext();
            BeginContext(2010, 243, true);
            WriteLiteral("\r\n                </center>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <center>\r\n                    Mean Diastolic Pressure :  ");
            EndContext();
            BeginContext(2254, 9, false);
#line 93 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
                                          Write(diastolic);

#line default
#line hidden
            EndContext();
            BeginContext(2263, 99, true);
            WriteLiteral("\r\n                    &nbsp;\r\n                    <br />\r\n                    Standard Deviation:  ");
            EndContext();
            BeginContext(2363, 13, false);
#line 96 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
                                    Write(diastolic_std);

#line default
#line hidden
            EndContext();
            BeginContext(2376, 438, true);
            WriteLiteral(@"
                </center>                
            </div>
        </div>
    </div>
</div>



<table class=""table"" >

    <thead>
        <tr>
            <th>
                Date and Time
            </th>
            <th>
                Systolic Pressure
            </th>
            <th>
                Diastolic Pressure
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 122 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2863, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2924, 35, false);
#line 126 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
               Write(item.PressureDateTime.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(2959, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3027, 51, false);
#line 129 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PressureSYSValue));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3146, 51, false);
#line 132 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PressureDIAValue));

#line default
#line hidden
            EndContext();
            BeginContext(3197, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3264, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c22019f4e496b24a5feca4b5be1bef33e7e381d12452", async() => {
                BeginContext(3309, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 135 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3317, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3341, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c22019f4e496b24a5feca4b5be1bef33e7e381d14809", async() => {
                BeginContext(3389, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 136 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3400, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3424, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c22019f4e496b24a5feca4b5be1bef33e7e381d17172", async() => {
                BeginContext(3471, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 137 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3481, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 140 "C:\Users\scara\Desktop\ManualAuth (ver 6)\ManualAuth\Views\Pressures\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3536, 36, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ManualAuth.Models.Pressure>> Html { get; private set; }
    }
}
#pragma warning restore 1591
