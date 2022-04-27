using System;
using System.Collections.Generic;
using System.Text;

namespace Migros.Models
{
     public class aramaürün
    {
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public int  UnitPrice { get; set; }
        public aramaürün()
        {

        }

        public aramaürün(string ProductName, string ProductImageUrl, int UnitPrice)
        {
           
            this.ProductName = ProductName;
            this.ProductImageUrl = ProductImageUrl;
            this.UnitPrice = UnitPrice;

        }

    }
   

    
}
