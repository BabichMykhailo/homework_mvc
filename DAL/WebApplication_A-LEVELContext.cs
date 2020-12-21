using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WebApplication_A_LEVELContext : DbContext
    {
        public WebApplication_A_LEVELContext() : base("name = DefaultConnection")
        {
            Database.SetInitializer<WebApplication_A_LEVELContext>(new WebApplication_A_LEVELInitializer());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
