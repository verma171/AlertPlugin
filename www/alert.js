notification.alert = function(str, callback) {
        cordova.exec(callback, function(err) {
            callback('Nothing to echo.');
        }, "Alert", "showAlert", [str]);
    };