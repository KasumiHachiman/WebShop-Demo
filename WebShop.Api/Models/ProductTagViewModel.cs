using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Api.Models
{
    public class ProductTagViewModel
    {
        public ProductTagViewModel()
        {
            ProductViewModel = new ProductViewModel();
            TagViewModel = new TagViewModel();
        }
        public int ProductID { set; get; }

        public string TagID { set; get; }

        public virtual ProductViewModel ProductViewModel { set; get; }

        public virtual TagViewModel TagViewModel { set; get; }
    }
}