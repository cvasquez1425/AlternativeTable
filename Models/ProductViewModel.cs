using System.Collections.Generic;

namespace AlternativeTable.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public bool IsMobileDevice { get; set; }

        public void LoadProducts()
        {
            ProductManager mgr = new ProductManager();

            Products = mgr.Get();
        }
    }
}
