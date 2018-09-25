using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Supermarket.Models
{
    public class BuyMoreForLessPromotion : Promotion
    {
        public int Quantity { get; set; }
        public decimal DiscoiuntPrice { get; set; }

        [Required]
        public virtual Product Product { get; set; }

    }
}
