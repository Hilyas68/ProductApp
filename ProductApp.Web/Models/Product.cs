using System.ComponentModel.DataAnnotations;

namespace ProductApp.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual Category category { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

    }


}