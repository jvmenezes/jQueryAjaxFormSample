using System.Web.Http;
using jQueryAjaxForm.Web.Models.Bindings;

namespace jQueryAjaxForm.Web.Controllers {
	public class ContactApiController : ApiController {
		[HttpPost]
		public IHttpActionResult Post(ContactBindingModel model) {
			if (!ModelState.IsValid) {
				return BadRequest(ModelState);
			}

			return Created(Url.Route("DefaultApi", new { id = model.Name }), model);
		}
	}
}