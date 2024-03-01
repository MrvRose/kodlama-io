using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        static List<Course> courses;   
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Name = "C#";
            course1.Description = "7.Net...";
            course1.Price = 10; 
            course1.Id = 1;

            Course course2 = new Course();
            course2.Name = "Python";
            course2.Description = "8.Net...";
            course2.Price = 50;
            course2.Id = 2;
            Course course3 = new Course();
            course3.Name = "JAVA";
            course3.Description = "10.Net...";
            course3.Price = 9;
            course3.Id = 3;
            Course course4 = new Course();
            course4.Name = "C";
            course4.Description = ".Net...";
            course4.Price = 5;
            course4.Id = 4;

            courses = new List<Course> { course1, course2 ,course3, course4};
        }
     

        public List<Course> GetAll()
        {
            return courses;
        }

       public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}
