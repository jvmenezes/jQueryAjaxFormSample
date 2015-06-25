using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxForm.Web.Models.Bindings {
	public class ContactBindingModel {
		[Required]
		public string Name { get; set; }
		[Required]
		public string Telephone { get; set; }
		[Required]
		public string Address { get; set; }
	}
}