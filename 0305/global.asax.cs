using System;
using System.Collections.Generic;
using System.Web;

namespace YourNamespace
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Create a list of products
            List<Product> productList = new List<Product>();
            productList.Add(new Product { Id = 1, Name = "Product A", Price = 10.00 });
            productList.Add(new Product { Id = 2, Name = "Product B", Price = 20.00 });
            productList.Add(new Product { Id = 3, Name = "Product C", Price = 30.00 });

            // Store the list of products in an application variable
            Application["ProductList"] = productList;
        }
    }
}
