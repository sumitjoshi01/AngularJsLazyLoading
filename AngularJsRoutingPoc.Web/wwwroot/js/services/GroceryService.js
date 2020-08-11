(function () {
    'usestrict';

    var routingPocApp = angular.module('RoutingPocApp');

    routingPocApp.service('GroceryService', function ($q, HttpPostService, HttpGetService) {

        this.AddGrocery = function (groceryModel) {
            var defer = $q.defer();
            HttpPostService.HttpCall({ url: 'Grocery/AddGrocery', data: groceryModel }, function (genericResponse) {
                if (genericResponse.data) {
                    defer.resolve(genericResponse.data);
                } else {
                    defer.reject(genericResponse.data);
                }
            });
            return defer.promise;
        }

        this.GetAllGrocries = function () {
            var defer = $q.defer();
            HttpGetService.HttpCall({ url: 'Grocery/GetGroceries'}, function (genericResponse) {
                if (genericResponse.data) {
                    defer.resolve(genericResponse.data);
                } else {
                    defer.reject(genericResponse.data);
                }
            });
            return defer.promise;
        }


    });

})();