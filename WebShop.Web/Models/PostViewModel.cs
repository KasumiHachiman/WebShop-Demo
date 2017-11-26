using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Web.Models
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            PostCategoryViewModel = new PostCategoryViewModel();
            PostTagViewModels = new List<PostTagViewModel>();
        }
        public int ID { set; get; }
 
        public string Name { set; get; }
     
        public string Alias { set; get; }

        public int CategoryID { set; get; }
 
        public string Image { set; get; }

        public string Content { set; get; }
  
        public string Description { set; get; }

        public int? ParentID { set; get; }

        public int DisplayOrder { set; get; }


        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }
        public bool Status { set; get; }

        public virtual PostCategoryViewModel PostCategoryViewModel { set; get; }

        public virtual ICollection<PostTagViewModel> PostTagViewModels { set; get; }
    }
}