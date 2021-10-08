﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UoW_Practice.Models
{
    [Table("st_stockclass")]
    public class St_StockClass
    {
        //[Key]
        public Guid ClassId { get; set; }
        [StringLength(15)]
        public string SktClass { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
