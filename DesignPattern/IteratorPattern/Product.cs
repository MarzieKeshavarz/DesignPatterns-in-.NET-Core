using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.IteratorPattern
{
    public class Product
    {
        private int id;
        private string name;

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


        public string toString()
        {
            return "Product{" +
                    "id=" + id +
                    ", name='" + name + '\'' +
                    '}';
        }
    }
}
