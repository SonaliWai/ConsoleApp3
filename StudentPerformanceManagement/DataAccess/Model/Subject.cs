using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess.Model
{
    [Table("Subject", Schema= "course")]
    public class Subject
    {
        [Key]
        public int sub_id { get; set; }
        public string sub_title { get; set; }
        public string sub_description { get; set; }

        public int course_id { get; set; }
        [ForeignKey("course_id")]
        public Course course { get; set; }
        public string subject_code { get; set; }

    }
}
