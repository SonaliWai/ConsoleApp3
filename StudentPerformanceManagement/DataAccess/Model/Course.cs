using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess.Model
{
    [Table("course",Schema="Course")]
    public class Course
    {
        [Key]
        public int course_id { get; set; }
        public string course_title { get; set; }
        public string course_description { get; set; }
        public int course_code { get; set; }
    }
}
