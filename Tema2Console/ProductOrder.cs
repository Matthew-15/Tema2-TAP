using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    internal class ProductOrder:IOrder
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateFinalPrice()
        {
            decimal finalPrice = Quantity * Price;

            if (Name == "Cola")
            {
                finalPrice *= 0.75m;
            }

            return finalPrice;
        }
    }
}
