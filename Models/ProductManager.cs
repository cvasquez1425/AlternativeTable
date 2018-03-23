using System;
using System.Collections.Generic;

namespace AlternativeTable.Models
{
    public class ProductManager
    {
        public List<Product> Get()
        {
            return CreateMockData();
        }

        protected List<Product> CreateMockData()
        {
            List<Product> ret = new List<Product>();

            ret.Add(new Product()
            {
                ProductId = 1,
                ProductName = "Add Angular to MVC Applications",
                IntroductionDate = Convert.ToDateTime("03/22/2018"),
                Url = "http://bit.ly/2u1ofRk",
                Price = Convert.ToDecimal(29.00)
            });

            // MORE PRODUCTS CREATED HERE.
            ret.Add(new Product()
            {
                ProductId = 2,
                ProductName = "Basics of Unit Testing for C# Developers",
                IntroductionDate = Convert.ToDateTime("01/23/2017"),
                Url = "http://bit.ly/2u1ofRk",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new Product()
            {
                ProductId = 3,
                ProductName = "Extending Bootstrap with CSS, JavaScript and JQuery",
                IntroductionDate = Convert.ToDateTime("06/11/2015"),
                Url = "http://bit.ly/2u1ofRk",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new Product()
            {
                ProductId = 4,
                ProductName = "Build your own Bootstrap Business Application Template in MVC",
                IntroductionDate = Convert.ToDateTime("01/29/2015"),
                Url = "http://bit.ly/2u1ofRk",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new Product()
            {
                ProductId = 5,
                ProductName = "Building Mobile Sites Using Web Forms, Bootstrap, and HTML5",
                IntroductionDate = Convert.ToDateTime("08/28/2014"),
                Url = "http://bit.ly/2u1ofRk",
                Price = Convert.ToDecimal(29.00)
            });
            return ret;
        }
    }
}
