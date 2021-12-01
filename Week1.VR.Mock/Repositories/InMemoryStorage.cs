using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Models;

namespace Week1.VR.Mock.Repositories
{
    internal class InMemoryStorage
    {
        //Inizializzare una lista di clienti, di veicoli disponibili e
        //di noleggi già esistenti (alcuni attivi e alcuni terminati)


        //Noleggi
        //ID; Targa; CodiceFiscale; DataInizio; NumeroGiorni; Costo
        //1; AX743HJ; NREFBA76A01L219J; 29 / 11 / 2021; 5; 275
        //2; GJ924LR; NREFBA76A01L219J; 3 / 12 / 2021; 2; 120
        //3; UY248QW; NREFBA76A01L219J; 7 / 6 / 2020; 1; 65
        //4; AX743HJ; RSSMRA80A01L219M; 10 / 10 / 2021; 1; 70
        //5; TY467WE; RSSMRA80A01L219M; 29 / 11 / 2021; 5; 625
        //6; GH567KU; RSSMRA80A01L219M; 19 / 4 / 2020; 3; 600

        public static List<Rental> Rentals = new()
        {
            new Rental() { RentalId = 1, VehiclePlate = "AX743HJ", CustomerFC = "NREFBA76A01L219J", StartingDate = new DateTime(2021, 11, 29), Duration = 5, TotalCost = 275}, 
            new Rental() { RentalId = 2, VehiclePlate = "GJ924LR", CustomerFC = "NREFBA76A01L219J", StartingDate = new DateTime(2021, 12, 3), Duration = 2, TotalCost = 120}, 
            new Rental() { RentalId = 3, VehiclePlate = "UY248QW", CustomerFC = "NREFBA76A01L219J", StartingDate = new DateTime(2020, 6, 7), Duration = 1, TotalCost = 65}, 
            new Rental() { RentalId = 4, VehiclePlate = "AX743HJ", CustomerFC = "RSSMRA80A01L219M", StartingDate = new DateTime(2021, 10, 20), Duration = 1, TotalCost = 70}, 
            new Rental() { RentalId = 5, VehiclePlate = "TY467WE", CustomerFC = "RSSMRA80A01L219M", StartingDate = new DateTime(2021, 11, 29), Duration = 5, TotalCost = 625}, 
            new Rental() { RentalId = 6, VehiclePlate = "GH567KU", CustomerFC = "RSSMRA80A01L219M", StartingDate = new DateTime(2020, 4, 19), Duration = 3, TotalCost = 600}, 
        };

        //Clienti
        //CodiceFiscale; Nome; Cognome
        //RSSMRA76A01L219J; Mario; Rossi
        //RSSMRC80A01L219M; Marco; Rossi

        public static List<Customer> Customers = new()
        {
            new Customer() { FiscalCode = "RSSMRA76A01L219J", Name = "Mario", Surname = "Rossi"},
            new Customer() { FiscalCode = "RSSMRC80A01L219M", Name = "Marco", Surname = "Rossi"},
        };

        //Veicoli
        //Targa; Modello; Tariffa; Posti / Capacità
        //AX743HJ; Fiat Panda; 55; 4 (automobile)
        //GJ924LR; Fiat Punto; 60; 5 (automobile)
        //UY248QW; Fiat Tipo; 65; 5 (automobile)
        //GK823NB; Smart fortwo coupè; 70; 2 (automobile)
        //TY467WE; Fiat Ducato; 125; 750 (furgone)
        //GH567KU; Fiat Fiorino; 100; 450 (furgone)

         public static List<Vehicle> Vehicles = new()
        {
            new Car() { Plate = "AX743HJ", Model = "Fiat Panda", DailyRate = 55, Seats = 4 },
            new Car() { Plate = "GJ924LR", Model = "Fiat Punto", DailyRate = 60, Seats = 5 },
            new Car() { Plate = "UY248QW", Model = "Fiat Tipo", DailyRate = 65, Seats = 5 },
            new Car() { Plate = "GK823NB", Model = "Smart fortwo coupè", DailyRate = 70, Seats = 2 },
            new Van() { Plate = "TY467WE", Model = "Fiat Ducato", DailyRate = 125, LoadCapacity = 750 },
            new Van() { Plate = "GH567KU", Model = "Fiat Fiorino", DailyRate = 100, LoadCapacity = 450 }

        };
    }
}
