using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Interfaces;
using Week1.VR.Core.Models;

namespace Week1.VR.Core.BusinessLayer
{
    public class VRBusinessLayer :IBusinessLayer
    {
        private readonly ICustomersRepository _customersRepository;
        private readonly IVehiclesRepository _vehiclesRepository;
        private readonly IRentalsRepository _rentalsRepository;



        public VRBusinessLayer(ICustomersRepository customersRepo, IVehiclesRepository vehiclesRepo, IRentalsRepository rentalsRepo)
        {
            _customersRepository = customersRepo;
            _vehiclesRepository = vehiclesRepo;
            _rentalsRepository = rentalsRepo;
        }

        public List<Rental> GetAllRentals()
        {
            return _rentalsRepository.GetAll();
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _vehiclesRepository.GetAll();
        }

        public List<Vehicle> GetAvailableVehicles()
        {
            return _vehiclesRepository.GetAvailableVehicles();
        }

        public Customer GetCustomerById(string customerFC)
        {
            return _customersRepository.GetById(customerFC);
            
        }

        public Rental GetRentalById(int id)
        {
            return _rentalsRepository.GetById(id);
        }

        public List<Rental> GetRentalsByPlate(string plate)
        {
            return _rentalsRepository.GetByVehicle(plate);
        }

        public List<Rental> GetRentalsInProgress()
        {
            return _rentalsRepository.GetRentalsInProgress();
        }

        public Vehicle GEtVehicleById(string vehiclePlate)
        {
            return _vehiclesRepository.GetById(vehiclePlate);
        }
    }
}
