using System.ComponentModel.DataAnnotations;

namespace Enterprise_Programming_in_C_Project
{

    // my product calss 
    // Added some validation as well
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [Url]
        public string ImageUrl { get; set; }
    }


}
