using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(356)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMobile { set; get; }

        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public DateTime? CreatedDate { set; get; }
        [MaxLength(250)]
        public string CreatedBy { set; get; }
        [MaxLength(500)]
        public string PaymentMethod { set; get; }
        [MaxLength(500)]
        public string PaymentStatus { set; get; }

        public bool Status { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}