using phase1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace phase1.Viewmodel
{
    public class ProductCarts
    {
        public List<product> products { get; set; }
        public List<Cart> Carts { get; set; }

    }
}