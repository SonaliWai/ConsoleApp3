using StudentPerformanceManagement.DataAccess;
using StudentPerformanceManagement.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class StudentTest
    {
        public void Select()
        {
            using (var Context = new StudentManagementContext())
            {
                var student = Context.students.ToList();

                Console.WriteLine("---------------------------------------Student--------------------------------------------------");
                Console.WriteLine(" -----------------------------------------------------------------------------------------------");
                Console.WriteLine("| std_id   |  rollno    |  stud_name  |  Email                  |  address  |    course_id   ");
                Console.WriteLine(" -----------------------------------------------------------------------------------------------");
                foreach (var c in student)
                {
                    Console.WriteLine($"{c.stud_id,(-10)} | {c.roll_no,(-10)} | {c.stud_name,(-10)} | {c.Email,(-25)}| {c.address,(-10)} | {c.course_id,(-10)}");
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------");
            }
        }

        public void Add()
        {
            var context = new StudentManagementContext();
            var stud = new Student
            {
                roll_no = 32,
                stud_name = "Adil",
                Email = "adil@123",
                address = "J M Road",
                course_id = 2,

            };

            context.students.Add(stud);
            context.SaveChanges();

            context.Dispose();
        }

        public void Delete()
        {
            Console.WriteLine("enter delete student id : >>  ");
            var studentIdText = Console.ReadLine();
            var studentIdToBeDeleted = int.Parse(studentIdText);

            using var context = new StudentManagementContext();

            var stud = context.students.FirstOrDefault(xyz => xyz.stud_id == studentIdToBeDeleted);

            if (stud == null)
            {
                Console.WriteLine($"student with id = {studentIdToBeDeleted} not found");
                return;
            }

            context.students.Remove(stud);
            context.SaveChanges();

            context.Dispose();
        }
        public void Update()
        {
            Console.WriteLine("Enter the student Id to be updated ");
            var studentIdText = Console.ReadLine();
            var studentIdToBeUpdated = int.Parse(studentIdText);

            using var context = new StudentManagementContext();

            var studd = context.students.FirstOrDefault(xyz => xyz.stud_id == studentIdToBeUpdated);

            if (studd == null)
            {
                Console.WriteLine($"student with id = {studentIdToBeUpdated} not found");
                return;
            }

             
            

            context.students.Update(studd);
            context.SaveChanges();
        }
        
    }
}
