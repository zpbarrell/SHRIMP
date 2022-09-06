using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Enums;

namespace Shrimp.Models.School
{
    public class SchoolCreate
    {
        [Key]
        [Required]
        public int SchoolId { get; set; }

        [Required]
        public NameOfSchool Name { get; set; }

        [Required]
        public Classes TypeOfClasses { get; set; }

        [Required]
        public int NumberOfStudents { get; set; }

        [Required]
        public float TeacherStudentRatio { get; set; }

        [Required]
        public decimal Costs { get; set; }

        [Required]
        public AfterSchoolPrograms TypeOfASP { get; set; }
    }
}