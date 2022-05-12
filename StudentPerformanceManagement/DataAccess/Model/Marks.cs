using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess.Model
{
    [Table("mark",Schema="Mark")]
    public class Marks
    {
        [Key]
       public int mark_id { get; set; }
        public int stud_id { get; set; }
        
        public int sub_id { get; set; }
        public int mark { get; set; }
    }
}
