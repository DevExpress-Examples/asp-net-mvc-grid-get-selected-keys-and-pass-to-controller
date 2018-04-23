Imports Microsoft.VisualBasic
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports Sample.Models

Namespace Sample.Controllers
	Public Class HomeController
		Inherits Controller
		Private list As New PersonsList()

		<HttpGet> _
		Public Function Index() As ActionResult
			Return View(list.GetPersons())
		End Function

		<HttpPost> _
		Public Function Index(ByVal selectedIDsHF As String) As ActionResult
			'Get all selected keys from hidden input
			Dim _selectedIDs As String = selectedIDsHF

			Return View(list.GetPersons())
		End Function

		Public Function GridViewEditingPartial() As ActionResult
			'Get all selected keys from e.customArgs on GridView callback
			Dim _selectedIDs As String = Request.Params("selectedIDs")
			ViewData("_selectedIDs") = _selectedIDs

			Return PartialView(list.GetPersons())
		End Function

	End Class
End Namespace