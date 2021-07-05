using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyGurashi.WebMVC.Models
{
    public class Course
    {       
        public int CourseID { get; set; }
        public string Title { get; set; }       

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
