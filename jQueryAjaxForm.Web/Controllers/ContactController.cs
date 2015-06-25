using System.Web.Mvc;
using jQueryAjaxForm.Web.Models.Views;

namespace jQueryAjaxForm.Web.Controllers {
	public class ContactController : Controller {
		[HttpGet]
		public ActionResult Create() {
			return View(new ContactViewModel());
		}
	}
}