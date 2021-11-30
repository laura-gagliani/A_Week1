using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Agenzia.Core.Entities
{
    internal class Immobile
    {
        public int Id { get; set; }
        public string Indirizzo { get; set; }
        public int CAP { get; set; }
        public string Citta { get; set; }
        public int SuperficieMQ { get; set; }
        public bool Disponibilita { get; set; } = true;
        //public TipologiaEnum Tipologia { get; set; }




        public override string ToString()
        {
            string disp;
            if (Disponibilita)
                disp = "Si";
            else
                disp = "No";
            return $"ID: {Id} - Indirizzo: {Indirizzo}, {CAP}, {Citta} - Metri quadri: {SuperficieMQ} - Disponibile: {disp}";
        }

    }

    public enum TipologiaEnum  //lo mettiamo PARALLELO alla classe (stesso namespace) in modo che ci si possa accedere senza bisogno di farlo tramite la classe
    {
        Box = 1,
        Appartamento,
        Villa
    }
}
