using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasashinShop.Models
{
    public class EFHasashinShopRepository : IHasashinShopRepository
    {
        private HasashinShopDbContext context;
        public EFHasashinShopRepository(HasashinShopDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public void CreateProduct(Product b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteProduct(Product b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveProduct(Product b)
        {
            context.SaveChanges();
        }
    }

}
