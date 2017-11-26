using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebShop.Api.Models
{
    public class OrderDetailViewModel
    {
        public OrderDetailViewModel()
        {
            OrderViewModel = new OrderViewModel();
            ProductViewModel = new ProductViewModel();
        }
        public int OrderID { set; get; }

        public int ProductID { set; get; }

        public int Quantity { set; get; }

        public virtual OrderViewModel OrderViewModel { set; get; }

        //[ForeignKey("ProductID")]
        public virtual ProductViewModel ProductViewModel { set; get; }
    }
}