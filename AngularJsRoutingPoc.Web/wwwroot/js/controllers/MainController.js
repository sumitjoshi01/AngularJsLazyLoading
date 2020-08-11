(function () {
    'usestrict;'

    var routingPocApp = angular.module('RoutingPocApp');

    routingPocApp.controller('MainController', ['$scope', MainController]);

    function MainController($scope) {

        $scope.test = 'test value';

    }

})();