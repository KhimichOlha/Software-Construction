using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Product
    {
        private string _name;
        private Money _price;
        private string _unitOfMeasurement;
        public Product (string name, Money price)
        {
            _name = name;
            _price = price;
        }
        public string Name { get { return _name; } }
        public Money Price { get { return _price; } }
        public string UnitOfMeasurement {  get { return _unitOfMeasurement; } }
        public void ReducePrice(Money money) 
        {
            _price = _price - money;
           
        }
        
    }
   
}
