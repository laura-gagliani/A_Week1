using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Models;

namespace Week1.VR.Core.Interfaces
{
    public interface ICustomersRepository : IRepository<Customer>
    {
        Customer GetById(string id);

    }
}
