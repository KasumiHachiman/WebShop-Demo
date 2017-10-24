using WebShop.Model.Abstract;

namespace WebShop.Model.Models
{
    //[Table("Menus")]
    public class Menu : BaseEntity
    {
        public Menu()
        {
            MenuGroup = new MenuGroup();
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]// create int autoindentity
        //public int ID { set; get; }

        //[Required]
        //[MaxLength(256)]
        public string Name { set; get; }

        //[Required]
        //[MaxLength(256)]
        public string URL { set; get; }

        public int DisplayOrder { set; get; }

        //[Required]
        public int GroupID { set; get; }

        //[ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        //[MaxLength(10)]
        public string Target { set; get; }

        public bool Status { set; get; }
    }
}