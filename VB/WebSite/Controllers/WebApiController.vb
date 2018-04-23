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
Imports DXWebApplication5.Models
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Namespace DXWebApplication5.Controllers
	Public Class WebApiController
		Inherits ApiController
		<HttpGet> _
		Public Function GetList(Optional ByVal query As String = "") As IEnumerable(Of MyModel)
			Dim ds = CustomerList.GenerateList()
			ds = If(String.IsNullOrEmpty(query), ds, ds.Where(Function(p) p.FirstName.Contains(query)).ToList())
			Return ds
		End Function
	End Class
End Namespace
