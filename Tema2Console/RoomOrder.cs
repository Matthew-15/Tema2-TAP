using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    internal class RoomOrder : IOrder
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ReservationDate { get; set; }

        public decimal CalculateFinalPrice()
        {
            decimal finalPrice = Quantity * Price;

            if (!DateTime.TryParseExact(ReservationDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var parsedReservationDate))
            {
                UserInterface.DisplayMessage("-Reservation Date must be a valid date");
                return 0;
            }

            if (parsedReservationDate < DateTime.Now.AddMonths(1))
            {
                finalPrice *= 0.9m;
            }
            else if (parsedReservationDate < DateTime.Now.AddMonths(2))
            {
                finalPrice *= 0.8m;
            }

            return finalPrice;
        }
    }
}
