#pragma checksum "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411de59e120c8cf0e09d46542a3ca4a24c3b18d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Show), @"mvc.1.0.view", @"/Views/Categories/Show.cshtml")]
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
#line 5 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411de59e120c8cf0e09d46542a3ca4a24c3b18d5", @"/Views/Categories/Show.cshtml")]
    public class Views_Categories_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h3>Here are all the items in this category:</h3>\n\n<ol>\n");
#nullable restore
#line 10 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
 foreach (Item item in @Model["items"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li><a");
            BeginWriteAttribute("href", " href=\'", 159, "\'", 214, 4);
            WriteAttributeValue("", 166, "/categories/", 166, 12, true);
#nullable restore
#line 12 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
WriteAttributeValue("", 178, Model["category"].Id, 178, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 199, "/items/", 199, 7, true);
#nullable restore
#line 12 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
WriteAttributeValue("", 206, item.Id, 206, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
                                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 13 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\n\n<p><a");
            BeginWriteAttribute("href", " href=\'", 257, "\'", 307, 3);
            WriteAttributeValue("", 264, "/categories/", 264, 12, true);
#nullable restore
#line 16 "/Users/saoud/git/Epicodus/c-sharp-to-do-list-dotnet5/ToDoList/Views/Categories/Show.cshtml"
WriteAttributeValue("", 276, Model["category"].Id, 276, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 297, "/items/new", 297, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Add a new item</a></p>\n<p><a href=\'/categories\'>Return to category list</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>");
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
