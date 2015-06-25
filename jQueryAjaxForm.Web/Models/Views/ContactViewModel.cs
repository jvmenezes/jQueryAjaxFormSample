using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxForm.Web.Models.Views {
	public class ContactViewModel {
		[Display(Name = "Nome")]
		public string Name { get; set; }
		[Display(Name = "Telefone")]
		public string Telephone { get; set; }
		[Display(Name = "Endereço")]
		public string Address { get; set; }
	}
}