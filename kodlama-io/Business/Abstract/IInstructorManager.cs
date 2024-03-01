using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.Business.Abstract
{
    public interface IInstructorManager
    {
        void Add(Instructor ınstructor);
        void Delete(Instructor ınstructor);
        void Update(Instructor ınstructor); 
        List<Instructor> GetAll();
    }
}
