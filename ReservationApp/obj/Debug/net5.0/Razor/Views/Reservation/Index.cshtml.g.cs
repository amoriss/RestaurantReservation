#pragma checksum "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9447426f94d28bfec6f6b676b96655158fdd538"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Index), @"mvc.1.0.view", @"/Views/Reservation/Index.cshtml")]
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
#line 1 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\_ViewImports.cshtml"
using ReservationApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\_ViewImports.cshtml"
using ReservationApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9447426f94d28bfec6f6b676b96655158fdd538", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6a6e01dadf677f26e8db74c9ae0f8656deea49", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h2>Reservation</h2>

<div style=""display: block"">
    <a href=""/Reservation/InsertReservation/"">Create a New Reservation</a>
</div>

<table class=""table"">
    <tr>
        <th>ID</th>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Date</th>
        <th>Time</th>
        <th>Table Size</th>
        <th>Booked</th>
    </tr>

");
#nullable restore
#line 21 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
     foreach (var reservation in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td><a");
            BeginWriteAttribute("href", " href=", 465, "", 515, 2);
            WriteAttributeValue("", 471, "/Reservation/ViewReservation/", 471, 29, true);
#nullable restore
#line 24 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
WriteAttributeValue("", 500, reservation.ID, 500, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
                                                        Write(reservation.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
   Write(reservation.First_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td> <!--added-->\r\n    <td>");
#nullable restore
#line 26 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
   Write(reservation.Last_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   <!--added-->\r\n    <td>");
#nullable restore
#line 27 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
   Write(reservation.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
   Write(reservation.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
   Write(reservation.Table_Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> <!--added-->\r\n    <td>");
#nullable restore
#line 30 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"
   Write(reservation.Booked);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 33 "C:\Users\amori\repos\RestaurantReservation\ReservationApp\Views\Reservation\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
