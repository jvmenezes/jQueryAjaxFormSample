$(function (BLA) {
	BLA.options = {

	};

	$('form[data-ajax="True"]').each(function (idx, form) {
		$(form).ajaxForm(BLA.options);
	});

});


