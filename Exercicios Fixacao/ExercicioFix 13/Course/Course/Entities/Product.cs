using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double UnityPrice { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double unityPrice, int quantity)
        {
            Name = name;
            UnityPrice = unityPrice;
            Quantity = quantity;
        }

        public double Total()
        {
            return UnityPrice * Quantity;
        }
    }
}
