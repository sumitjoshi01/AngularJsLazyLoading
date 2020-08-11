(function () {
    'usestrict;'

    var routingPocApp = angular.module('RoutingPocApp');
    routingPocApp.controller('GroceryController', GroceryController);
    GroceryController.$inject = ['$scope', 'GroceryService', '$location', '$rootScope'];

    function GroceryController($scope, GroceryService, $location, $rootScope) {

        $scope.GroceryModel = {};
        $scope.App = {};
        $scope.App.GroceryList = [];
        $scope.UnitList = ['Kg', 'Piece', 'Ltr', 'ml', 'Dozen'];

        $scope.AddGrocery = function () {

            if ($scope.GroceryForm.$invalid) {
                return;
            }

            GroceryService.AddGrocery($scope.GroceryModel).then(function (data) {
                if (data === true) {
                    alert('Grocery added to list successfully.');
                    $scope.ResetGroceryForm();
                } else {
                    alert('Unable to add grocery at the moment! pleae try after some time.');
                }
            }, function () {
                alert('Unable to add grocery at the moment! pleae try after some time.');
            });
        }

        $scope.ResetGroceryForm = function () {
            $scope.GroceryForm.$setPristine()
            $scope.GroceryForm.$setUntouched()
            $scope.GroceryModel = {};
        }

        $scope.PopulateGroceryList = function () {
            GroceryService.GetAllGrocries().then(function (groceries) {
                angular.copy(groceries, $scope.App.GroceryList);
            });
        }

        $scope.Init = function () {
            console.log('Init called. Current Route: ' + $location.path());
            $rootScope.CurrentPath = $location.path();

            if ($rootScope.CurrentPath && $rootScope.CurrentPath.toLowerCase() === '/grocerylist') {
                $scope.PopulateGroceryList();
            }
        }

        $scope.Init();
    }

})();