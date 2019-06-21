<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Sample/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Sample/Controllers/HomeController.vb))
* [Person.cs](./CS/Sample/Models/Person.cs) (VB: [PersonsList.vb](./VB/Sample/Models/PersonsList.vb))
* [PersonsList.cs](./CS/Sample/Models/PersonsList.cs) (VB: [PersonsList.vb](./VB/Sample/Models/PersonsList.vb))
* [GridViewEditingPartial.cshtml](./CS/Sample/Views/Home/GridViewEditingPartial.cshtml)
* **[Index.cshtml](./CS/Sample/Views/Home/Index.cshtml)**
<!-- default file list end -->
# How to get all GridView selected keys and pass them to a Controller
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e20065)**
<!-- run online end -->


<p>This example illustrates how to collect all selected values (for example, keys) on the client side via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_GetSelectedFieldValuestopic"><u>ASPxClientGridView.GetSelectedFieldValues</u></a> method and pass them to:<br />
- The GridView callback action via the e.customArgs dictionary (<a href="http://documentation.devexpress.com/#AspNet/CustomDocument9941"><u>Passing Values to Controller Action Through Callbacks</u></a>);<br />
- Any controller post action via a hidden input element.</p>

<br/>


