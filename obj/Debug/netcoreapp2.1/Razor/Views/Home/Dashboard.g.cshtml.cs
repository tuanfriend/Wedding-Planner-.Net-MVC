#pragma checksum "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2d2ca5320a105dc7da02346a3ad5970caf564b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "D:\DOJO\CSharp\WeddingProj\Views\_ViewImports.cshtml"
using WeddingProj;

#line default
#line hidden
#line 2 "D:\DOJO\CSharp\WeddingProj\Views\_ViewImports.cshtml"
using WeddingProj.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2d2ca5320a105dc7da02346a3ad5970caf564b", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4322a6264b80ccd1b7fa36efa7ba5ab2fbd4832d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WedConnect>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 46, true);
            WriteLiteral("<h1>Welcome to the Wedding Planer!!!</h1>\r\n<a>");
            EndContext();
            BeginContext(66, 17, false);
#line 3 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
Write(ViewBag.samedayrs);

#line default
#line hidden
            EndContext();
            BeginContext(83, 261, true);
            WriteLiteral(@"</a>

<table class=""table"">
    <thead class=""thead-dark"">
      <tr>
        <th scope=""col"">Wedding</th>
        <th scope=""col"">Date</th>
        <th scope=""col"">Guest</th>
        <th scope=""col"">Action</th>
      </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
         foreach(var i in ViewBag.AllWed){

#line default
#line hidden
            BeginContext(388, 44, true);
            WriteLiteral("            <tr>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 432, "\"", 459, 2);
            WriteAttributeValue("", 439, "/detail/", 439, 8, true);
#line 17 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 447, i.WeddingId, 447, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(462, 8, false);
#line 17 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                                                  Write(i.WedOne);

#line default
#line hidden
            EndContext();
            BeginContext(470, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(474, 8, false);
#line 17 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                                                              Write(i.WedTwo);

#line default
#line hidden
            EndContext();
            BeginContext(482, 35, true);
            WriteLiteral("</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(518, 9, false);
#line 18 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                   Write(i.WedDate);

#line default
#line hidden
            EndContext();
            BeginContext(527, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(559, 17, false);
#line 19 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                   Write(i.WedtoUser.Count);

#line default
#line hidden
            EndContext();
            BeginContext(576, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
#line 20 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                         if(i.WedtoUser.Count == 0){

#line default
#line hidden
            BeginContext(637, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 667, "\"", 711, 4);
            WriteAttributeValue("", 674, "/addrsvp/", 674, 9, true);
#line 21 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 683, i.WeddingId, 683, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 695, "/", 695, 1, true);
#line 21 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 696, ViewBag.Userid, 696, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(712, 11, true);
            WriteLiteral(">RSVP</a>\r\n");
            EndContext();
#line 22 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(750, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 23 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                         if(i.WedtoUser.Count > 0)
                        {
                            int resert = 0;
                            bool rsvp = false;
                            

#line default
#line hidden
#line 27 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                             foreach(var y in i.WedtoUser){
                                

#line default
#line hidden
#line 28 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                                 if(y.UserId == ViewBag.Userid){
                                    rsvp = true;
                                    resert = y.WedConnectId;
                                }

#line default
#line hidden
#line 31 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                                 
                            }

#line default
#line hidden
#line 33 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                             if(rsvp == true){

#line default
#line hidden
            BeginContext(1275, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1309, "\"", 1331, 2);
            WriteAttributeValue("", 1316, "/unrsvp/", 1316, 8, true);
#line 34 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1324, resert, 1324, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1332, 14, true);
            WriteLiteral(">Un-RSVP</a>\r\n");
            EndContext();
#line 35 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                            }

#line default
#line hidden
#line 36 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                             if(rsvp == false){

#line default
#line hidden
            BeginContext(1426, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1460, "\"", 1504, 4);
            WriteAttributeValue("", 1467, "/addrsvp/", 1467, 9, true);
#line 37 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1476, i.WeddingId, 1476, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1488, "/", 1488, 1, true);
#line 37 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1489, ViewBag.Userid, 1489, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1505, 11, true);
            WriteLiteral(">RSVP</a>\r\n");
            EndContext();
#line 38 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                            }

#line default
#line hidden
#line 38 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(1574, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                     if(ViewBag.Userid == @i.UserId){

#line default
#line hidden
            BeginContext(1631, 37, true);
            WriteLiteral("                        <a> | </a> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1668, "\"", 1695, 2);
            WriteAttributeValue("", 1675, "/delete/", 1675, 8, true);
#line 42 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1683, i.WeddingId, 1683, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1696, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 43 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(1732, 52, true);
            WriteLiteral("                    </td>\r\n                  </tr>\r\n");
            EndContext();
#line 46 "D:\DOJO\CSharp\WeddingProj\Views\Home\Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(1795, 122, true);
            WriteLiteral("    </tbody>\r\n  </table>\r\n\r\n  <a href=\"/newwedding\"><button type=\"button\" class=\"btn btn-primary\">New Wedding</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WedConnect> Html { get; private set; }
    }
}
#pragma warning restore 1591