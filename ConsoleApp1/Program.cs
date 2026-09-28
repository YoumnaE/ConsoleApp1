using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part One

            //Q1: the copy has its own address so modifications doesnt reach the original deliveryAddress

            #region Q2
            // a) 1.all fields are public anyone can directly change them.
            //    2. no validation
            //    3. cannot add rules when values change

            // b) private field + public property = values can be reached but invalid are rejected
            #endregion

            #endregion

            #region Part Two
            #region Q1

            DeliveryAddress address1 = new DeliveryAddress("Alex", "Smouha", 20);
            DeliveryAddress address2 = address1;

            address2.Street = "Sidi Gaber";
            address2.BuildingNumber = 1;
            //Because DeliveryAddress is a struct, address2 gets its own copy
            Console.WriteLine(address1.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());

            


            DeliveryCenter deliveryCenter = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"***Enter Shipment {i + 1}***");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                double deliveryFee = double.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(city,street,buildingNumber);

                Shipment shipment = new Shipment(trackingCode,description,weight,deliveryFee,address);

                deliveryCenter.AddShipment(shipment);

            #endregion




                
            }

            //print all 3 shipments
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nShipment {i + 1}:");
                deliveryCenter[i].PrintShipment();
            }


            //search using string indexer
            Console.Write("\nEnter tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = deliveryCenter[searchCode];

            // Check if shipment was found
            if (!string.IsNullOrEmpty(foundShipment.TrackingCode))
            {
                Console.WriteLine("\nShipment found:");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.ReadLine();
            #endregion
        }
    }
}
