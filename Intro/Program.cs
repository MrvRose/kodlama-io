// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();
foreach (Course course in courses)
{
    Console.WriteLine(course.Name + " / " +course.Price);
}
CourseManager courseManager2 = new(new EfCourseDal());
List<Course> courses2 = courseManager2.GetAll();
foreach (Course course in courses2)
{
    Console.WriteLine(course.Name + " / " + course.Price);
}
