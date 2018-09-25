using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket.Models
{
    public class Order
    {
        public Order()
        {
            LineItems = new List<OrderDetail>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public virtual ICollection<OrderDetail> LineItems { get; set; } = new HashSet<OrderDetail>();
        public decimal Total { get; set; }

        public void Checkout(IEnumerable<Promotion> promotions = null)
        {
            foreach (var line in LineItems)
            {
                foreach (var promo in promotions)
                {
                    switch (promo)
                    {
                        case BuyMoreForLessPromotion p when p.Product == line.Product:
                            var discount = (p.Product.Price * p.Quantity) - p.DiscoiuntPrice;
                            var packs = line.Quantity / p.Quantity;
                            var totalDiscount = discount * packs;

                            line.Discount = totalDiscount;
                            line.Promotion = promo;

                            Total -= totalDiscount;

                            break;
                    }
                }

                line.Product.StockOut(line.Quantity);
            }
        }

        public void Scan(Product item)
        {
            OrderDetail product = LineItems.SingleOrDefault(x => x.Product.SKU == item.SKU);
            if (product == null)
            {
                var detail = new OrderDetail()
                {
                    Product = item,
                    Price = item.Price,
                    Quantity = 1,
                    Total = item.Price
                };

                LineItems.Add(detail);

                Total += detail.Total;
            }
            else
            {
                product.Quantity ++;
                product.Total += item.Price;

                Total += item.Price; 
            }
        }
    }

}