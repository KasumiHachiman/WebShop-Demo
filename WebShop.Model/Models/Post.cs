﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Model.Abstract;

namespace WebShop.Model.Models
{
    //[Table("Posts")]
    public class Post : Auditable
    {
        public Post()
        {
            PostCategory = new PostCategory();
            PostTags = new List<PostTag>();
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ID { set; get; }
        //[Required]
        //[MaxLength(256)]
        public string Name { set; get; }
        //[Column(TypeName = "varchar")]
        //[MaxLength(256)]
        //[Required]
        public string Alias { set; get; }
        //[Required]
        public int CategoryID { set; get; }
        //[MaxLength(256)]
        public string Image { set; get; }

        public string Content { set; get; }
        //[MaxLength(500)]
        public string Description { set; get; }

        public int? ParentID { set; get; }

        public int DisplayOrder { set; get; }


        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }
        //[ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

        public virtual ICollection<PostTag> PostTags { set; get; }
    }
}
