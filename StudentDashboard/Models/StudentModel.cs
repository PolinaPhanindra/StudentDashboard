using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace StudentDashboard.Models
{
    public class StudentModel 
    {   
        [Display(Name ="Id")]
        public int ID { get; set; }
        [Required(ErrorMessage ="First name is required")]
        [Display(Name ="FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Lastname is required")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public String Country { get; set; }
        public int Age { get; set; }
    }
    public class StudentCourseDetails
    {
        public  int Credit { get; set; }
        public string Department { get; set; }
        public string CourseReg { get; set; }
    }
    public class StudentEnitity : DbSet
    {
        public int Id { get; set; }

    }
    public class StudentDbContext: DbContext
    {
        public List<StudentEnitity> StudentEnitity { get ; set; }
    }
}