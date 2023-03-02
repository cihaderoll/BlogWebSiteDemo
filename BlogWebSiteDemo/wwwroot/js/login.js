var account = {
	login: function () {
		var data = {
			UserName: $("UserName").val(),
			Password: $("Password").val()
		}

		requestHelper.post();
	}
}