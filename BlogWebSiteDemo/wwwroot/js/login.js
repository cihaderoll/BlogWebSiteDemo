var account = {
	login: function () {
		var data = {
			UserName: $("#UserName").val(),
			Password: $("#Password").val()
		}

		requestHelper.post("/Account/Login", data , () => {
			debugger;
			location.href = "/Home/Index";
		});
	}
}