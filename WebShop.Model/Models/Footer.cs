using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]//thuoc tinh khoa
        [MaxLength(250)]
        public string ID { set; get; }

        [Required]//ko rong
        [MaxLength(500)]
        public string Content { set; get; }
    }
}