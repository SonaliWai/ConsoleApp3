using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DataAccess.Models
{
    [Table("categories", Schema = "production")]

    public class Categories
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
    }
}
