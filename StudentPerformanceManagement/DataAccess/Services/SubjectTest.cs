using StudentPerformanceManagement.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess.Services
{
    public class SubjectTest
    {
        public void Select()
        {
            using (var Context = new StudentManagementContext())
            {
                var subject = Context.subjects.ToList();

                Console.WriteLine("-----------------------------------------------Subject---------------------------");
                Console.WriteLine(" --------------------------------------------------------------------------------");
                Console.WriteLine("| sub_id   |  sub_title |  sub_description|  course_id |  subject_code   ");
                Console.WriteLine(" --------------------------------------------------------------------------------");
                foreach (var c in subject)
                {
                    Console.WriteLine($"{c.sub_id,(-10)} | {c.sub_title,(-10)} | {c.sub_description,(-15)} | {c.course_id,(-10)} | {c.subject_code}");
                }
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
        }
        public void Add()
        {
            var context = new StudentManagementContext();
            var subject = new Subject
            {

                sub_title = "cloude",    
                sub_description = "asdf",
                course_id = 2,
                subject_code = "132",
            };

            context.subjects.Add(subject);
            context.SaveChanges();

            context.Dispose();
        }
        public void Delete()
        {
            Console.WriteLine("enter delete subject id : >>  ");
            var subjectIdText = Console.ReadLine();
            var subjectIdToBeDeleted = int.Parse(subjectIdText);

            using var context = new StudentManagementContext();

            var subject = context.subjects.FirstOrDefault(xyz => xyz.sub_id == subjectIdToBeDeleted);

            if (subject == null)
            {
                Console.WriteLine($"subject with id = {subjectIdToBeDeleted} not found");
                return;
            }

            context.subjects.Remove(subject);
            context.SaveChanges();

            context.Dispose();
        }
        public void Update()
        {
            Console.WriteLine("Enter the subject Id to be updated ");
            var subjectIdText = Console.ReadLine();
            var subjectIdToBeUpdated = int.Parse(subjectIdText);

            using var context = new StudentManagementContext();

            var subject = context.subjects.FirstOrDefault(xyz => xyz.sub_id == subjectIdToBeUpdated);

            if (subject == null)
            {
                Console.WriteLine($"subject with id = {subjectIdToBeUpdated} not found");
                return;
            }

            context.subjects.Update(subject);
            context.SaveChanges();
        }
    }
}
