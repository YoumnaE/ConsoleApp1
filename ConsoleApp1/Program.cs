namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part Two
            #region Q1

            DeliveryAddress address1 = new DeliveryAddress("Alex", "Smouha", 20);
            DeliveryAddress address2 = address1;

            address2.Street = "Sidi Gaber";
            address2.BuildingNumber = 1;

            Console.WriteLine(address1.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());

            #endregion
            #endregion




            Console.ReadLine();
        }
    }
}
