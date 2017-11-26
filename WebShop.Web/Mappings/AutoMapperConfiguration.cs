using AutoMapper;
using WebShop.Model.Models;
using WebShop.Web.Models;

namespace WebShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
                                {
                                    cfg.CreateMap<Order, OrderViewModel>();
                                    cfg.CreateMap<OrderDetail, OrderViewModel>();
                                    cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                                    cfg.CreateMap<PostTag, PostTagViewModel>();
                                    cfg.CreateMap<Post, PostViewModel>();
                                    cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                                    cfg.CreateMap<ProductTag, ProductTagViewModel>();
                                    cfg.CreateMap<Product, ProductViewModel>();
                                    cfg.CreateMap<Tag, TagViewModel>();
                                });
        }
    }
}