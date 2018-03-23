(function () {
    'use strict';

    angular
		.module('app')
		.config(routeConfig)

    routeConfig.$inject = ['$routeProvider'];

    function routeConfig($routeProvider) {

        $routeProvider
            .when("/home", {
                templateUrl: "Home/HomePage",
                controller: "homeController",
                controllerAs: 'vm'
            })
            .otherwise({
                redirectTo: "/home"
            });
    }
}());