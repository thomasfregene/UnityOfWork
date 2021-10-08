﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UoW_Practice.Models
{
    [Table("st_stksystems")]
    public class St_StkSystem
    {
        //[Key]
        public Guid SystemId { get; set; }
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(60)]
        public string CompanyAddress { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(40)]
        public string State { get; set; }
        //public StateList State { get; set; }
        //public byte StateListId { get; set; }
        [StringLength(40)]
        public string Town_City { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InstallDate { get; set; }
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [StringLength(15)]
        public string GLCode { get; set; }
        public int? ProcessYear { get; set; }
        public int? ProcessMonth { get; set; }
        [StringLength(15)]
        public string ExpenseCode { get; set; }
        [StringLength(15)]
        public string WriteoffLoc { get; set; }
        [StringLength(15)]
        public string CreditorsCode { get; set; }
        [StringLength(2)]
        public string BusLine { get; set; }
        [StringLength(3)]
        public string HoldDays { get; set; }
        [StringLength(3)]
        public string ApprovedDay { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }


    }
}
