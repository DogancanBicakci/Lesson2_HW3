using Lesson2_HW3.DataAccess.Abstracts;
using Lesson2_HW3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HW3.DataAccess.Concretes
{
    
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            Category category1= new();
            category1.Id = 1;
            category1.GategoryName = "Tümü";

            Category category2 = new();
            category2.Id = 2;
            category2.GategoryName = "Programlama (8)";

            _categories = new List<Category> { category1, category2 };
                     
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }
       
        public void Delete(Category category)
        {
            Console.WriteLine("Kategori silme işlemi burada gerekleşecek.");
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Kategori güncelleme işlemi burada gerekleşecek.");
        }
    }
}
