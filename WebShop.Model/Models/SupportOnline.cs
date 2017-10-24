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
    //[Table("SupportOnlines")]
    public class SupportOnline : BaseEntity
    {
        //[Key]
        ///[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // public int ID { set; get; }
       // [Required]
        //[MaxLength(256)]
        public string Name { set; get; }
        //[MaxLength(256)]
        public string Department { set; get; }
        //[MaxLength(256)]
        public string Skype { set; get; }
        //[MaxLength(256)]
        public string Mobile { set; get; }
        //[MaxLength(256)]
        public string Email { set; get; }
        //[MaxLength(256)]
        public string Facebook { set; get; }
        //[MaxLength(256)]
        public string Yahoo { set; get; }
        //[Required]
        public bool Status { set; get; }
    }
}
