using System;

namespace CarRentalSystem.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyPrice { get; set; }
        public string PlateNumber { get; set; }
    }
}