using System.ComponentModel.DataAnnotations;

namespace FirstBlazorApp.Data

{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(0.01, 1000, ErrorMessage = "Valid Price Range is (.01-1000")]
        public float BasePrice { get; set; }

        [Required]
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
