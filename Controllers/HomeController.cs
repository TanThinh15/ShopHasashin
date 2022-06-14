
using Microsoft.AspNetCore.Mvc;
using HasashinShop.Models;
using System.Linq;
using HasashinShop.Models.ViewModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HasashinShop.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 3;
        private IHasashinShopRepository repository;
        public HomeController(IHasashinShopRepository repo)
        {
            repository = repo;
        }
        public IActionResult SanPham(string cosmetics ,int ProductPage = 1)
         => View(new ProductsListViewModel
         {
             Products = repository.Products
             .Where(p => cosmetics == null || p.LoaiSP == cosmetics)
             .OrderBy(b => b.ProductID)
             .Skip((ProductPage - 1) * PageSize)
             .Take(PageSize),
              PagingInfo = new PagingInfo
              {
                  CurrentPage = ProductPage,
                  ItemsPerPage = PageSize,
                  TotalItems = cosmetics == null ?
                  repository.Products.Count() :
                  repository.Products.Where(e => e.LoaiSP == cosmetics).Count()
              },
              CurrentGenre = cosmetics
         });
        public async Task<IActionResult> Index()
        {
            var Products = from p in repository.Products
                       select p;

            return View(await Products.ToListAsync());
        }

    }
}
