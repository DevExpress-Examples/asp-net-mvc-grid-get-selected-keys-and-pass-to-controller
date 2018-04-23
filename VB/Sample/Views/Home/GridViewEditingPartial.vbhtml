@ModelType List(Of Sample.Models.Person)
@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "grid"
            settings.KeyFieldName = "PersonID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewEditingPartial"}

            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowSelectCheckbox = True
            settings.ClientSideEvents.SelectionChanged = "OnSelectionChanged"
            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"

            settings.SettingsPager.PageSize = 5
    
            settings.Columns.Add("FirstName")
            settings.Columns.Add("MiddleName")
            settings.Columns.Add("LastName")
    End Sub).Bind(Model).GetHtml()