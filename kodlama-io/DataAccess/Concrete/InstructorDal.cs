using kodlama_io.DataAccess.Abstract;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _ınstructorDal;
        public InstructorDal() 
        {
            _ınstructorDal = new List<Instructor>();

        }
        public void Add(Instructor ınstructor)
        {
            _ınstructorDal.Add(ınstructor);
        }

        public void Delete(Instructor ınstructor)
        {
            _ınstructorDal.Remove(ınstructor);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDal;
        }

        public void Update(Instructor ınstructor)
        {
            var existingInstuctor = _ınstructorDal.FirstOrDefault(i => i.InstructorId == ınstructor.InstructorId);
            if (existingInstuctor != null)
            {
                existingInstuctor.InstructorName = ınstructor.InstructorName;
                existingInstuctor.InstructorSurname = ınstructor.InstructorSurname;
                existingInstuctor.InstructorId = ınstructor.InstructorId;
                existingInstuctor.InstructorEmail = ınstructor.InstructorEmail;
            }
            else
            {
                Console.WriteLine("Güncellenecek eğitimci bulunamadı");
            }
        }
    }
}
