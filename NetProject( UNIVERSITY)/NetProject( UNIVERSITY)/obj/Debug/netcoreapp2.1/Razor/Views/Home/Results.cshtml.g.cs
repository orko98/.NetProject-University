#pragma checksum "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07bab90690923ae3c4455e0eb5d258096c60e017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Results.cshtml", typeof(AspNetCore.Views_Home_Results))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07bab90690923ae3c4455e0eb5d258096c60e017", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0148e93fafed7a0bdbff718a0cc2f46e403048d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NetProject__UNIVERSITY_.Models.ResultElement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Result"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validate(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image:url(\'/images/5.jpg\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Results";

#line default
#line hidden
            BeginContext(111, 39, true);
            WriteLiteral("\r\n<h2 style=\"color:blue\">Results</h2>\r\n");
            EndContext();
            BeginContext(150, 2524, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2d7864a7df4bb3a3ecb1dd84a7b3f6", async() => {
                BeginContext(203, 535, true);
                WriteLiteral(@"
    <style>
        table#result tr {
            background-color: white;
            color: blue;
            border-color: crimson;
        }

        table#result th {
            background-color: black;
            color: white;
            border-color: crimson;
        }

        table, th, td {
            font-size: 20px;
            border: 2px solid crimson;
            border-collapse: collapse;
        }
        td{
            text-align: right;
        }
       
    </style>





    ");
                EndContext();
                BeginContext(738, 637, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a012871bfe8e4bb38df1a416bbe2628f", async() => {
                    BeginContext(813, 138, true);
                    WriteLiteral("\r\n        <table>\r\n            <tr>\r\n                <td><p>Введіть дату оцінювання :</p></td>\r\n                <td>\r\n                    ");
                    EndContext();
                    BeginContext(952, 118, false);
#line 42 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
               Write(Html.DropDownList("DateId", new SelectList(ViewBag.data, "DateId", "Date"), "Please select", new { @id = "ddlDates" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1070, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(1093, 59, false);
#line 43 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
               Write(Html.Hidden("Date", new DateTime(), new { @id = "hfDate" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1152, 216, true);
                    WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"submit\" value=\"Отправить\" formnovalidate /> </td>\r\n                <td></td>\r\n            </tr>\r\n\r\n        </table>\r\n    ");
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
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1375, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
     if (Model != null && Model.Count() == 0)
    {

#line default
#line hidden
                BeginContext(1431, 49, true);
                WriteLiteral("        <script>alert(\"Оберіть дату!\")</script>\r\n");
                EndContext();
#line 56 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
    }

#line default
#line hidden
                BeginContext(1487, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 57 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
     if (Model != null && Model.Count() > 0)
    {

#line default
#line hidden
                BeginContext(1540, 99, true);
                WriteLiteral("        <table id=\"mainResult\">\r\n            <tr>\r\n                <th scope=\"col\">Факультет</th>\r\n");
                EndContext();
#line 62 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                 for (int i = 0; i < Model.First().CriteriaMarks.Count; i++)
                {

#line default
#line hidden
                BeginContext(1736, 49, true);
                WriteLiteral("                    <th scope=\"col\" colspan=\"2\"> ");
                EndContext();
                BeginContext(1786, 36, false);
#line 64 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                                            Write(Model.First().CriteriaMarks[i].Item1);

#line default
#line hidden
                EndContext();
                BeginContext(1822, 7, true);
                WriteLiteral("</th>\r\n");
                EndContext();
#line 65 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                }

#line default
#line hidden
                BeginContext(1848, 19, true);
                WriteLiteral("            </tr>\r\n");
                EndContext();
#line 67 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
             foreach (var result in Model)
            {

#line default
#line hidden
                BeginContext(1926, 59, true);
                WriteLiteral("                <tr>\r\n                    <th rowspan=\"2\"> ");
                EndContext();
                BeginContext(1986, 18, false);
#line 70 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                                Write(result.FacultyName);

#line default
#line hidden
                EndContext();
                BeginContext(2004, 9, true);
                WriteLiteral("</th>\r\n\r\n");
                EndContext();
#line 72 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                     foreach (var criteriaMark in result.CriteriaMarks)
                    {

#line default
#line hidden
                BeginContext(2109, 58, true);
                WriteLiteral("                        <td>\r\n                            ");
                EndContext();
                BeginContext(2168, 22, false);
#line 75 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                       Write(criteriaMark.Item2.Ukr);

#line default
#line hidden
                EndContext();
                BeginContext(2190, 73, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td rowspan=\"2\">");
                EndContext();
                BeginContext(2264, 22, false);
#line 77 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                                   Write(criteriaMark.Item2.Sum);

#line default
#line hidden
                EndContext();
                BeginContext(2286, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 78 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                    }

#line default
#line hidden
                BeginContext(2316, 23, true);
                WriteLiteral("                </tr>\r\n");
                EndContext();
                BeginContext(2341, 22, true);
                WriteLiteral("                <tr>\r\n");
                EndContext();
#line 82 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                     foreach (var criteriaMark in result.CriteriaMarks)
                    {

#line default
#line hidden
                BeginContext(2459, 58, true);
                WriteLiteral("                        <td>\r\n                            ");
                EndContext();
                BeginContext(2518, 22, false);
#line 85 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                       Write(criteriaMark.Item2.Eng);

#line default
#line hidden
                EndContext();
                BeginContext(2540, 33, true);
                WriteLiteral("\r\n                        </td>\r\n");
                EndContext();
#line 87 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"
                    }

#line default
#line hidden
                BeginContext(2596, 23, true);
                WriteLiteral("                </tr>\r\n");
                EndContext();
#line 89 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"

            }

#line default
#line hidden
                BeginContext(2636, 20, true);
                WriteLiteral("\r\n        </table>\r\n");
                EndContext();
#line 93 "C:\Перекинуте\Проект Оцінювання сайтів\NetProject-University-master\.NetProject-University-master\NetProject( UNIVERSITY)\NetProject( UNIVERSITY)\Views\Home\Results.cshtml"

    }

#line default
#line hidden
                BeginContext(2665, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2674, 290, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NetProject__UNIVERSITY_.Models.ResultElement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
