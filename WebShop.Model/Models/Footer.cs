using WebShop.Model.Abstract;

namespace WebShop.Model.Models
{
    //[Table("Footers")]
    public class Footer : BaseEntity
    {
        //[Key]//thuoc tinh khoa
        //[MaxLength(250)]
        //public string ID { set; get; }

        //[Required]//ko rong

        public string Content { set; get; }
    }
}