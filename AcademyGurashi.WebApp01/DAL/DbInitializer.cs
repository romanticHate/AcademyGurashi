using AcademyGurashi.WebApp01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyGurashi.WebApp01.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(AcademyGurashiDbContext context)
        {
            context.Database.EnsureCreated();

            var courses = new Course[] 
            {
                new Course{CourseID=1050,Title="Chemistry"},
                new Course{CourseID=4022,Title="Microeconomics"},
                new Course{CourseID=4041,Title="Macroeconomics"},
                new Course{CourseID=1045,Title="Calculus"},
                new Course{CourseID=3141,Title="Trigonometry"},
                new Course{CourseID=2021,Title="Composition"},
                new Course{CourseID=2042,Title="Literature"}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();
        }
    }
}
