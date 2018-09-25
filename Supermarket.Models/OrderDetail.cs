using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supermarket.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [Required]
        public virtual Product Product { get; set; }
        public decimal  Discount { get; set; }
        /// <summary>
        /// Total Amount Before Discount
        /// </summary>
        public decimal Total { get; set; }

        public virtual Promotion Promotion { get; set; }
        [ForeignKey(nameof(Promotion))]
        public int? PromotionId { get; set; }
    }
}