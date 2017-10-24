﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Model.Abstract;

namespace WebShop.Model.Models
{
    //[Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]// create int autoindentity
       // public int ID { set; get; }
        //[Required]
        //[MaxLength(256)]
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
        public virtual ICollection<Product> Products { set; get; }
    }
}
