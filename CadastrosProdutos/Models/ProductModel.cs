using System;
using System.ComponentModel.DataAnnotations;

namespace CadastrosProdutos.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [Range(0.1, Double.PositiveInfinity)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30)]
        public string Brand { get; set; }
        public DateTime UpdateAt { get; set; }
       
    }
}
