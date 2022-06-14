using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HasashinShop.Models
{
    public interface IHasashinShopRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product b);
        void CreateProduct(Product b);
        void DeleteProduct(Product b);
    }
}
