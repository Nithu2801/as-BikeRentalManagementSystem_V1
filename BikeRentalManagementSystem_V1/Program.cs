using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeManager manager = new BikeManager();
            int option = 0;
            while (option != 5)
            {
                Console.WriteLine("Bike Rental Mnagement System");
                Console.WriteLine("1. Add a Bike");
                Console.WriteLine("2. View All Bikes");
                Console.WriteLine("3. Update a Bike");
                Console.WriteLine("4. Delete a Bike");
                Console.WriteLine("5. Exit");
            }
            option = int.Parse(Console.ReadLine());

            switch (option) {
                case 1: 
                    {
                        Console.WriteLine("Enter Bike Id");
                        string bikeid = (Console.ReadLine());
                        Console.WriteLine("Enter Bike Brand");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Enter Bike Model");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter Bike rental Price");
                        decimal rentalprice = decimal.Parse(Console.ReadLine());
                        manager.AddBikes(new Bike(bikeid, brand, model, rentalprice));
                    }
                    break;
                case 2:
                    {
                        manager.ViewBikes();

                    }
                    break ;
                case 3:
                    {
                        Console.WriteLine("Enter Bike Id");
                        string bikeid = (Console.ReadLine());
                        Console.WriteLine("Enter Bike Brand");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Enter Bike Model");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter Bike rental Price");
                        decimal rentalprice = decimal.Parse(Console.ReadLine());
                        manager.UpdateBikes(bikeid, brand, model, rentalprice);
                    }
                    break ;
                    case 4: {
                        Console.WriteLine("Enter the Bike ID");
                        string bikeid = (Console.ReadLine());
                        manager.DeleteBikes(bikeid);

                    }
                    break ;
                    case 5:
                    {
                        Console.WriteLine("Exit");
                        
                    }
                    break ;
                    default:
                    Console.WriteLine("Error");
                    break ;
                        






            } }
    }
}
