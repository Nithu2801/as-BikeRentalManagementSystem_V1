using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Bike
    {
        private string BikeId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }

        public Bike(string bikeId, string brand, string model, decimal rentalPrice)
        {
            this.BikeId = bikeId;
            this.Brand = brand;
            this.Model = model;
           this.RentalPrice = rentalPrice;
        }
        public override string ToString()
        {
            return $"bikeid:{BikeId},brand:{Brand},model:{Model},rentalprice:{RentalPrice}";
        }
        
    }
}
