<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550940/13.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5022)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebApiConfig.cs](./CS/WebSite/App_Start/WebApiConfig.cs) (VB: [WebApiConfig.vb](./VB/WebSite/App_Start/WebApiConfig.vb))
* [HomeController.cs](./CS/WebSite/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/WebSite/Controllers/HomeController.vb))
* [WebApiController.cs](./CS/WebSite/Controllers/WebApiController.cs) (VB: [WebApiController.vb](./VB/WebSite/Controllers/WebApiController.vb))
* [Global.asax](./CS/WebSite/Global.asax)
* [Global.asax.cs](./CS/WebSite/Global.asax.cs)
* [MyModel.cs](./CS/WebSite/Models/MyModel.cs) (VB: [MyModel.vb](./VB/WebSite/Models/MyModel.vb))
* [GridViewPartial.cshtml](./CS/WebSite/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/WebSite/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to use the jQuery autocomplete plugin with ASP.NET WebApi


<p>The Autocomplete plugin allows you to implement the functionality that helps end-users find and select values from a pre-populated list while typing. It also allows loading this list on demand by using AJAX requests to a remote service, which reduces the page rendering time.</p><p>ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad range of clients, including browsers and mobile devices. ASP.NET Web API is an ideal platform for building RESTful applications in the .NET Framework.</p><p>This example demonstrates how to combine these features for the GridView's EditForm editor.</p><p>Main points are:</p><p>1) Add a WebApi Controller to the Controllers folder and define a method that returns a portion of data depending on the typed text;<br />
2) Register a WebApi route as it described in the <a href="http://www.asp.net/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api"><u>Routing in ASP.NET Web API</u></a><u> </u>article;<br />
3) Add references to the jQuery and jQuery UI libraries;<br />
4) Handle the client-side Init event for the corresponding editor;</p><p>Now it is possible to implement the autocomplete functionality. When the end-user types text into the "FirstName", the text is obtained from the editor and assigned to Autocomplete's select attribute. Then an AJAX request is sent to the server and calls the corresponding method in WebApi. The result of the request is returned to the client and used for Autocomplete's source attribute.</p><p><strong>See also:<br />
</strong><a href="http://www.codeproject.com/Tips/639578/jQuery-Autocomplete-MVC4-and-WebAPI"><u>jQuery Autocomplete, MVC4, and WebAPI</u></a><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E4788">How to implement ASPxTextBox in AutoFilterRow with  the jQuery AutoComplete plugin</a></p>

<br/>


