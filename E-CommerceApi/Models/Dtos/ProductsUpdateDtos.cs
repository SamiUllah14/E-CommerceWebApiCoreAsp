using System.ComponentModel.DataAnnotations;

namespace E_CommerceApi.Models.Dtos
{
    public class ProductsUpdateDtos
    {
        [Required]

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string Price { get; set; }
        [Required]

        public string ImageUrl { get; set; }
        [Required]

        public int occupancy { get; set; }
        public string Amenity { get; set; }
    }
}
