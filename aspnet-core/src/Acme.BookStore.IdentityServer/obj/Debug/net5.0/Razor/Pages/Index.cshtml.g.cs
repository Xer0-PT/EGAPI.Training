#pragma checksum "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2582473db7e2209ae3537d4c8e5e36f37cd601b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 2 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
using Acme.BookStore.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
using Volo.Abp.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2582473db7e2209ae3537d4c8e5e36f37cd601b6", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25152d795852518cc499282e563bc297efeed2a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/Logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpRowTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpRowTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpColumnTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpLinkButtonTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
 if (CurrentUser.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2582473db7e2209ae3537d4c8e5e36f37cd601b64856", async() => {
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2582473db7e2209ae3537d4c8e5e36f37cd601b65127", async() => {
                    WriteLiteral("\n                <i class=\"fa fa-user d-block\" style=\"font-size: 10em; color: #12b900\"></i>\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2582473db7e2209ae3537d4c8e5e36f37cd601b65509", async() => {
                        WriteLiteral("Logout");
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpLinkButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper);
#nullable restore
#line 12 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper.ButtonType = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonType.Primary;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("abp-button", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper.ButtonType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n            ");
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpColumnTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper);
#nullable restore
#line 10 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.ColumnSize._3;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("size-md", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2582473db7e2209ae3537d4c8e5e36f37cd601b68855", async() => {
                    WriteLiteral("\n                <h2>");
#nullable restore
#line 15 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
               Write(CurrentUser.UserName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h2>\n                <h5 class=\"text-muted\">");
#nullable restore
#line 16 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
                                  Write(CurrentUser.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h5>\n                <div>\n                    <strong>Roles</strong>: ");
#nullable restore
#line 18 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
                                       Write(CurrentUser.Roles.JoinAsString(", "));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                    <br />\n                    <strong>Claims</strong>: <br />\n                    ");
#nullable restore
#line 21 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
               Write(Html.Raw(CurrentUser.GetAllClaims().Select(c => $"{c.Type}={c.Value}").JoinAsString(" <br /> ")));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                </div>\n            ");
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpColumnTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper);
#nullable restore
#line 14 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.ColumnSize._9;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("size-md", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpColumnTagHelper.SizeMd, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpRowTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Grid.AbpRowTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Grid_AbpRowTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 26 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 28 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
 if (!CurrentUser.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\n        <i class=\"fa fa-user d-block\" style=\"font-size: 10em; color: #aaa\"></i><br/><br />\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2582473db7e2209ae3537d4c8e5e36f37cd601b613327", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpLinkButtonTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper);
#nullable restore
#line 32 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper.ButtonType = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonType.Primary;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("abp-button", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper.ButtonType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 34 "C:\Users\jmartins\Tutorial-ABP\aspnet-core\src\Acme.BookStore.IdentityServer\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICurrentUser CurrentUser { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
