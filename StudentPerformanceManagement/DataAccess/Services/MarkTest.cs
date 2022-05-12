using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess.Services
{
    public class MarkTest
    {
        public void Select()
        {
            using (var Context = new StudentManagementContext())
            {
                var Marks = Context.marks.ToList();

                Console.WriteLine("---------------Marks------------------");
                foreach (var c in Marks)
                {
                    Console.WriteLine($"{c.mark_id}, {c.stud_id}, {c.sub_id}, {c.mark}");
                }
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
