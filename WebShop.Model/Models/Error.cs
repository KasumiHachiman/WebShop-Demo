using System;
using WebShop.Model.Abstract;

namespace WebShop.Model.Models
{
    //[Table("Errors")]
    public class Error : BaseEntity
    {
        //[Key]
        //public int ID { set; get; }

        public string Message { set; get; }
        public string StackTrace { set; get; }
        public DateTime CreatedDate { set; get; }
    }
}