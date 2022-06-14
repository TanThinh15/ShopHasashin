using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HasashinShop.MyTagHelper;
using HasashinShop.Models;
using System.Linq;
namespace HasashinShop.Pages
{
    public class MyCartModel : PageModel
    {
        private IHasashinShopRepository repository;
        public MyCartModel(IHasashinShopRepository repo, MyCart myCartService)
        {
            repository = repo;
            myCart = myCartService;
        }
        public MyCart myCart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long productID, string returnUrl)
        {
            Product product = repository.Products
            .FirstOrDefault(b => b.ProductID == productID);
            myCart.AddItem(product, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long productID, string returnUrl)
        {
            myCart.RemoveLine(myCart.Lines.First(cl =>
            cl.Product.ProductID == productID).Product);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}