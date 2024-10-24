using System;

namespace CarRentalSystem.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}