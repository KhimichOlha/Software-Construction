using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Warehouse
    {

        private readonly List<Product> _products;

       
        public Warehouse()
        {
            _products = new List<Product>();

        }
        public List<Product> Products { get; set; }

    }
}
