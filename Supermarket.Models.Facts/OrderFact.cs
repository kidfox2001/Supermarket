using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Supermarket.Models.Facts
{
  public  class OrderFact
    {

        public class generalUsage
        {
            [Fact]
            public void CreateOrder()
            {
                var o = new Order();

                Assert.Empty(o.LineItems);
                Assert.Equal(0m, o.Total);
            }
        }

        public class Scan
        {
            [Fact]
            public void SingleScan()
            {
                var o = new Order();
                var p1 = new Product("A", "A", 10m);

                o.Scan(p1);
                Assert.Single(o.LineItems);
                Assert.Equal(10m, o.Total);

                var item = o.LineItems.ToList()[0];
                Assert.Equal(1, item.Quantity);
                Assert.Equal(10m, item.Price);
                Assert.Same(p1, item.Product);
                Assert.Equal(10m, item.Total);
            }

            [Fact]
            public void DoubleScan()
            {
                var o = new Order();
                var p1 = new Product("A","A", 10m);

                o.Scan(p1);
                o.Scan(p1);
                Assert.Single(o.LineItems);
                Assert.Equal(20m, o.Total);

                var item = o.LineItems.ToList()[0];
                Assert.Equal(2, item.Quantity);
                Assert.Equal(10m, item.Price);
                Assert.Same(p1, item.Product);
                Assert.Equal(20m, item.Total);
            }

            [Fact]
            public void MoreScan()
            {
                var o = new Order();
                var p1 = new Product( "A","A", 10m);
                var p2 = new Product("B","B", 20m);
                var p3 = new Product("C","C", 100m);


                o.Scan(p1);
                o.Scan(p2);
                o.Scan(p1);
                o.Scan(p3);

                Assert.Equal(3,o.LineItems.Count);
                Assert.Equal(140m, o.Total);

                var item1 = o.LineItems.SingleOrDefault(x => x.Product== p1);
                Assert.Equal(2, item1.Quantity);
                Assert.Equal(10m, item1.Price);
                Assert.Equal(20m, item1.Total);
                //Assert.Same(p1, item.Product);

                var item2 = o.LineItems.SingleOrDefault(x => x.Product == p2);
                Assert.Equal(1, item2.Quantity);
                Assert.Equal(20m, item2.Price);
                Assert.Equal(20m, item1.Total);
                // Assert.Same(p2, item.Product);
            }

        }


        public class Checkout
        {
            [Fact]
            public void BM4L()
            {
                var o = new Order();
                var p1 = new Product("A", "A", 50m);
                o.Scan(p1);
                o.Scan(p1);

                var pr1 = new BuyMoreForLessPromotion();
                pr1.Product = p1;
                pr1.Quantity = 2;
                pr1.DiscoiuntPrice = 80m;


                o.Checkout(new Promotion[] { pr1 });
                Assert.Equal(80m, o.Total);

                var item = o.LineItems.ToList()[0];
                Assert.Equal(20m, item.Discount);
                Assert.Same(pr1, item.Promotion);


            }

            [Fact]
            public void BM4L_2()
            {
                var o = new Order();
                var p1 = new Product("A", "A", 50m);
                o.Scan(p1);
                o.Scan(p1);
                o.Scan(p1);
                o.Scan(p1);
                o.Scan(p1);

                var pr1 = new BuyMoreForLessPromotion();
                pr1.Product = p1;
                pr1.Quantity = 2;
                pr1.DiscoiuntPrice = 80m;


                o.Checkout(new Promotion[] { pr1 });
                Assert.Equal(210m, o.Total);

                var item = o.LineItems.ToList()[0];
                Assert.Equal(40m, item.Discount);
                Assert.Same(pr1, item.Promotion);


            }
        }
    }
}
