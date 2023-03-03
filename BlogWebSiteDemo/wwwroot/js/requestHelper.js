var requestHelper = {
    get: function (url, callback) {
        $.ajax(url,
            {
                success: function (data, status, xhr) {
                    callback();
                }
            });
    },
    post: function (url, data, callback) {
        $.ajax({
            url: url,
            type: 'POST',
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(data),
            success: function (data, status, xhr) {
                debugger;
                callback();
            }
        });
    }
}