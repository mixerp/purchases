﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.Purchases;
    
    #line 1 "..\..\Views\Tasks\Order\Checklist.cshtml"
    using MixERP.Purchases.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Order/Checklist.cshtml")]
    public partial class _Views_Tasks_Order_Checklist_cshtml : System.Web.Mvc.WebViewPage<long>
    {
        public _Views_Tasks_Order_Checklist_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Tasks\Order\Checklist.cshtml"
  
    ViewBag.Title = "Checklist";
    Layout = ViewBag.PurchaseLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\Tasks\Order\Checklist.cshtml"
Write(Html.FinancePartialView("Shared/Checklist.cshtml", TenantConvention.GetTenant()));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    window.overridePath = \"/dashboard/purchase/tasks/entry\";\r\n\r\n   " +
" window.prepareChecklist({\r\n        Title: \"Purchase Order Checklist #");

            
            #line 15 "..\..\Views\Tasks\Order\Checklist.cshtml"
                                     Write(Model);

            
            #line default
            #line hidden
WriteLiteral(@""",
        ViewText: ""View Purchase Orders"",
        ViewUrl: ""/dashboard/purchase/tasks/order"",
        AddNewText: ""Add New Purchase Order Entry"",
        AddNewUrl: ""/dashboard/purchase/tasks/order/new"",
        ReportPath: ""/dashboard/reports/source/Areas/MixERP.Purchases/Reports/Order.xml?transaction_master_id=");

            
            #line 20 "..\..\Views\Tasks\Order\Checklist.cshtml"
                                                                                                         Write(Model);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591
