using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kodlama_io.Business.Abstract
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Delete(Course course); 
        void Update(Course course);
        List<Course> GetAll();
    }
}
