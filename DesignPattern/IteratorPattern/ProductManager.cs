using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.IteratorPattern
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public Iterator<Product> CreateIterator()
        {
            return new ProductsList(this);
        }

        public Product Pop()
        {
            var last = products[products.Count - 1];
            products.Remove(last);
            return last;
        }

        public void Push(Product product)
        {
            products.Add(product);
        }
        public class ProductsList : Iterator<Product>
        {
            private ProductManager _productManager;
            private int index=0;

            public ProductsList(ProductManager productManager)
            {
                _productManager = productManager;

            }
            public Product Current()
            {
                return _productManager.products[index];
            }

            public void GetNext()
            {
                index++;
            }

            public bool HasNext()
            {
                return index < _productManager.products.Count ;
            }
        }
    }


}
