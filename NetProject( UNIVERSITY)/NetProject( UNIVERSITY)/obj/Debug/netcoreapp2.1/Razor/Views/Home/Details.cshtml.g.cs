#pragma checksum "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c81f40e6dac340c1fbb20be66a6ccf98781ba67c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c81f40e6dac340c1fbb20be66a6ccf98781ba67c", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0148e93fafed7a0bdbff718a0cc2f46e403048d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetProject__UNIVERSITY_.MarkingDate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validate(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("date"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image:url(\'/images/5.jpg\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Загальні деталі оцінювання";
    ViewData["Message"] = "All info about rating";

#line default
#line hidden
            BeginContext(158, 41, true);
            WriteLiteral("<h2 style=\"color:blue; margin-top:100px\">");
            EndContext();
            BeginContext(200, 17, false);
#line 6 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                    Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(217, 31, true);
            WriteLiteral("</h2>\r\n<h3 style=\"color:coral\">");
            EndContext();
            BeginContext(249, 19, false);
#line 7 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                   Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(268, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(275, 4757, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "327376f59184448993b23039f3b7f5f9", async() => {
                BeginContext(328, 1055, true);
                WriteLiteral(@"
    <style>
        .dropbtn {
            background-color: #4CAF50;
            color: white;
            padding: 16px;
            font-size: 16px;
            border: none;
        }

        .dropdown {
            position: relative;
            display: inline-block;
        }

        .dropdown-content {
            display: none;
            position: absolute;
            background-color: #f1f1f1;
            min-width: 160px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            z-index: 1;
        }

            .dropdown-content a {
                color: black;
                padding: 12px 16px;
                text-decoration: none;
                display: block;
            }

                .dropdown-content a:hover {
                    background-color: #ddd;
                }

        .dropdown:hover .dropdown-content {
            display: block;
        }

        .dropdown:hover .dropbtn {
            background-color: #3e8e4");
                WriteLiteral("1;\r\n        }\r\n    </style>\r\n\r\n");
                EndContext();
#line 52 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
     if (Model == null || Model.DateId == 0)
    {

#line default
#line hidden
                BeginContext(1436, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1444, 706, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed452022a4324dc6a7f0597970a21ad8", async() => {
                    BeginContext(1532, 158, true);
                    WriteLiteral("\r\n            <table>\r\n                <tr>\r\n                    <td><p>Введіть дату оцінювання :</p></td>\r\n                    <td>\r\n                        ");
                    EndContext();
                    BeginContext(1691, 118, false);
#line 59 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                   Write(Html.DropDownList("DateId", new SelectList(ViewBag.data, "DateId", "Date"), "Please select", new { @id = "ddlDates" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1809, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(1836, 59, false);
#line 60 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                   Write(Html.Hidden("Date", new DateTime(), new { @id = "hfDate" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1895, 248, true);
                    WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"submit\" value=\"Отправить\" formnovalidate /> </td>\r\n                    <td></td>\r\n                </tr>\r\n\r\n            </table>\r\n        ");
                    EndContext();
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
                EndContext();
                BeginContext(2150, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 70 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(2159, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 72 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
     if (Model != null && Model.DateId == 0)
    {

#line default
#line hidden
                BeginContext(2214, 49, true);
                WriteLiteral("        <script>alert(\"Оберіть дату!\")</script>\r\n");
                EndContext();
#line 75 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(2270, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 77 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
     if (Model != null && Model.DateId != 0)
    {

#line default
#line hidden
                BeginContext(2325, 56, true);
                WriteLiteral("        <p>Деталі оцінювання новин факультетів (окремо) ");
                EndContext();
                BeginContext(2382, 10, false);
#line 79 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                   Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(2392, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(2407, 85, false);
#line 80 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
   Write(Html.ActionLink("FacultyNewsbyFaculties", "GetFacultyNewsbyFaculties", "Home", Model));

#line default
#line hidden
                EndContext();
#line 80 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                                                              ;

#line default
#line hidden
                BeginContext(2495, 53, true);
                WriteLiteral("        <p>Деталі оцінювання новин факультетів (всі) ");
                EndContext();
                BeginContext(2549, 10, false);
#line 81 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(2559, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(2574, 69, false);
#line 82 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
   Write(Html.ActionLink("FacultyNewsall", "GetFacultyNewsall", "Home", Model));

#line default
#line hidden
                EndContext();
#line 82 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                                              ;

#line default
#line hidden
                BeginContext(2646, 51, true);
                WriteLiteral("        <p>Деталі оцінювання новин кафедр (окремо) ");
                EndContext();
                BeginContext(2698, 10, false);
#line 83 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                              Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(2708, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(2723, 91, false);
#line 84 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
   Write(Html.ActionLink("DepartmentNewsbyFaculties", "GetDepartmentNewsbyFaculties", "Home", Model));

#line default
#line hidden
                EndContext();
#line 84 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                                                                    ;

#line default
#line hidden
                BeginContext(2817, 48, true);
                WriteLiteral("        <p>Деталі оцінювання новин кафедр (всі) ");
                EndContext();
                BeginContext(2866, 10, false);
#line 85 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                           Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(2876, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(2891, 75, false);
#line 86 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
   Write(Html.ActionLink("DepartmentNewsall", "GetDepartmentNewsall", "Home", Model));

#line default
#line hidden
                EndContext();
#line 86 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                                                    ;

#line default
#line hidden
                BeginContext(2969, 49, true);
                WriteLiteral("        <p>Деталі оцінювання викладачів (окремо) ");
                EndContext();
                BeginContext(3019, 10, false);
#line 87 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                            Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(3029, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(3044, 81, false);
#line 88 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
   Write(Html.ActionLink("LecturersbyFaculties", "GetLecturersbyFaculties", "Home", Model));

#line default
#line hidden
                EndContext();
#line 88 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                                                          ;

#line default
#line hidden
                BeginContext(3128, 46, true);
                WriteLiteral("        <p>Деталі оцінювання викладачів (всі) ");
                EndContext();
                BeginContext(3175, 10, false);
#line 89 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                         Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(3185, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(3200, 65, false);
#line 90 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
   Write(Html.ActionLink("Lecturersall", "GetLecturersall", "Home", Model));

#line default
#line hidden
                EndContext();
#line 90 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Details.cshtml"
                                                                          ;
    }
    

#line default
#line hidden
                BeginContext(5023, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5032, 290, true);
            WriteLiteral(@"

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"">
    $(""body"").on(""change"", ""#ddlDates"", function () {
        $(""#hfDate"").val($(this).find(""option:selected"").text());
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetProject__UNIVERSITY_.MarkingDate> Html { get; private set; }
    }
}
#pragma warning restore 1591
