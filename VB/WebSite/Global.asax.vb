' Developer Express Code Central Example:
' GridView - How to use the jQuery autocomplete plugin with ASP.NET WebApi
' 
' The Autocomplete plugin allows you to implement the functionality that helps
' end-users find and select values from a pre-populated list while typing. It also
' allows loading this list on demand by using AJAX requests to a remote service,
' which reduces the page rendering time.
' ASP.NET Web API is a framework that
' makes it easy to build HTTP services that reach a broad range of clients,
' including browsers and mobile devices. ASP.NET Web API is an ideal platform for
' building RESTful applications in the .NET Framework.
' This example demonstrates
' how to combine these features for the GridView's EditForm editor.
' Main points
' are:
' 1) Add a WebApi Controller to the Controllers folder and define a method
' that returns a portion of data depending on the typed text;
' 2) Register a
' WebApi route as it described in the Routing in ASP.NET Web API
' (http://www.asp.net/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api)
' article;
' 3) Add references to the jQuery and jQuery UI libraries;
' 4) Handle
' the client-side Init event for the corresponding editor;
' 
' Now it is possible
' to implement the autocomplete functionality. When the end-user types text into
' the "FirstName", the text is obtained from the editor and assigned to
' Autocomplete's select attribute. Then an AJAX request is sent to the server and
' calls the corresponding method in WebApi. The result of the request is returned
' to the client and used for Autocomplete's source attribute.
' 
' See also:
' jQuery
' Autocomplete, MVC4, and WebAPI
' (http://www.codeproject.com/Tips/639578/jQuery-Autocomplete-MVC4-and-WebAPI)
' http://www.devexpress.com/scid=E4788
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5022


Imports Microsoft.VisualBasic
Imports DXWebApplication5.App_Start
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Http
Imports System.Net.Http
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace DXWebApplication5
	' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	' visit http://go.microsoft.com/?LinkId=9394801

	Public Class MvcApplication
		Inherits System.Web.HttpApplication
		Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
			filters.Add(New HandleErrorAttribute())
		End Sub

		Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
			routes.IgnoreRoute("{resource}.ashx/{*pathInfo}")
			routes.MapRoute("Default", "{controller}/{action}/{id}", New With {Key .controller = "Home", Key .action = "Index", Key .id = UrlParameter.Optional})

		End Sub

		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()

			RegisterGlobalFilters(GlobalFilters.Filters)
			WebApiConfig.Register(GlobalConfiguration.Configuration)
			RegisterRoutes(RouteTable.Routes)
			'BundleConfig.RegisterBundles(BundleTable.Bundles);

			ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()
		End Sub
	End Class
End Namespace