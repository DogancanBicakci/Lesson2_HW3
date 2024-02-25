using Lesson2_HW3.Business;
using Lesson2_HW3.DataAccess.Concretes;
using Lesson2_HW3.Entities;




CategoryManager categoryManager = new(new CategoryDal());

List<Category> categories = categoryManager.GetAll();
for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine("Kateegori adı: " + categories[i].GategoryName);
}

Console.WriteLine("-----------------------------------------------------------------------");

CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine("Kursun ismi: " + courses[i].Name);
    Console.WriteLine("Kursun ücreti: " + courses[i].Price);
}
courseManager.Delete(courses[6]);
courseManager.Update(courses[7]);

Console.WriteLine("-----------------------------------------------------------------------");

InstructorManager instructorManager = new(new InstructorDal());

List<Instructor> instructors = instructorManager.GetAll();
for (int i = 0; i <instructors.Count ; i++)
{
    Console.WriteLine("Eğitmen: " + instructors[i].FirstName + " " + instructors[i].LastName);
        
}