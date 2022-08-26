using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shrimp.Data.Entities
{
    public class DistrictEntity
    {
        [Key]
       public int DistrictId { get; set; }
       public DistrictName NameOfDistrict { get; set; }
       public decimal CrimeRate { get; set; }
       public DateTime Curfew { get; set; } 
       public DressCode CodeForDress { get; set; }
       public Resources AvailableResources { get; set; }
       public Permits PermitsNeeded { get; set; }
       public int WalkabilityRating { get; set; }
       [ForeignKey("SchoolId")]
       public int SchoolsId { get; set; }
       [ForeignKey("HouseId")]
       public int HousesId { get; set; }
    }
    public enum DistrictName { Skynet, UmbrellaCorp, BlackMesa, TheInstitute }
    public enum DressCode { Strict, Moderate, Comfortable }
    public enum Resources { Water, Agriculture, Lumber, Machinery }
    public enum Permits { Weapons, Hunting, Communications, Labor }
    
}