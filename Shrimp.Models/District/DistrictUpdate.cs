using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shrimp.Models.District
{
    public class DistrictUpdate
    {
        public int DistrictId { get; set; }
        public decimal CrimeRate { get; set; }
    }
}