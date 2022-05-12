using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess.Model
{
    [Table("student",Schema="Student")]
    public class Student
    {
        [Key]
        public int stud_id { get; set; }
        public int roll_no { get; set; }
        public string stud_name { get; set; }
        public string Email { get; set; }
        public string address { get; set; }
        public int course_id { get; set; }
    }
}
