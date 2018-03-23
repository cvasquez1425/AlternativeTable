using AlternativeTable.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlternativeTable.Controllers
{
    public class ProductController : AppBaseController
    {
        public ActionResult Index()
        {
            // create an instance of the ProductViewModel and calls the LoadProducts method to build the Products property in the view model.
            ProductViewModel vm = new ProductViewModel();

            vm.IsMobileDevice = IsMobileDevice();
            vm.LoadProducts();

            return View(vm);
        }
    }
}