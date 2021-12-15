using Microsoft.EntityFrameworkCore;
using SqlProject2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject2.Datacontext
{
    public class EFDatacontext : DbContext
    {
        public DbSet<ProductModel> productModels { get; set; }

        public DbSet<SaleItemModel> saleItemModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(@"Data Source=c:\Dbsql\MyDb.db;");
                }
    }
}
