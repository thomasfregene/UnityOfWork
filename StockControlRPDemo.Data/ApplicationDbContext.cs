using Microsoft.EntityFrameworkCore;
using StockControlRPDemoCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockControlRPDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext()
        //{

        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<St_ItemMaster> St_ItemMasters { get; set; }
        public virtual DbSet<St_Supplier> St_Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<St_ItemMaster>().HasKey(h => new
            {
                h.ItemCode,
                h.ItemDesc,
            });

        }
    }
}
