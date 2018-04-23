using System.Web.Mvc;
using DevExpress.Web.Mvc;
using Sample.Models;

namespace Sample.Controllers {
    public class HomeController : Controller {
        PersonsList list = new PersonsList();

        [HttpGet]
        public ActionResult Index() {
            return View(list.GetPersons());
        }

        [HttpPost]
        public ActionResult Index(string selectedIDsHF) {
            //Get all selected keys from hidden input
            string _selectedIDs = selectedIDsHF;

            return View(list.GetPersons());
        }

        public ActionResult GridViewEditingPartial() {
            //Get all selected keys from e.customArgs on GridView callback
            string _selectedIDs = Request.Params["selectedIDs"];
            ViewData["_selectedIDs"] = _selectedIDs;

            return PartialView(list.GetPersons());
        }

    }
}