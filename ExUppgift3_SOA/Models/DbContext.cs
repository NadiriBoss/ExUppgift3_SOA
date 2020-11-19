using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExUppgift3_SOA.Models
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) :base(options)
        {
        }

        DbSet<Course> Course { get; set; }
        DbSet<Modul> Modul { get; set; }
        DbSet<Student> Student { get; set; }

       
    }

}
