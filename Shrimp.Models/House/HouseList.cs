using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Enums;

namespace Shrimp.Models.House
{
    public class HouseList
    {
        [Key]
        [Required]
        public int HouseID { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public decimal HousePrice { get; set; }
        [Required]
        public int SquareFootage { get; set; }
        [ForeignKey(nameof(District))]
        public int DistrictId { get; set; }
    }
}