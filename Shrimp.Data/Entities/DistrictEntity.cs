using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Enums;

namespace Shrimp.Data.Entities
{
    public class DistrictEntity
    {
        [Key]
       public int Id { get; set; }
       public DistrictName NameOfDistrict { get; set; }
       public decimal CrimeRate { get; set; }
       public int Curfew { get; set; } 
       public DressCode CodeForDress { get; set; }
       public Resources AvailableResources { get; set; }
       public Permits PermitsNeeded { get; set; }
       public int WalkabilityRating { get; set; }
    //    [ForeignKey("SchoolId")]
    //    public int SchoolsId { get; set; }
    //    [ForeignKey("HouseId")]
    //    public int HousesId { get; set; }
    }
    
    
}