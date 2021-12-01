using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Models;

namespace Week1.VR.Core.Interfaces
{
    public interface IRentalsRepository : IRepository<Rental>
    {
        Rental GetById(int id);

        List<Rental> GetByUser(string userId);

        List<Rental> GetByVehicle(string vehicleId);

        List<Rental> GetRentalsInProgress();

    }
}
