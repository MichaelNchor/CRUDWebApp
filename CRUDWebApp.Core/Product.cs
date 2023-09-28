using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDWebApp.Core
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Qty { get; set; }
    }
}
