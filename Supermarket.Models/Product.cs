using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Models
{
    public class Product
    {
        // filds (data)
        private int _unitsInStock;

        // constructor
        public Product() : this("SKU","Product", 0m)
        {

        }

        public Product(string sku ,string name, decimal cost)
        {
            Name = name;
            Price = cost;
            SKU = sku;
        }

        // properties
        [Key]
        public string SKU { get; set; }  // id or productId will be key by default
        [Required(ErrorMessage ="กรุณาใส่ชื่อสินค้า")]
        [StringLength(20,MinimumLength = 3)]
        public string Name { get; set; }
        public int UnitsInStock
        {
            get => _unitsInStock;
            set => _unitsInStock = value;
        }
        public bool Discontinoued { get; set; } = false;
        [Range(0,99999)]
        public decimal Price { get;  set; }
        [StringLength(256)]
        public string FileName { get; set; }


        // method
        public void AdjustPrice(decimal newPrice)
        {
            var delta = Price * 0.1m;
            if (Math.Abs(Price - newPrice) > delta) return;

            Price = newPrice;
        }

        public void StockIn(int quantity)
        {
            if (quantity < 0)
            {
                throw new Exception();
            }

            if (Discontinoued) return;  // precondition

            _unitsInStock += quantity;
        }

        public void StockOut(int quantity)
        {
            if (_unitsInStock - quantity < 0) return;

            _unitsInStock -= quantity;
        }

        public void SetDiscontinue()
        {
            Discontinoued = true;
        }

        public void SetContinue()
        {
            Discontinoued = false;
        }

    }
}
