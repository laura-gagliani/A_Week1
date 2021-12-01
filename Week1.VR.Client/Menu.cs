using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.BusinessLayer;
using Week1.VR.Core.Interfaces;
using Week1.VR.Mock.Repositories;

namespace Week1.VR.Client
{
    internal class Menu
    {
        private static IBusinessLayer bl = new VRBusinessLayer(new MockCustomersRepository(), new MockVehiclesRepository(), new MockRentalsRepository());


    }
}
