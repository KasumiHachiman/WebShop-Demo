(function () {
    angular.module('webshop.product', ['webshop.common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider']

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product', {
            url: '/product',
            templateUrl: '/app/components/product/productListView.html',
            controller: 'productListController'
        })
    }
})();