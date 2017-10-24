using System.Collections.Generic;
using WebShop.Model.Abstract;

namespace WebShop.Model.Models
{
    //[Table("MenuGroups")]
    public class MenuGroup : BaseEntity
    {
        public MenuGroup()
        {
            Menus = new List<Menu>();
        }
       
        public string Name { set; get; }

        public virtual ICollection<Menu> Menus { set; get; }
    }
}