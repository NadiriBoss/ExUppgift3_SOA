using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExUppgift3_SOA.Models
{
    public class Course
    {
        [Key]
        public String CourseId { get; set; }
        public String CourseName { get; set; }

        public DateTime CourseDate { get; set; }


    }
}
