/// <reference path="D:\Work\working\webshop-2-11-2017\WebShop.Web\Assets/admin/lib/angular/angular.js" />
(function () {
    angular.module('webshop', ['webshop.product', 'webshop.productCategory', 'webshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: '/admin',
            templateUrl: '/app/components/home/homeView.html',
            controller: 'homeController'
        });
        $urlRouterProvider.otherwise('/admin')
    }
})();