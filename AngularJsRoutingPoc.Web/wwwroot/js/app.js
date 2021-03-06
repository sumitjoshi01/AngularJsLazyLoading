﻿(function () {
    'usestrict';

    var routingPocApp = angular.module('RoutingPocApp', ['oc.lazyLoad', 'ui.router']);

    routingPocApp.config(['$provide', '$stateProvider', '$locationProvider', function ($provide, $stateProvider, $locationProvider) {

        $stateProvider.state('AddGrocery',
            {
                url: "/AddGrocery",
                views: {
                    "appView": {
                        controller: 'GroceryController',
                        templateUrl: 'pages/add-grocery.html'
                    }
                },
                resolve: {
                    resolver: ['$ocLazyLoad', function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                            'js/services/GroceryService.js',
                            'js/controllers/GroceryController.js'
                        ]);
                    }]
                }
            })
            .state('GroceryList', {
                url: "/GroceryList",
                views: {
                    "appView": {
                        controller: 'GroceryController',
                        templateUrl: 'pages/grocery-list.html'
                    }
                },
                resolve: {
                    resolver: ['$ocLazyLoad', function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                            'js/services/GroceryService.js',
                            'js/controllers/GroceryController.js'
                        ]);
                    }]
                }
            })
            .state('Default', {
                url: '',
                views: {
                    "appView": {
                        templateUrl: 'pages/home.html'
                    }
                }
            });

        var configObj = {
            apiBasePath: 'http://localhost:5000/api/v1/',
            unknownErrorMsg: 'Something went wrong! Try again after sometime.'
        };

        $provide.value('appConfig', configObj);

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });

    }]);

})();