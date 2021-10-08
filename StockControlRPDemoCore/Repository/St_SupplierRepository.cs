using StockControlRPDemo.Data;
using StockControlRPDemoCore.Entities;
using StockControlRPDemoCore.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockControlRPDemoCore.Repository
{
    public class St_SupplierRepository : Repository<St_Supplier, string>, ISt_Supplier
    {
        public St_SupplierRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }

    }
}
