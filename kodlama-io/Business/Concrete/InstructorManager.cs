using kodlama_io.Business.Abstract;
using kodlama_io.DataAccess.Abstract;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.Business.Concrete
{
    public class InstructorManager : IInstructorManager
    {
        private IInstructorDal _ınstructorDal;
        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public void Add(Instructor ınstructor)
        {
            _ınstructorDal.Add(ınstructor);
        }

        public void Delete(Instructor ınstructor)
        {
            _ınstructorDal.Delete(ınstructor);
        }

        public List<Instructor> GetAll()
        {
           return _ınstructorDal.GetAll();  
        }

        public void Update(Instructor ınstructor)
        {
            _ınstructorDal.Update(ınstructor);
        }
    }
}
