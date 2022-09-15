using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Shrimp.Data.Enums;

namespace Shrimp.Data.Entities
{
    public class HouseEntity
    {
        [Key]
        public int HouseID { get; set; }
        public string Address { get; set; }
        public decimal HousePrice { get; set; }
        public int SquareFootage { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public Amenities HousingAmenities { get; set; }
        public int RadtiationLevels { get; set; }
        public int SafetyRating { get; set; } 
        public int DistrictId { get; set; }
    }

}