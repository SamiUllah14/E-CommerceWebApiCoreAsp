using System.ComponentModel.DataAnnotations;

namespace E_CommerceApi.Models.Dtos
{
    public class ProductsCreateDtos
    {

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public  string Description { get; set; }

        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public int occupancy { get; set; }

        public string Amenity { get; set; }
    }
}
