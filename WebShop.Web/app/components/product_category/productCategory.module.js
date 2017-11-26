(function (app) {
    angular.module('webshop.productCategory', []).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('productcategory', {
            url: '/productcategory',
            templateUrl: '/app/components/product_category/productCategoryListView.html',
            controller:'productCategoryListController'
        })
    }
})()