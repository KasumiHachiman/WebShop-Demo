using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebShop.Model.Models;
using WebShop.Service;
using WebShop.Web.Infrastructure.Core;
using WebShop.Web.Infrastructure.Extensions;
using WebShop.Web.Models;

namespace WebShop.Web.Api
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : BaseApiController
    {
        private IProductCategoryService _productCategoryService;

        public ProductCategoryController(IErrorService errorService, IProductCategoryService productCategoryService)
            : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, ProductCategoryViewModel productCategoryViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    //var postCategory = Mapper.Map<PostCategory>(postCategoryViewModel);
                    ProductCategory productCategory = new ProductCategory();
                    productCategory.UpdateProductCategory(productCategoryViewModel);
                    var result = _productCategoryService.Add(productCategory);
                    _productCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.Created, result);
                }

                return response;
            });
        }
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, ProductCategoryViewModel productCategoryViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var productCategory = _productCategoryService.GetById(productCategoryViewModel.ID);
                    productCategory.UpdateProductCategory(productCategoryViewModel);
                    _productCategoryService.Update(productCategory);
                    _productCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        [HttpGet]
        [Route("getbyid/{id:int}")]
        public HttpResponseMessage GetById(HttpRequestMessage request,int id)
        {
            return CreateHttpResponse(request,()=>{
                if(!ModelState.IsValid)
                {
                    return request.CreateResponse(HttpStatusCode.BadRequest, BadRequest()); 
                }
                else
                {
                    ProductCategory productCategory = _productCategoryService.GetById(id);
                    ProductCategoryViewModel productCategoryViewModel = Mapper.Map<ProductCategory, ProductCategoryViewModel>(productCategory);
                    return request.CreateResponse(HttpStatusCode.Created, productCategoryViewModel);
                }
            });
        }
        [HttpDelete]
        [Route("Delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _productCategoryService.Delete(id);
                    _productCategoryService.Save();
                    request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request,string keyword,int page,int pageSize = 20)
        {
            return CreateHttpResponse(request, () =>
            {
                int totalRow = 0;
                var listProductCategory = _productCategoryService.GetAll(keyword);//.Where(x=>x.Description.Contains(keyword) || x.Name.Contains(keyword));
                totalRow = listProductCategory.Count();
                var query = listProductCategory.OrderByDescending(x => x.CreatedDate).Skip(page * pageSize).Take(pageSize);
                var listProductCategoryViewModel = Mapper.Map<List<ProductCategoryViewModel>>(query);
                var paging = new PaginationSet<ProductCategoryViewModel>()
                {
                    Items = listProductCategoryViewModel,
                    PageSize = pageSize,
                    TotalPage = (int)Math.Ceiling((decimal)totalRow/pageSize),
                    Page = page
                };
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, paging);
                return response;
            });
        }
        [HttpGet]
        [Route("getparentcategory")]
        public HttpResponseMessage GetParent(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategoryParent = _productCategoryService.GetAll();
                var listCategoryParentViewModel = Mapper.Map<List<ProductCategoryViewModel>>(listCategoryParent);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategoryParentViewModel);
                return response;
            });
        }
    }
}