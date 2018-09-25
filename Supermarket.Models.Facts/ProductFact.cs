using System;
using Xunit;

namespace Supermarket.Models.Facts
{
    public class ProductFact
    {
        public class GeneaUsage
        {
            [Fact]
            public void CreateProduct()
            {

                // arrange
                // act
                var p = new Product();

                // assert
                Assert.Equal("Product", p.Name);
                Assert.Equal(0, p.UnitsInStock);

            }
        }

        public class StockIn
        {
            [Fact]
            public void SingleStockIn()
            {
                var p = new Product();

                p.StockIn(5);

                Assert.Equal(5, p.UnitsInStock);
            }

            [Fact]
            public void UsesNegativeValue_ThrowsEx()
            {
                var p = new Product();

                Assert.ThrowsAny<Exception>(() =>
                {

                    p.StockIn(-10);

                });
            }

            [Fact]
            public void DiscontinuedProduct_NotAdd()
            {
                var p = new Product();
                p.StockIn(100);
                p.Discontinoued = true;

                p.StockIn(50);

                Assert.Equal(100, p.UnitsInStock);
            }

        }

        public class AdjustPrice
        {

        }
    }

}
