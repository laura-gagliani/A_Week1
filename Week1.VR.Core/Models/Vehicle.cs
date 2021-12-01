using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.VR.Core.Models
{
    public class Vehicle
    {
        public string Plate { get; set; }
        public string Model { get; set; }
        public decimal DailyRate { get; set; }


        //public List<Rental> VehicleRentals { get; set; } = new List<Rental>();


        //per gestire l'ereditarietà si poteva anche mettere una proprietà "tipo" che distingue tra car e van con un enum
        // a imitazione della struttura db. se faccio così (tabella unica) i campi specifici di car/van saranno nullable (non obbligatori) (e dovrebbero essere nullabili anche qui in teoria)

        public override string ToString()
        {
            return $"Targa: {Plate} - Modello: {Model} - Tariffa giornaliera: {DailyRate} euro"  ;
        }
    }
}
