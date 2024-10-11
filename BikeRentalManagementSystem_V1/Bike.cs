using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Bike
    {
        private string bikeId { get; set; }
        private string brand { get; set; }
        private string model { get; set; }
        private decimal RentalPrice { get; set; }

        public Bike(string bikeId, string brand, string model, decimal rentalPrice)
        {
            this.bikeId = bikeId;
            this.brand = brand;
            this.model = model;
            RentalPrice = rentalPrice;
        }
        public override string ToString()
        {
            return $"bikeid:{bikeId},brand:{brand},model:{model},rentalprice:{RentalPrice}";
        }
    }
}
