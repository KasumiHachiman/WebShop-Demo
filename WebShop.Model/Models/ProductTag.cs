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
    //[Table("ProductTags")]
    public class ProductTag
    {
        public ProductTag()
        {
            Tag = new Tag();
            Product = new Product();
        }
        //[Key]
        //[Column(Order = 1)]
        public int ProductID { set; get; }
        //[Key]
        //[MaxLength(50)]
        //[Column(TypeName = "varchar", Order = 2)]
        public string TagID { set; get; }
        //[ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        //[ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

    }
}
