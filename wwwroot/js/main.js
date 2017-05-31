$(document).ready(() => {
	$.getJSON('/phoneNumber', data => {
		$('#phone-number').text(data.phoneNumber);
	});
});
