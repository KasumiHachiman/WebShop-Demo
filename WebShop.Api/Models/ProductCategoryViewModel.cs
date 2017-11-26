using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Api.Models
{
    public class ProductCategoryViewModel
    {
        public ProductCategoryViewModel()
        {
            ProductViewModels = new List<ProductViewModel>();
        }
        public int ID { set; get; }
        public string Name { set; get; }
        //[Required]
        //[Column(TypeName = "varchar")]
        //[MaxLength(256)]
        public string Alias { set; get; }
        //[MaxLength(500)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        //[MaxLength(256)]
        public string Image { set; get; }
        public bool HomeFlag { set; get; }
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }
        public bool Status { set; get; }
        public virtual ICollection<ProductViewModel> ProductViewModels { set; get; }
    }
}