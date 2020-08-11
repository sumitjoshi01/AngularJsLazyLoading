(function () {
    'usestrict';

    var routingPocApp = angular.module('RoutingPocApp');

    routingPocApp.service('HttpPostService', function ($http, appConfig) {
        this.HttpCall = function (params, callback) {
            $http({
                method: 'POST',
                url: appConfig.apiBasePath + params.url,
                data: params.data
            }).then(function successCallback(response) {
                var genericResponse = response.data;
                if (genericResponse.status === 200) {
                    callback(genericResponse);
                } else {
                    alert(appConfig.unknownErrorMsg);
                }
            }, function errorCallback(response) {
                console.log(response);
                alert(appConfig.unknownErrorMsg);
            });
        };
    });

    routingPocApp.service('HttpGetService', function ($http, appConfig) {
        this.HttpCall = function (params, callback) {
            $http({
                method: 'GET',
                url: appConfig.apiBasePath + params.url
            }).then(function successCallback(response) {
                var genericResponse = response.data;
                if (genericResponse.status === 200) {
                    callback(genericResponse);
                } else {
                    alert(appConfig.unknownErrorMsg);
                }
            }, function errorCallback(response) {
                console.log(response);
                alert(appConfig.unknownErrorMsg);
            });
        };
    });

})();