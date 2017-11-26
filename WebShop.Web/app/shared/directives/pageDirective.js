(function (app) {
    'use strict';
    app.directive('pageDirective', pageDirective);
    function pageDirective() {
        return {
            scope: {
                page: '@',
                pageCount: '@',
                totalPage: '@',
                searchFunc: '&',
                customPath: '@'
            },
            replace: true,
            restrict: 'E',
            templateUrl: '/app/shared/directives/pageDirective.html',
            controller: [
                '$scope', function ($scope) {
                    $scope.search = function (i) {
                        if ($scope.searchFunc) {
                            $scope.searchFunc({ page: i });
                        }
                    };
                    $scope.range = function () {
                      if (!$scope.totalPage) { return []; }
                        var step = 2;
                        var doubleStep = step * 2;
                        var start = Math.max(0, $scope.page - step);
                        var end = start + 1 + doubleStep;
                        if (end > $scope.totalPage) { end = $scope.totalPage; }

                        var ret = [];
                        for (var i = start; i != end; ++i) {
                            ret.push(i);
                        }

                        return ret;
                    }
                    $scope.pagePlus = function (count) {
                        return +$scope.page + count;
                    }
                }]
        }
   }
})(angular.module('webshop.common'));