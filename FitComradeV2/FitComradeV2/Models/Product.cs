using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitComradeV2.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
