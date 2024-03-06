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
        private DateOnly _lastdate;

        public Warehouse(List<Product> products,DateOnly lastdate)
        {
            _products = products;
            _lastdate = lastdate;
        }

    }
}
