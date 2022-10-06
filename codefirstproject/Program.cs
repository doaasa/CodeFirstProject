using Microsoft.EntityFrameworkCore;
using System;

namespace codefirstproject
{
    class Program
    {
       public class student
        {
            public int id { get; set; }
            public string name { get; set; }
            public decimal GPA { get; set; }
            public int age { get; set; }
        }
        public class teacher
        {
           public int id { get; set; }
            public string name { get; set; }
            public decimal Salary { get; set; }
            public int age { get; set; }
        }
        public class SchoolContext : DbContext
        {
            public DbSet<student> students { get; set; }
            public DbSet<teacher>teachers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"server=DESKTOP-SFDKHS6\SQLEXPRESS;
                                               database=SchoolTestdb;
                                             Trusted_Connection=True;");
            }

        }



        static void Main(string[] args)
        {
        }

    }
}
