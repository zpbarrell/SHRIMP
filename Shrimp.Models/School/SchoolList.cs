using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Entities;
using Shrimp.Data.Enums;

namespace Shrimp.Models.School
{
    public class SchoolList
    {
        [Key]
        [Required]
        public int SchoolId { get; set; }
        [Required]
        public NameOfSchool Name { get; set; }
        [Required]
        public decimal Costs { get; set; }
    }
}