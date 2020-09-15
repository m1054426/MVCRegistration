using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCRegistration.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Immunization { get; set; }
        public string Other { get; set; }
    }

    public class DBStudent : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}