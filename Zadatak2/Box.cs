using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Box : IAbstractCollection
    {
        private List<Product> Products;
        public Box()
        {
            this.Products = new List<Product>();
        }
        public Box(List<Product> Products)
        {
            this.Products = new List<Product>(Products.ToArray());
        }
        public void AddProduct(Product Product)
        {
            this.Products.Add(Product);
        }
        public void RemoveProduct(Product Product)
        {
            this.Products.Remove(Product);
        }
        public void Clear()
        {
            this.Products.Clear();
        }
        public int Count { get { return this.Products.Count; } }
        public Product this[int index] { get { return this.Products[index]; } }
        public IAbstractIterator GetIterator() { return new BoxIterator(this); }
    }
}

