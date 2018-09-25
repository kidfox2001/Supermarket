using Microsoft.EntityFrameworkCore;
using Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Data
{
    public class SupermarketDb : DbContext
    {
        //ctor tab tab
        public SupermarketDb(DbContextOptions<SupermarketDb> options):base (options)
        {

        }

        public DbSet<Product>   Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<BuyMoreForLessPromotion> BuyMoreForLessPromotions{ get; set; }

    }
}
