namespace Tema2Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");

            var hotelReception = new HotelReception();
            hotelReception.ProcessOrder();

            if (hotelReception.FinalPrice == 0)
            {
                UserInterface.DisplayMessage("No order was processed.");
            }
            else
            {
                UserInterface.DisplayMessage($"Final price for your order: {hotelReception.FinalPrice} RON");
            }
        }
    }
}
