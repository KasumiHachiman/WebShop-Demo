
using WebShop.Api.Infrastructure.Core;
using WebShop.Service;

namespace WebShop.Api.Controllers
{
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