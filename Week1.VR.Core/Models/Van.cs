using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.VR.Core.Models
{
    public class Van : Vehicle
    {
        public int LoadCapacity { get; set; }

        public override string ToString()
        {
            return base.ToString()+ $" - Carico: {LoadCapacity} kg";
        }
    }
}
