using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    internal class BreakfastOrder : IOrder
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ServingDate { get; set; }

        public decimal CalculateFinalPrice()
        {
            decimal finalPrice = Quantity * Price;

            if (!DateTime.TryParseExact(ServingDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var parsedServingDate))
            {
                UserInterface.DisplayMessage("-Serving Date must be a valid date");
                return 0;
            }

            if (parsedServingDate < DateTime.Now.AddDays(7))
            {
                finalPrice = Quantity * Price;
            }
            else
            {
                finalPrice *= 0.5m;
            }

            return finalPrice;
        }
    }
}
