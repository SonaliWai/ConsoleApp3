using StudentPerformanceManagement.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess.Services
{
    public class CourseTest
    {
        public void Select()
        {
            using (var Context = new StudentManagementContext())
            {
                var course = Context.courses.ToList();

                Console.WriteLine("---------------------Course--------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine("| course_id |  course_title  |  course_description |  course_code ");
                Console.WriteLine(" ---------------------------------------------------------------------");
                foreach (var c in course)
                {
                    Console.WriteLine($"{c.course_id,(-10)} | {c.course_title,(-15)} | {c.course_description,(-20)} | {c.course_code,(-10)}");
                }
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        public void Add()
        {
            var context = new StudentManagementContext();
            var cour = new Course
            {
                
                course_title = "Stat",
                course_description = "statistician",
                course_code = 121
            };

            context.courses.Add(cour);
            context.SaveChanges();

            context.Dispose();
        }
        public void Delete()
        {
            Console.WriteLine("Enter the course Id to be deleted ");
            var courseIdText = Console.ReadLine();
            var courseIdToBeDeleted = int.Parse(courseIdText);

            using var context = new StudentManagementContext();

            var cour = context.courses.FirstOrDefault(xyz => xyz.course_id == courseIdToBeDeleted);

            if (cour == null)
            {
                Console.WriteLine($"course with id = {courseIdToBeDeleted} not found");
                return;
            }

            context.courses.Remove(cour);
            context.SaveChanges();

            context.Dispose();
        }
        public void Update()
        {
            Console.WriteLine("Enter the course Id to be updated ");
            var courseIdText = Console.ReadLine();
            var courseIdToBeUpdated = int.Parse(courseIdText);

            using var context = new StudentManagementContext();

            var course = context.courses.FirstOrDefault(xyz => xyz.course_id == courseIdToBeUpdated);

            if (course == null)
            {
                Console.WriteLine($"course with id = {courseIdToBeUpdated} not found");
                return;
            }

            //Console.WriteLine("Enter course_title");
            //courseIdText = Console.ReadLine();
            course.course_title = course.course_title + "01";
            course.course_description = course.course_description + "10";


            context.courses.Update(course);
            context.SaveChanges();
        }
    }
}
