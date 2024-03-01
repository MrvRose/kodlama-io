using kodlama_io.DataAccess.Abstract;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>();
        }
        public void Add(Category category)
        {
           _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories.ToList();
        }

        public void Update(Category category)
        {
           var existingCategory = _categories.FirstOrDefault(c=>c.CategoryId == category.CategoryId);
            if (existingCategory != null)
            {
                existingCategory.CategoryId = category.CategoryId;
                existingCategory.CategoryName = category.CategoryName;
                _categories.Add(existingCategory);
            }
            else
            {
                Console.WriteLine("Güncellenecek kategori bulunamadı");
            }
        }
    }
}
