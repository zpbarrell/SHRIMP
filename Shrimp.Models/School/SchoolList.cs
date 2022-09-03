using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Entities;
using Shrimp.Data.Enums;

namespace Shrimp.Models.School
{
    public class SchoolList
    {
        public int SchoolId { get; set; }
        public NameOfSchool Name { get; set; }
        public decimal Costs { get; set; }
    }
}