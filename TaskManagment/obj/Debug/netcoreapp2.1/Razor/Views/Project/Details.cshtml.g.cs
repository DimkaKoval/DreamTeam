#pragma checksum "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51d460b21426f7c8077dd4d382367b6463cadcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Details), @"mvc.1.0.view", @"/Views/Project/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Details.cshtml", typeof(AspNetCore.Views_Project_Details))]
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
#line 1 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\_ViewImports.cshtml"
using TaskManagment;

#line default
#line hidden
#line 2 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\_ViewImports.cshtml"
using TaskManagment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51d460b21426f7c8077dd4d382367b6463cadcc", @"/Views/Project/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20de3f63aa94b0354c964eff4e9939cc37838f62", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManagment.ViewModels.ProjectViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 165, true);
            WriteLiteral("\n<div class=\"container\">\n    <h2>Details</h2>\n\n    <div>\n        <h4>Project</h4>\n        <hr />\n        <dl class=\"dl-horizontal\">\n            <dt>\n                ");
            EndContext();
            BeginContext(256, 40, false);
#line 15 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(296, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(349, 36, false);
#line 18 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(385, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(438, 49, false);
#line 21 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnerUserName));

#line default
#line hidden
            EndContext();
            BeginContext(487, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(540, 45, false);
#line 24 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
           Write(Html.DisplayFor(model => model.OwnerUserName));

#line default
#line hidden
            EndContext();
            BeginContext(585, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(638, 58, false);
#line 27 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectManagerUserName));

#line default
#line hidden
            EndContext();
            BeginContext(696, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(749, 54, false);
#line 30 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProjectManagerUserName));

#line default
#line hidden
            EndContext();
            BeginContext(803, 62, true);
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n    <div>\n        ");
            EndContext();
            BeginContext(865, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b90c726a46044c88970abef2aec3dbf", async() => {
                BeginContext(911, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\lesko\Downloads\pps-master\pps-master\TaskManagment\Views\Project\Details.cshtml"
                               WriteLiteral(Model.Id);

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
            BeginContext(919, 11, true);
            WriteLiteral(" |\n        ");
            EndContext();
            BeginContext(930, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34a480132444773986592734c1f535e", async() => {
                BeginContext(952, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(968, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManagment.ViewModels.ProjectViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591