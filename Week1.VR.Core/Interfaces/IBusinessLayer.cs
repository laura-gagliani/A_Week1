using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Models;

namespace Week1.VR.Core.Interfaces
{
    public interface IBusinessLayer
    {
        List<Rental> GetAllRentals();
        Customer GetCustomerById(string customerFC);
        Vehicle GetVehicleById(string vehiclePlate);
        List<Rental> GetRentalsByPlate(string plate);
        List<Vehicle> GetAllVehicles();
        Rental GetRentalById(int id);
        List<Rental> GetRentalsInProgress();
        List<Vehicle> GetAvailableVehicles();
        List<Customer> GetAllCustomers();
        void AddNewRental(Rental nuovoNoleggio);
        decimal CalculateTotalCarsAmount();
        decimal CalculateAmountPerPlate(string plate);
        void AddNewCustomer(Customer newCustomer);
    }
}
