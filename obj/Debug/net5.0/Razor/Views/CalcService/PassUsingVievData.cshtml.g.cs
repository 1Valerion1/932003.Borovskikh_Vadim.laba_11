#pragma checksum "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf8528ea7abcb3af118b189777d9c781b70bb26b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingVievData), @"mvc.1.0.view", @"/Views/CalcService/PassUsingVievData.cshtml")]
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
#line 1 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\_ViewImports.cshtml"
using Web_laba_back_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\_ViewImports.cshtml"
using Web_laba_back_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8528ea7abcb3af118b189777d9c781b70bb26b", @"/Views/CalcService/PassUsingVievData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f63e1dedde325cfb3717df931ba7cb5b8f9e76c", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_PassUsingVievData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml"
  
    ViewData["Title"] = "PassUsingVievData";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 5 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml"
 for (int i = 1; i <= 10; i++)
{
    string Line = "Line" + i;
    if ((i < 4) || (i % 2 == 1))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b>");
#nullable restore
#line 9 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml"
   Write(ViewData[Line]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />");
#nullable restore
#line 9 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml"
                                 }
    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b>");
#nullable restore
#line 10 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml"
        Write(ViewData[Line]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />");
#nullable restore
#line 10 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.lab11\Web_laba_back_1\Views\CalcService\PassUsingVievData.cshtml"
                                      ;}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
