#pragma checksum "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff783cc138b6f2d1d96dcf547f196ad30a4d376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Test.cshtml", typeof(AspNetCore.Views_Home_Test))]
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
#line 1 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\_ViewImports.cshtml"
using NetProject__UNIVERSITY_;

#line default
#line hidden
#line 2 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\_ViewImports.cshtml"
using NetProject__UNIVERSITY_.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff783cc138b6f2d1d96dcf547f196ad30a4d376", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0148e93fafed7a0bdbff718a0cc2f46e403048d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NetProject__UNIVERSITY_.CriteriaMark>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(100, 28, true);
            WriteLiteral("\r\n<h2>Test</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0200249a04d74834ab0e14ed1367e2d5", async() => {
                BeginContext(151, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(165, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 40, false);
#line 16 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 45, false);
#line 19 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayNameFor(model => model.FacultyId));

#line default
#line hidden
            EndContext();
            BeginContext(399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(455, 42, false);
#line 22 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayNameFor(model => model.DateId));

#line default
#line hidden
            EndContext();
            BeginContext(497, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(553, 46, false);
#line 25 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayNameFor(model => model.CriteriaId));

#line default
#line hidden
            EndContext();
            BeginContext(599, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(655, 50, false);
#line 28 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayNameFor(model => model.CriteriaMarkId));

#line default
#line hidden
            EndContext();
            BeginContext(705, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(823, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(872, 39, false);
#line 37 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(911, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(967, 44, false);
#line 40 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayFor(modelItem => item.FacultyId));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1067, 41, false);
#line 43 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateId));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1164, 45, false);
#line 46 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayFor(modelItem => item.CriteriaId));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1265, 49, false);
#line 49 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.DisplayFor(modelItem => item.CriteriaMarkId));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1370, 65, false);
#line 52 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1456, 71, false);
#line 53 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1548, 69, false);
#line 54 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Test.cshtml"
}

#line default
#line hidden
            BeginContext(1656, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NetProject__UNIVERSITY_.CriteriaMark>> Html { get; private set; }
    }
}
#pragma warning restore 1591
