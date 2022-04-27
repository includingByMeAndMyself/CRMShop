using CrmBuisnessLogic.Models;
using System.Data.Entity;


namespace CrmBuisnessLogic
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("DbConection") { }

        public DbSet<Check> Checks { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sell> Sells { get; set; }

        public DbSet<Seller> Sellers { get; set; }
    }
}
