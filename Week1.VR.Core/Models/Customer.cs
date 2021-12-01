using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.VR.Core.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FiscalCode { get; set; }


        //public List<Rental> CustomerRentals { get; set; } = new List<Rental>();

        public override string ToString()
        {
            return $"Nome: {Name} {Surname} - Codice fiscale: {FiscalCode}";
        }
    }
}
