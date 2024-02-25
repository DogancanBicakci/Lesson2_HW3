using Lesson2_HW3.DataAccess.Abstracts;
using Lesson2_HW3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HW3.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new();
            course1.Id = 1;
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.Net)";
            course1.Price = "Free";
          
            Course course2 = new();
            course2.Id = 2;
            course2.Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course2.Price = "Free";

            Course course3 = new();
            course3.Id = 3;
            course3.Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course3.Price = "Free";

            Course course4 = new();
            course4.Id = 4;
            course4.Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course4.Price = "Free";

            Course course5 = new();
            course5.Id = 5;
            course5.Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course5.Price = "Free";

            Course course6 = new();
            course6.Id = 6;
            course6.Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
            course6.Price = "Free";

            Course course7 = new();
            course7.Id = 7;
            course7.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course7.Price = "Free";

            Course course8 = new();
            course8.Id = 8;
            course8.Name = "Programlamaya Giriş için Temel Kurs";
            course8.Price = "Free";

            _courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };

        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Console.WriteLine("Kurs silme işlemi burada gerekleşecek.");
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Kurs güncelleme işlemi burada gerekleşecek.");
        }
    }
}
