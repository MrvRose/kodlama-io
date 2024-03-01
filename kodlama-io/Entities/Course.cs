using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CourseName { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int Price { get; set; }
    }
}
