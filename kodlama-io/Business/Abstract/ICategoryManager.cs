using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Delete(Category category); 
        void Update(Category category); 
        List<Category> GetAll();
    }
}
