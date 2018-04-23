@ModelType List(Of Sample.Models.Person)
<script type="text/javascript">
    var selectedIDs;
    function OnBeginCallback(s, e) {
        //Pass all selected keys to GridView callback action
        e.customArgs["selectedIDs"] = selectedIDs;
    }
    function OnSelectionChanged(s, e) {
        s.GetSelectedFieldValues("PersonID", GetSelectedFieldValuesCallback);
    }
    function GetSelectedFieldValuesCallback(values) {
        //Capture all selected keys
        selectedIDs = values.join(',');
    }
    function OnClick(s, e) {
        //Show all selected keys on client side
        alert(selectedIDs);
    }
    function OnSubmitClick(s, e) {
        //Write all selected keys to hidden input. Pass them on post action.
        $("#selectedIDsHF").val(selectedIDs);
    }
</script>
@Html.Partial("GridViewEditingPartial", Model)
@Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "btn"
            settings.Text = "Get All Selected Keys"
            settings.ClientSideEvents.Click = "OnClick"
    End Sub).GetHtml()
@Using (Html.BeginForm("Index", "Home"))
    @Html.Hidden("selectedIDsHF")
    @Html.DevExpress().Button( _
        Sub(settings)
            settings.Name = "btnSubmit"
            settings.Text = "Submit Form"
            settings.UseSubmitBehavior = True
            settings.ClientSideEvents.Click = "OnSubmitClick"
        End Sub).GetHtml()
End Using