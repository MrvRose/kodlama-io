using kodlama_io.DataAccess.Abstract;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>();
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            var existingCourse = _courses.FirstOrDefault(c=>c.CourseId == course.CourseId);
            if (existingCourse != null)
            {
                existingCourse.CourseId = course.CourseId;
                existingCourse.CourseName = course.CourseName;
                existingCourse.Price = course.Price;
                existingCourse.CategoryId = course.CategoryId;
                _courses.Add(course);
            }
            else
            {
                Console.WriteLine("Güncellenecek kurs bulunamadı");
            }
        }
    }
}
