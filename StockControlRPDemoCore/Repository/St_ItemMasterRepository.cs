using StockControlRPDemo.Data;
using StockControlRPDemoCore.Entities;
using StockControlRPDemoCore.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockControlRPDemoCore.Repository
{
    public class St_ItemMasterRepository : Repository<St_ItemMaster, int>, ISt_ItemMaster
    {
        public St_ItemMasterRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
