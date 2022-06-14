using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasashinShop.Models
{
    public class MyCart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = Lines
            .Where(b => b.Product.ProductID == product.ProductID)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Product Product) =>
        Lines.RemoveAll(l => l.Product.ProductID == Product.ProductID);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.Product.Gia * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
