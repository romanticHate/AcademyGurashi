using System.Collections.Generic;

namespace AcademyGurashi.WebApp01.Models
{
    public class Course
    {       
        public int CourseID { get; set; }
        public string Title { get; set; }       

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
