#pragma checksum "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614e74d8ecde8b2d29823d8e9fab1cf5919a1c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Search.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Search.Pages.Pages_Index), null)]
namespace Search.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Mohaymen\Elastic_Search\Search\Pages\_ViewImports.cshtml"
using Search;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"614e74d8ecde8b2d29823d8e9fab1cf5919a1c78", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b53ae8e6e9a2354ebf89ce03a873dbfed0471e2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(79, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(80, 443, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "614e74d8ecde8b2d29823d8e9fab1cf5919a1c783875", async() => {
                BeginContext(109, 131, true);
                WriteLiteral("\n    <div class=\"input-group mb-3\">\n        <input type=\"text\" class=\"form-control\" placeholder=\"Search For Capital...\" name=\"term\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 240, "\"", 259, 1);
#line 9 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
WriteAttributeValue("", 248, Model.Term, 248, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(260, 256, true);
                WriteLiteral(@"
               autocomplete=""off"" autofocus=""autofocus"">
        <div class=""input-group-append"">
            <button class=""btn btn-outline-secondary"" type=""submit"">
                <i class=""""></i> Search
            </button>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(523, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 19 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
 if (Model.HasSearch)
{
    var results = Model.Search.Documents.Select(x => x.Data).ToList();
    
    

#line default
#line hidden
#line 23 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
     if (!results.Any())
    {

#line default
#line hidden
            BeginContext(656, 96, true);
            WriteLiteral("        <div class=\"jumbotron\">\n            <h1 class=\"display-4\">You Didn\'t Find Anything For \"");
            EndContext();
            BeginContext(753, 10, false);
#line 26 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                                                           Write(Model.Term);

#line default
#line hidden
            EndContext();
            BeginContext(763, 105, true);
            WriteLiteral("\"</h1>\n            <p class=\"lead\">Keep looking, you may find what you\'re search for!</p>\n        </div>\n");
            EndContext();
#line 29 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(889, 156, true);
            WriteLiteral("        <div class=\"album py-5 bg-light\">\n            <div class=\"container\">\n                <div class=\"col-md-12\">\n                    <div class=\"row\">\n");
            EndContext();
#line 36 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                         foreach (var result in results)
                        {

#line default
#line hidden
            BeginContext(1128, 242, true);
            WriteLiteral("                            <div class=\"col-md-4\">\n                                <div class=\"card mb-4 shadow-sm\">\n                                    <div class=\"card-body\">\n                                        <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1370, "\"", 1402, 1);
#line 41 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
WriteAttributeValue("", 1376, Model.MapImageUrl(result), 1376, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1403, "\"", 1421, 1);
#line 41 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
WriteAttributeValue("", 1409, result.City, 1409, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1422, 111, true);
            WriteLiteral(">\n                                        <hr/>\n                                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1534, 11, false);
#line 43 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                                                          Write(result.City);

#line default
#line hidden
            EndContext();
            BeginContext(1545, 88, true);
            WriteLiteral("</h5>\n                                        <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1634, 14, false);
#line 44 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                                                                             Write(result.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1648, 126, true);
            WriteLiteral("</h6>\n                                        <p class=\"card-text\">\n                                            Population of ");
            EndContext();
            BeginContext(1775, 11, false);
#line 46 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                                                     Write(result.City);

#line default
#line hidden
            EndContext();
            BeginContext(1786, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1789, 14, false);
#line 46 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                                                                   Write(result.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 4, true);
            WriteLiteral(" is ");
            EndContext();
            BeginContext(1809, 81, false);
#line 46 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                                                                                       Write(result.Population.HasValue ? $"approximately {result.Population:0,0}" : "Unknown");

#line default
#line hidden
            EndContext();
            BeginContext(1891, 164, true);
            WriteLiteral(".\n                                        </p>\n                                    </div>\n                                </div>\n                            </div>\n");
            EndContext();
#line 51 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2081, 84, true);
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n");
            EndContext();
#line 56 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
    }

#line default
#line hidden
#line 56 "E:\Mohaymen\Elastic_Search\Search\Pages\Index.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Search.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Search.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Search.Pages.IndexModel>)PageContext?.ViewData;
        public Search.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
