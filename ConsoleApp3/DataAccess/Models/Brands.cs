using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DataAccess.Models
{
  
        [Table("brands", Schema = "production")]

        public class Brands
        {
            [Key]
            public int brand_id { get; set; }
            public string brand_name { get; set; }
        }
    
}
