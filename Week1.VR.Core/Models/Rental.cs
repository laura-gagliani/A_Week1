using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.VR.Core.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime StartingDate { get; set; }
        public int Duration { get; set; }
        public decimal TotalCost { get; set; }


        public string CustomerFC { get; set; }
        public string VehiclePlate { get; set; }



    }
}
