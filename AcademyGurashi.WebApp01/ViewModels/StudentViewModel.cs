using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace AcademyGurashi.WebApp01.ViewModels
{
    public class StudentViewModel
    {      
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public IList<SelectListItem> Courses { get; set; }
    }
}
