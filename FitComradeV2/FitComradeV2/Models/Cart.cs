using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitComradeV2.Models
{
    public class Cart
    {
        public string CartID { get; set; }
        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void UpdateCart()
        {
            
        }
        public void CheckOut()
        {

        }
    }
}
