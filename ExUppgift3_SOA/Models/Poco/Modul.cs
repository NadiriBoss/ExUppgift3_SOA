using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExUppgift3_SOA.Models
{
    public class Modul
    {
        [Key]
        public String ModulId { get; set; }
        public String ModulName { get; set; }

        public String Grade { get; set; }

        public DateTime Date { get; set; }
        [Key]
        public Course Course  { get; set; }
    }
}
