<<<<<<< HEAD
#pragma checksum "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d4835bbf4b98fcbf5bdadb47f288ce68aa99968"
=======
#pragma checksum "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d4835bbf4b98fcbf5bdadb47f288ce68aa99968"
>>>>>>> 084f3d0b7fa4e711bda1eb0ec0c9948185ea5d99
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Details), @"mvc.1.0.view", @"/Views/Questions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Details.cshtml", typeof(AspNetCore.Views_Questions_Details))]
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
#line 1 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject;

#line default
#line hidden
#line 2 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4835bbf4b98fcbf5bdadb47f288ce68aa99968", @"/Views/Questions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e9000fdfbf39452f2df6e36ab8c5a2875360c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssistMeProject.Models.Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Answers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Question</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(208, 41, false);
#line 14 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(293, 37, false);
#line 17 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(374, 47, false);
#line 20 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(421, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(465, 43, false);
#line 23 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(552, 40, false);
#line 26 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(592, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(636, 36, false);
#line 29 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(672, 120, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(793, 35, false);
#line 37 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.Answers));

#line default
#line hidden
            EndContext();
            BeginContext(828, 50, true);
            WriteLiteral("\r\n            </th>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
         foreach (var item in Model.Answers)
        {

#line default
#line hidden
            BeginContext(935, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(996, 37, false);
#line 46 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1101, 46, false);
#line 49 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1215, 39, false);
#line 52 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 55 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1309, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1346, 102, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2054901fc8204cf299acbd016ad60c8b", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50d51f99f4144c09a5e98ef607cc233d", async() => {
>>>>>>> 084f3d0b7fa4e711bda1eb0ec0c9948185ea5d99
                BeginContext(1427, 17, true);
                WriteLiteral("Agregar Respuesta");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-QuestionID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
                                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["QuestionID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-QuestionID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["QuestionID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1448, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1456, 38, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848461b40b294921811f058f084748d9", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e91efea5c30c40ff8c74a0ce8e6f6f31", async() => {
>>>>>>> 084f3d0b7fa4e711bda1eb0ec0c9948185ea5d99
                BeginContext(1478, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1494, 287, true);
            WriteLiteral(@"
</div>

<!-- omitido breadcrumbs del template agregar luego...-->
<section class=""container main-content"">
    <div class=""row"">
        <div class=""col-md-9"">
            <article class=""question single-question question-type-normal"">
                <h2>
                    ");
            EndContext();
            BeginContext(1782, 37, false);
#line 70 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 356, true);
            WriteLiteral(@"
                </h2>
                <a class=""question-report"" href=""#"">Report</a>
                <div class=""question-type-main""><i class=""icon-question-sign""></i>Question</div>
                <div class=""question-inner"">
                    <div class=""clearfix""></div>
                    <div class=""question-desc"">
                        ");
            EndContext();
            BeginContext(2176, 43, false);
#line 77 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 639, true);
            WriteLiteral(@"
                    </div>
                    <div class=""question-details"">
                        <span class=""question-answered question-answered-done""><i class=""icon-ok""></i>solved</span><!--Aqui poner icono si la pregunta fue respondidad o no-->
                        <span class=""question-favorite""><i class=""icon-star""></i>5</span><!--num de votos interesantes-->
                    </div>
                    <!--No se va usar wordpress--> <!--<span class=""question-category""><a href=""#""><i class=""icon-folder-close""></i>wordpress</a></span>-->
                    <span class=""question-date""><i class=""icon-time""></i>");
            EndContext();
            BeginContext(2859, 36, false);
#line 84 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
                                                                    Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2895, 100, true);
            WriteLiteral("</span>\r\n                    <span class=\"question-comment\"><a href=\"#\"><i class=\"icon-comment\"></i>");
            EndContext();
            BeginContext(2996, 45, false);
#line 85 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.Answers.Count));

#line default
#line hidden
            EndContext();
            BeginContext(3041, 2521, true);
            WriteLiteral(@"</a></span> <!--num de respuestas-->
                    <span class=""question-view""><i class=""icon-user""></i>70 views</span>
                    <span class=""single-question-vote-result"">+22</span>
                    <ul class=""single-question-vote"">
                        <li><a href=""#"" class=""single-question-vote-up"" title=""Like""><i class=""icon-thumbs-up""></i></a></li>
                    </ul>
                    <div class=""clearfix""></div>
                </div>
            </article>

            <div class=""share-tags page-content"">
                <div class=""question-tags"">
                    <i class=""icon-tags""></i>
                    <a href=""#"">wordpress</a>, <a href=""#"">question</a>, <a href=""#"">developer</a>
                </div>

                <div class=""share-inside""><i class=""icon-share-alt""></i>Share</div>
                <div class=""clearfix""></div>
            </div><!-- End share-tags -->

            <div class=""about-author clearfix"">
                <div");
            WriteLiteral(@" class=""author-image"">
                    <a href=""#"" original-title=""admin"" class=""tooltip-n""><img alt="""" src=""http://placehold.it/60x60/FFF/444""></a>
                </div>
                <div class=""author-bio"">
                    <h4>About the Author</h4>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed viverra auctor neque. Nullam lobortis, sapien vitae lobortis tristique.
                </div>
            </div><!-- End about-author -->

            <div id=""related-posts"">
                <h2>Related questions</h2>
                <ul class=""related-posts"">
                    <li class=""related-item""><h3><a href=""#""><i class=""icon-double-angle-right""></i>This Is My Second Poll Question</a></h3></li>
                    <li class=""related-item""><h3><a href=""#""><i class=""icon-double-angle-right""></i>This is my third Question</a></h3></li>
                    <li class=""related-item""><h3><a href=""#""><i class=""icon-double-angle-right""></i>This is my fourth");
            WriteLiteral(@" Question</a></h3></li>
                    <li class=""related-item""><h3><a href=""#""><i class=""icon-double-angle-right""></i>This is my fifth Question</a></h3></li>
                </ul>
            </div><!-- End related-posts -->

            <div id=""answerlist"">


            </div>

            <div id=""respond"" class=""comment-respond page-content clearfix"">
                <div class=""boxedtitle page-title""><h2>Leave a reply</h2></div>
                ");
            EndContext();
            BeginContext(5562, 1533, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191c4b783c5645469ebf6f8aa6cf9fb5", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60877550ae4a4d1aa98a1a21267b9bc5", async() => {
>>>>>>> 084f3d0b7fa4e711bda1eb0ec0c9948185ea5d99
                BeginContext(5630, 1458, true);
                WriteLiteral(@"
                    <div id=""respond-inputs"" class=""clearfix"">
                        <p>
                            <label class=""required"" for=""comment_name"">Name<span>*</span></label>
                            <input name=""author"" type=""text"" value="""" id=""comment_name"" aria-required=""true"">
                        </p>
                        <p>
                            <label class=""required"" for=""comment_email"">E-Mail<span>*</span></label>
                            <input name=""email"" type=""text"" value="""" id=""comment_email"" aria-required=""true"">
                        </p>
                        <p class=""last"">
                            <label class=""required"" for=""comment_url"">Website<span>*</span></label>
                            <input name=""url"" type=""text"" value="""" id=""comment_url"">
                        </p>
                    </div>
                    <div id=""respond-textarea"">
                        <p>
                            <label class=""required"" ");
                WriteLiteral(@"for=""comment"">Comment<span>*</span></label>
                            <textarea id=""comment"" name=""comment"" aria-required=""true"" cols=""58"" rows=""8""></textarea>
                        </p>
                    </div>
                    <p class=""form-submit"">
                        <input name=""submit"" type=""submit"" id=""submit"" value=""Post your answer"" class=""button small color"">
                    </p>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7095, 1131, true);
            WriteLiteral(@"
            </div>

            <div class=""post-next-prev clearfix"">
                <p class=""prev-post"">
                    <a href=""#""><i class=""icon-double-angle-left""></i>&nbsp;Prev question</a>
                </p>
                <p class=""next-post"">
                    <a href=""#"">Next question&nbsp;<i class=""icon-double-angle-right""></i></a>
                </p>
            </div><!-- End post-next-prev -->
        </div><!-- End main -->
        <aside class=""col-md-3 sidebar"">
            <div class=""widget widget_stats"">
                <h3 class=""widget_title"">Stats</h3>
                <div class=""ul_list ul_list-icon-ok"">
                    <ul>
                        <li><i class=""icon-question-sign""></i>Questions ( <span>20</span> )</li>
                        <li><i class=""icon-comment""></i>Answers ( <span>50</span> )</li>
                    </ul>
                </div>
            </div>



            <div class=""widget widget_login"">
                <h3 c");
            WriteLiteral("lass=\"widget_title\">Login</h3>\r\n                <div class=\"form-style form-style-2\">\r\n                    ");
            EndContext();
            BeginContext(8226, 1240, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "444b4470194d4dcba37577dacf815601", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b227a7ffb7c452f93092d51b87508a9", async() => {
>>>>>>> 084f3d0b7fa4e711bda1eb0ec0c9948185ea5d99
                BeginContext(8232, 1227, true);
                WriteLiteral(@"
                        <div class=""form-inputs clearfix"">
                            <p class=""login-text"">
                                <input type=""text"" value=""Username"" onfocus=""if (this.value == 'Username') {this.value = '';}"" onblur=""if (this.value == '') {this.value = 'Username';}"">
                                <i class=""icon-user""></i>
                            </p>
                            <p class=""login-password"">
                                <input type=""password"" value=""Password"" onfocus=""if (this.value == 'Password') {this.value = '';}"" onblur=""if (this.value == '') {this.value = 'Password';}"">
                                <i class=""icon-lock""></i>
                                <a href=""#"">Forget</a>
                            </p>
                        </div>
                        <p class=""form-submit login-submit"">
                            <input type=""submit"" value=""Log in"" class=""button color small login-submit submit"">
                        </p");
                WriteLiteral(">\r\n                        <div class=\"rememberme\">\r\n                            <label><input type=\"checkbox\" checked=\"checked\"> Remember Me</label>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9466, 2927, true);
            WriteLiteral(@"
                    <ul class=""login-links login-links-r"">
                        <li><a href=""#"">Register</a></li>
                    </ul>
                    <div class=""clearfix""></div>
                </div>
            </div>

            <div class=""widget widget_highest_points"">
                <h3 class=""widget_title"">Highest points</h3>
                <ul>
                    <li>
                        <div class=""author-img"">
                            <a href=""#""><img width=""60"" height=""60"" src=""http://placehold.it/60x60/FFF/444"" alt=""""></a>
                        </div>
                        <h6><a href=""#"">admin</a></h6>
                        <span class=""comment"">12 Points</span>
                    </li>
                    <li>
                        <div class=""author-img"">
                            <a href=""#""><img width=""60"" height=""60"" src=""http://placehold.it/60x60/FFF/444"" alt=""""></a>
                        </div>
                        <h6><a href");
            WriteLiteral(@"=""#"">vbegy</a></h6>
                        <span class=""comment"">10 Points</span>
                    </li>
                    <li>
                        <div class=""author-img"">
                            <a href=""#""><img width=""60"" height=""60"" src=""http://placehold.it/60x60/FFF/444"" alt=""""></a>
                        </div>
                        <h6><a href=""#"">ahmed</a></h6>
                        <span class=""comment"">5 Points</span>
                    </li>
                </ul>
            </div>

            <div class=""widget widget_tag_cloud"">
                <h3 class=""widget_title"">Tags</h3>
                <a href=""#"">projects</a>
                <a href=""#"">Portfolio</a>
                <a href=""#"">Wordpress</a>
                <a href=""#"">Html</a>
                <a href=""#"">Css</a>
                <a href=""#"">jQuery</a>
                <a href=""#"">2code</a>
                <a href=""#"">vbegy</a>
            </div>

            <div class=""widget"">
            ");
            WriteLiteral(@"    <h3 class=""widget_title"">Recent Questions</h3>
                <ul class=""related-posts"">
                    <li class=""related-item"">
                        <h3><a href=""#"">This is my first Question</a></h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                        <div class=""clear""></div><span>Feb 22, 2014</span>
                    </li>
                    <li class=""related-item"">
                        <h3><a href=""#"">This Is My Second Poll Question</a></h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                        <div class=""clear""></div><span>Feb 22, 2014</span>
                    </li>
                </ul>
            </div>

        </aside><!-- End sidebar -->
    </div><!-- End row -->
</section><!-- End container -->

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(12410, 87, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(function () {\r\n            $.ajax({\r\n                url: \"");
                EndContext();
                BeginContext(12498, 56, false);
<<<<<<< HEAD
#line 274 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
=======
#line 274 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Details.cshtml"
>>>>>>> 084f3d0b7fa4e711bda1eb0ec0c9948185ea5d99
                 Write(Url.Content("~/Answers/AnswerList?QuestionId="+Model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(12554, 228, true);
                WriteLiteral("\"\r\n            }).done(function (data) {\r\n                $(\'#answerlist\').html(data);\r\n            }).fail(function () {\r\n                alert(\"error\");\r\n            });\r\n        }\r\n        );\r\n    </script>\r\n\r\n\r\n\r\n   \r\n    \r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssistMeProject.Models.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
