using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Shrimp.Data.Enums;

namespace Shrimp.Data.Entities
{
    public class SchoolEntity
    {
        [Key]
        public int SchoolId { get; set; } 
        public NameOfSchool Name { get; set; }
        public Classes TypeOfClasses { get; set; }
        public int NumberOfStudents { get; set; }
        public float TeacherStudentRatio { get; set; }
        public decimal Costs { get; set; }
        public AfterSchoolPrograms TypeOfASP { get; set; }
    }
}