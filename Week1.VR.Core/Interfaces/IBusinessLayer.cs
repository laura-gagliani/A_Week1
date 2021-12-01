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
        Vehicle GEtVehicleById(string vehiclePlate);
        List<Rental> GetRentalsByPlate(string plate);
        List<Vehicle> GetAllVehicles();
        Rental GetRentalById(int id);
        List<Rental> GetRentalsInProgress();
        List<Vehicle> GetAvailableVehicles();
    }
}
