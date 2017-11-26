(function (app) {
    app.controller('productCategoryListController', productCategoryListController);
    productCategoryListController.$inject = ['$scope', 'apiService', 'notificationService','$stateParams'];
    function productCategoryListController($scope, apiService, notificationService, $stateParams) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pageCount = 0;
        $scope.keyword = '';
        
        $scope.getProductCategories = getProductCategories;

        $scope.search = search;
        function search() {
            getProductCategories();
        }
        function getProductCategories(page) {
            page = page || 0;
            var config = {
                params: {
                    page: page,
                    pageSize: 5,
                    keyword:$scope.keyword
                }
            }
            apiService.get('/api/productcategory/getall', config, function (result) {
                if (result.data.PageCount == 0)
                    notificationService.displayWarning('Khong co du lieu nao duoc tim thay!');
                else
                    notificationService.displaySuccess('Da tim thay ' + result.data.PageCount + ' ban ghi!');
                $scope.productCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pageCount = result.data.PageCount;
                $scope.totalPage = result.data.TotalPage;
            }, function (error) {
                Console.log('Load productcategories fail!');
            });
        }
        

        $scope.productCategory = {
            CreatedDate: new Date(),
            Status:true
        }
        $scope.parentCategories = [];
        $scope.getParentCategories = getParentCategories;
        function getParentCategories() {
            apiService.get('/api/productcategory/getparentcategory', null, function (result) {
                $scope.parentCategories = result.data;
            }, function (error) {
                Console.log('Load parent category fail!');
            })
        }
        $scope.addProductCategory = addProductCategory;

        function addProductCategory() {
            apiService.post('/api/productcategory/add', $scope.productCategory, function (result) {
                notificationService.displaySuccess('Them thanh cong ' + result.data.Name);
                $('#addModal').modal('toggle');
                location.reload();
            }, function (error) {
                notificationService.displayError('Them moi that bai!');
            })
        }

        $scope.updateProductCategory = updateProductCategory;
        function updateProductCategory()
        {
            apiService.put('/api/productcategory/update', $scope.productCategoryDetail, function (result) {
                notificationService.displaySuccess('Cap nhat thanh cong ' + result.data.Name);
                $('#addModal').modal('toggle'); 
                location.reload();
            }, function (error) {
                notificationService.displayError('cap nhat that bai!');
            });
        }
        $scope.productCategoryDetail = {
            CreatedDate: new Date(),
            Status: true
        };
       
        $scope.loadProductCategoryDetail = function(id) {
            apiService.get('/api/productcategory/getbyid/'+id, null, function (result) {
                $scope.productCategoryDetail = result.data;
            }, function (error) {
                notificationService.displayError(error.data);
            })
        }

        $scope.getParentCategories();
        $scope.getProductCategories();
        //loadProductCategoryDetail(id);

    }
    //app.directive('dataProductCategoryDirective', function (apiService) {
    //    return {
    //        restrict: 'A',
    //        link: function ($scope, $elem, $attr) {
    //            apiService.get('/api/productcategory/getall', null, function (result) {
    //                $elem.datagrid('loadData', response);
    //            }, function (error) {
    //                Console.log('Load productcategories fail!');
    //            });
    //        }
    //    }
    //});

})(angular.module('webshop.productCategory'))