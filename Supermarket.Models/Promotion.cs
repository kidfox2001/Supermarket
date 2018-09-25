using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Supermarket.Models
{
    public abstract class Promotion
    {

        public  int Id { get; set; }
        [Required]
        [StringLength(255)]
        public  string Name { get; set; }
        [Required]
        public  bool IsEnabled { get; set; }


    }
}
