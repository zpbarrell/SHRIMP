using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Enums;

namespace Shrimp.Models.House
{
    public class HouseUpdate
    {
        [Key]
        public int HouseID { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public decimal HousePrice { get; set; }
        [Required]
        public int SquareFootage { get; set; }
        [Required]
        public int Bedrooms { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public Amenities HousingAmenities { get; set; }
        [Required]
        public int RadtiationLevels { get; set; }
        [Required]
        public int SafetyRating { get; set; }
        [ForeignKey(nameof(District))]
        public int DistrictId { get; set; }
    }
}