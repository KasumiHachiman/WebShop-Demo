using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Api.Models
{
    public class PostTagViewModel
    {
        public PostTagViewModel()
        {
            PostViewModel = new PostViewModel();
            TagViewModel = new TagViewModel();
        }
        public int PostID { set; get; }
        public string TagID { set; get; }
        public virtual PostViewModel PostViewModel { set; get; }
        public virtual TagViewModel TagViewModel { set; get; }
    }
}