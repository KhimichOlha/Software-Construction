using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Warehouse
    {
        private List<Product> _products;

        public Warehouse(List<Product> products)
        {
            _products = products;

        }
        public List<Product> Products { get; set; }

    }
}
