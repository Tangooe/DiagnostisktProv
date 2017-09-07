using System.ComponentModel.DataAnnotations;

namespace DiagnostisktProv.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Range(5,1000)]
        public decimal Price { get; set; }
    }
}