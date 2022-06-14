using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HasashinShop.Models;
namespace HasashinShop.ViewComponents
{
    public class CosmeticsNavigation : ViewComponent
    {
        private IHasashinShopRepository repository;
        public CosmeticsNavigation(IHasashinShopRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCosmetics = RouteData?.Values["LoaiSP"];
            return View(repository.Products
            .Select(x => x.LoaiSP)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
