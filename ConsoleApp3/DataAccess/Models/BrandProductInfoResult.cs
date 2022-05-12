using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DataAccess.Models
{
    public class BrandProductInfoResult
    {
        [Key]
        //variables_names / properties exactly same as person table variables / column_names in entity framework core       
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string brand_name { get; set; }
        public string category_name { get; set; }
        public decimal list_price { get; set; }
    }
}
