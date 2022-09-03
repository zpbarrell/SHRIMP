using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Enums;

namespace Shrimp.Models.District
{
    public class DistrictCreate
    {
        public DistrictName NameOfDistrict { get; set; }
        public decimal CrimeRate { get; set; }
        public int Curfew { get; set; }
        public DressCode CodeForDress { get; set; }
        public Resources AvailableResources { get; set; }
        public Permits PermitsNeeded { get; set; }
        public int WalkabilityRating { get; set; }

    }
    // public enum DistrictName { Skynet, UmbrellaCorp, BlackMesa, TheInstitute }
    // public enum DressCode { Strict, Moderate, Comfortable }
    // public enum Resources { Water, Agriculture, Lumber, Machinery }
    // public enum Permits { Weapons, Hunting, Communications, Labor }
}