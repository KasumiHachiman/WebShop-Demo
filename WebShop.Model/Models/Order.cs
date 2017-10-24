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
    //[Table("Orders")]
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();

        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ID { set; get; }
        //[Required]
        //[MaxLength(356)]
        public string CustomerName { set; get; }
        //[Required]
        //[MaxLength(256)]
        public string CustomerAddress { set; get; }
        //[Required]
        //[MaxLength(256)]
        public string CustomerEmail { set; get; }
        //[Required]
        //[MaxLength(256)]
        public string CustomerMobile { set; get; }
        //[MaxLength(256)]
        public string CustomerMessage { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }
        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        public bool Status { set; get; }
        public virtual ICollection<OrderDetail> OrderDetails { set; get; }
    }
}