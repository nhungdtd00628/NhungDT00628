using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EXAM2.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }

        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public string UnitslnStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReoderLevel { get; set; }
        public string Discontinued { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
       
    }
}
