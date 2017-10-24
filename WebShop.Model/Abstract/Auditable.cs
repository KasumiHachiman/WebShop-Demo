﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model.Abstract
{
    public class Auditable : BaseEntity
    {
        public DateTime? CreatedDate { set; get; }
        //[MaxLength(250)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        //[MaxLength(250)]
        public string UpdatedBy { set; get; }
        //[MaxLength(250)]
        public string MetaKeyword { set; get; }
        //[MaxLength(500)]
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
