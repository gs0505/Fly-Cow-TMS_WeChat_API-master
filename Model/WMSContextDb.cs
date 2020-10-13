using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class WMSContextDb : DbContext
    {
        public WMSContextDb() { }
        public WMSContextDb(DbContextOptions<WMSContextDb> options) : base(options) { }


        public DbSet<OrderForm> orderform { get; set; }
    }
}
