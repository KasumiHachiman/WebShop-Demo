using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Api.Models
{
    public class TagViewModel
    {
        public TagViewModel()
        {
            PostTagViewModels = new List<PostTagViewModel>();
            ProductTagViewModels = new List<ProductTagViewModel>();
        }
        public string ID { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }

        public virtual ICollection<PostTagViewModel> PostTagViewModels { set; get; }

        public virtual ICollection<ProductTagViewModel> ProductTagViewModels { set; get; }
    }
}