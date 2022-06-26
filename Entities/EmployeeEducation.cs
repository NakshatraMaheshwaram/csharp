using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Entities
{
    public class EmployeeEducation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [System.ComponentModel.DataAnnotations.Key]

        public int ID { get; set; }

        public string? CourseName { get; set; }

        public string? UniversityName { get; set; }


        public int PassingYear { get; set; }

        public int MarksPercentage { get; set; }

    }
}
    
