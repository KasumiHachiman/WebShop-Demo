using WebShop.Model.Abstract;

namespace WebShop.Model.Models
{
    //[Table("SystemConfigs")]
    public class SystemConfig : BaseEntity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ID { set; get; }
        //[Required]
        //[MaxLength(256)]
        //[Column(TypeName = "varchar")]
        public string Code { set; get; }

        //[MaxLength(256)]
        public string ValueString { set; get; }

        public int ValueInt { set; get; }
    }
}