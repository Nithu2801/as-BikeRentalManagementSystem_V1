using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class BikeManager
    {
        private List<Bike> bikes = new List<Bike>();
        public void AddBikes(Bike bike)
        {

            bikes.Add(bike);
            Console.WriteLine("Bike Added Succesfully");
        }
        public void ViewBikes()
        {
            if (bikes.Count == 0)
            {
                Console.WriteLine("No Available");
            }
            else
            {
                foreach (var bike in bikes)
                {
                    Console.WriteLine(bike);
                }


            }
        }
        public void UpdateBikes(string bikeId, string newbrand, string newmodel, decimal newrentalprice)
        {
            var bike = bikes.FirstOrDefault(b => b.BikeId == bikeId);
            {
                if (bike != null)
                {
                    bike.BikeId = bikeId;
                    bike.Brand = newbrand;
                    bike.Model = newmodel;
                    bike.RentalPrice = newrentalprice;
                    Console.WriteLine("updated succesfully");


                }
                else
                {
                    Console.WriteLine("not available");
                }
            }
        }
        public void DeleteBikes(string bikeId)
        {
            var bike = bikes.FirstOrDefault(b => b.BikeId == bikeId);
            if (bike != null)
            {
                bikes.Remove(bike);
                Console.WriteLine("Removede Succesfully");
            }
            else
            {
                Console.WriteLine("Not Available");
            }


        }     
    public void ValidteBikeRental}
}


