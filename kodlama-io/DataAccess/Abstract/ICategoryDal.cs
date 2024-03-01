using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);

    }
}
