using System;
using System.Collections.Generic;
using System.Web;

namespace YourNamespace
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Retrieve the list of products from the application variable
            List<Product> productList = (List<Product>)Application["ProductList"];

            // Bind the list of products to the Repeater control
            productRepeater.DataSource = productList;
            productRepeater.DataBind();
        }
    }
}
