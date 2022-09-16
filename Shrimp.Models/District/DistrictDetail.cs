using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Enums;

namespace Shrimp.Models.District
{
    public class DistrictDetail
    {
        public int DistrictId { get; set; }
        public DistrictName NameOfDistrict { get; set; }
        public decimal CrimeRate { get; set; }
        public int Curfew { get; set; }
        public DressCode CodeForDress { get; set; }
        public Resources AvailableResources { get; set; }
        public Permits PermitsNeeded { get; set; }
        public int WalkabilityRating { get; set; }
    }
}