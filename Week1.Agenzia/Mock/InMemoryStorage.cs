using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Agenzia.Core.Entities;

namespace Week1.Agenzia.Mock
{
    internal class InMemoryStorage
    {
        public static List<Immobile> Immobili = new()
        {
            new Box()           { Id = 1, Indirizzo = "Via Roma 11", CAP = 50120, Citta = "Firenze", SuperficieMQ = 20, Disponibilita = true, PostiAuto = 2 },
            new Appartamento()  { Id = 2, Indirizzo = "Viale Guidoni 51", CAP = 50120, Citta = "Firenze", SuperficieMQ = 72, Disponibilita = true, Vani = 3, Bagni = 2 },
            new Villa()         { Id = 3, Indirizzo = "Piazza Vittoria 8", CAP = 50120, Citta = "Firenze", SuperficieMQ = 180, Disponibilita = true, Vani = 7, Bagni = 3, MqGiardino = 120 },
            new Appartamento()  { Id = 4, Indirizzo = "Via delle Gore 15", CAP = 50120,  Citta = "Firenze", SuperficieMQ = 56, Disponibilita = false , Vani = 2, Bagni = 1},
            new Box()           { Id = 5, Indirizzo = "Via delle Gore 17", CAP = 50120,  Citta = "Firenze", SuperficieMQ = 16, Disponibilita = false, PostiAuto =1 },
        };
    }
}
