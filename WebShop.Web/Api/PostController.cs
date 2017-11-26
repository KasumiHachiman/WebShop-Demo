using AutoMapper;
using System.Collections.Generic;
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
    [RoutePrefix("api/post")]
    public class PostController : BaseApiController
    {
        private IPostService _postCategoryService;

        public PostController(IErrorService errorService, IPostService postCategoryService)
            : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }
    }
}