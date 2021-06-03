using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.BirthDayDbContext
{
    public class BirthDayDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4SAB20T\MYSQL;Database=BirthDayRadar;Trusted_Connection=true");

        }
        public DbSet<BirthDayRadar> BirthdayRadar { get; set; }
        

    }
}
