(function () {
    "use strict";

    angular.module(appName)
    .config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {

        $routeProvider.when('/keligula', {
            templateUrl: '/Scripts/kellyproject/app/home/templates/home.html',
            controller: 'kController',
            controllerAs: 'KC'      
        }).when('/list', {
            templateUrl: '/Scripts/kellyproject/app/home/templates/list.html',
            controller: 'practiceListController',
            controllerAs: 'list'
        })

        $locationProvider.html5Mode(false);

    }]);

})();