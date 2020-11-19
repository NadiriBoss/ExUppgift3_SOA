using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExUppgift3_SOA.Models
{
    public class Student
    {
        [Key]
        public String StudentID { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String PersNr { get; set; }

    }
}
