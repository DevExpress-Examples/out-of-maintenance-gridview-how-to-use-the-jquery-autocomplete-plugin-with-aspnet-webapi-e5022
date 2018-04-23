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
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Linq
Imports System.Web

Namespace DXWebApplication5.Models

	Public Class MyModel
		Private privateFirstName As String
		<Required> _
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateLastName As String
		<Required> _
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
		Private privateBirthDate As DateTime
		Public Property BirthDate() As DateTime
			Get
				Return privateBirthDate
			End Get
			Set(ByVal value As DateTime)
				privateBirthDate = value
			End Set
		End Property
		Private privateCustomerID As Integer
		<Key> _
		Public Property CustomerID() As Integer
			Get
				Return privateCustomerID
			End Get
			Set(ByVal value As Integer)
				privateCustomerID = value
			End Set
		End Property
		Public Sub New()
		End Sub
		Public Sub New(ByVal first As String, ByVal last As String, ByVal birth As DateTime, ByVal id As Integer)
			CustomerID = id
			FirstName = first
			LastName = last
			BirthDate = birth
		End Sub

	End Class
	Public NotInheritable Class CustomerList
		Private Sub New()
		End Sub
		Public Shared Function GetTypedListModel() As List(Of MyModel)
			If HttpContext.Current.Session("ModelList") Is Nothing Then
				HttpContext.Current.Session("ModelList") = GenerateList()
			End If

			Return CType(HttpContext.Current.Session("ModelList"), List(Of MyModel))
		End Function

		Public Shared Function GenerateList() As List(Of MyModel)
			Dim typedList As New List(Of MyModel)()
			For index As Integer = 0 To 99
				typedList.Add(New MyModel("Name" & index, "Last" & index, New DateTime(1990, 10, 1), index))
			Next index
			Return typedList
		End Function
		Public Shared Sub UpdateCustomer(ByVal modelInfo As MyModel)
			Dim editedModel As MyModel = GetTypedListModel().Where(Function(m) m.CustomerID = modelInfo.CustomerID).First()
			editedModel.FirstName = modelInfo.FirstName
			editedModel.BirthDate = modelInfo.BirthDate
			editedModel.LastName = modelInfo.LastName
		End Sub
	End Class
End Namespace