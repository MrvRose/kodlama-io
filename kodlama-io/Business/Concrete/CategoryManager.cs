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
    public class CategoryManager : ICategoryManager
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);   
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);  
        }
    }
}
