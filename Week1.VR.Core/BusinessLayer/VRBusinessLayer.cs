using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Interfaces;

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
    }
}
