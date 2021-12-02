using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.BusinessLayer;
using Week1.VR.Core.Interfaces;
using Week1.VR.Core.Models;
using Week1.VR.Mock.Repositories;

namespace Week1.VR.Client
{
    internal class Menu
    {
        private static readonly IBusinessLayer bl = new VRBusinessLayer(new MockCustomersRepository(), new MockVehiclesRepository(), new MockRentalsRepository());

        internal static void Start()
        {
            //All'accesso, l'utente può:
            //1 Visualizzare tutti i noleggi, con i dati del veicolo e del cliente ( -> andando a ripescare le relative entità)
            //2 Visualizzare i noleggi di un certo veicolo (input: targa)
            //3 Visualizzare i dettagli di un certo noleggio (input: id)
            //4 Visualizzare i noleggi attivi
            //5 Inserire un nuovo noleggio verificando che il veicolo non sia impegnato. (contemplare il caso che il cliente sia nuovo...)
            //Il costo del noleggio si calcola moltiplicando la tariffa per il numero
            //di giorni.
            //6 Data una targa, calcolare il totale in euro dei noleggi
            //7 Ricavare il totale in euro dei noleggi di automobili

            bool quit = false;
            Console.WriteLine("Benvenuto!");

            do
            {
                Console.WriteLine("\n[1] Visualizza tutti i noleggi");
                Console.WriteLine("[2] Visualizza noleggi per veicolo");
                Console.WriteLine("[3] Visualizza dettagli noleggio");
                Console.WriteLine("[4] Visualizza noleggi attivi");
                Console.WriteLine("[5] Inserisci nuovo noleggio");
                Console.WriteLine("[6] Visualizza ammontare noleggi per targa");
                Console.WriteLine("[7] Visualizza ammontare noleggi per tutte le automobili");
                Console.WriteLine("[8] Aggiungi nuovo veicolo");
                Console.WriteLine("[Q] Esci");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        VisualizzaNoleggi();
                        break;
                    case '2':
                        VisualizzaNoleggiPerVeicolo();
                        break;
                    case '3':
                        VisualizzaDettagliNoleggio();
                        break;
                    case '4':
                        VisualizzaNoleggiAttivi();
                        break;
                    case '5':
                        InserisciNuovoNoleggio(); //TODO: correggi la questione del periodo di disponibilità
                        break;
                    case '6':
                        VisualizzaAmmontarePerTarga();
                        break;
                    case '7':
                        VisualizzaAmmontareAutomobili();
                        break;
                    case '8':
                        InserisciNuovoVeicolo();
                        break;
                    case 'Q':
                        quit = true;
                        Console.WriteLine("\nChiusura in corso...");
                        break;
                    default:
                        Console.WriteLine("\nScelta errata dal menu!");
                        break;
                }

            } while (!quit);
        }

        private static void InserisciNuovoVeicolo()
        {
            //Console.WriteLine("Premi 1 per inserire un'auto, premi 2 per inserire un furgoncino");
            //int choice;
            //do
            //{
            //    choice = GetInt();
            //} while (choice != 1 && choice != 2);

            //Console.Write("\nTarga:");
            //string targa = Console.ReadLine();
            //Console.Write("Modello:");
            //string modello = Console.ReadLine();
            //Console.Write("\nCosto giornaliero:");
            //decimal costoGiornaliero = decimal.Parse(Console.ReadLine()); //TODO tryparse

            //if (choice == 1)
            //{
            //    Console.Write("\nPosti:");
            //    int posti = GetInt();
            //}
            //else
            //{

            //}
        }

        private static void VisualizzaAmmontarePerTarga()
        {
            List<Vehicle> vehicles = bl.GetAllVehicles();
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Plate);
            }

            Console.WriteLine("\nInserisci la targa da selezionare:");
            string targa = Console.ReadLine();
            Vehicle foundVehicle = bl.GetVehicleById(targa);
            if (foundVehicle == null)
            {
                Console.WriteLine("\nInserimento scorretto");
            }
            else
            {                
                decimal ammontarePerTarga = bl.CalculateAmountPerPlate(foundVehicle.Plate);
                Console.WriteLine($"Il totale per la targa {foundVehicle.Plate} è di {ammontarePerTarga}");
            }
        }

        private static void VisualizzaAmmontareAutomobili()
        {
            decimal ammontareAutomobili = bl.CalculateAmountForAllCars();                

            Console.WriteLine($"L'ammontare totale per tutti i noleggi delle automobili in elenco è di {ammontareAutomobili} euro");
        }

        private static void InserisciNuovoNoleggio()
        {
            Console.WriteLine("\n--- Noleggio Veicolo ---");
            Console.WriteLine("\nI veicoli disponibili sono:");

            List<Vehicle> veicoliDisponibili = bl.GetAvailableVehicles();
            foreach (var item in veicoliDisponibili)
            {
                Console.WriteLine(item);
            }

            bool targaCorretta = false;
            string targaNoleggiata;
            do
            {
                Console.WriteLine("\nInserisci la targa del veicolo selezionato:");
                targaNoleggiata = Console.ReadLine();
                foreach (var item in veicoliDisponibili)
                {
                    if (item.Plate == targaNoleggiata)
                    {
                        targaCorretta = true;
                    }
                }
            } while (!targaCorretta);
            Console.WriteLine("\nVeicolo correttamente selezionato");

            Console.WriteLine("\nI clienti già in elenco sono:");
            List<Customer> customers = bl.GetAllCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            string codiceFiscale;
            Console.WriteLine("\nPremi 1 per selezionare uno dei clienti già in elenco, premi 2 per inserire un nuovo cliente");
                        int choice;
            do
            {
                choice = GetInt();
            }while(!(choice == 1 || choice == 2));
            
            if (choice == 1)
            {
                bool clienteCorretto = false;
                do
                {
                    Console.WriteLine("\nInserisci il codice fiscale del cliente:");
                    codiceFiscale = Console.ReadLine();
                    foreach (var item in customers)
                    {
                        if (item.FiscalCode == codiceFiscale)
                        {
                            clienteCorretto = true;
                        }
                    }
                } while (!clienteCorretto);
                Console.WriteLine("\nCliente correttamente selezionato");
            }
            else
            {
                Customer newCustomer = new Customer();
                Console.WriteLine("\nInserisci nome:");
                newCustomer.Name = Console.ReadLine();
                Console.WriteLine("Inserisci cognome:");
                newCustomer.Surname = Console.ReadLine();
                Console.WriteLine("Inserisci codice fiscale:");
                newCustomer.FiscalCode = Console.ReadLine();
                bl.AddNewCustomer(newCustomer);
                codiceFiscale = newCustomer.FiscalCode;
            }
            

            Rental nuovoNoleggio = InserimentoDatiNoleggio(codiceFiscale, targaNoleggiata);
            bl.AddNewRental(nuovoNoleggio);
        }

        private static Rental InserimentoDatiNoleggio(string? codiceFiscale, string targaNoleggiata)
        {
            Rental r = new Rental();
            r.VehiclePlate = targaNoleggiata;
            r.CustomerFC = codiceFiscale;
            Console.WriteLine("\nInserisci data di inizio noleggio:");
            r.StartingDate = DateTime.Parse(Console.ReadLine()); //TODO tryparse
            Console.WriteLine("\nInserisci durata (giorni) del noleggio:");
            r.Duration = GetInt();
            Vehicle v = bl.GetVehicleById(targaNoleggiata);
            r.TotalCost = v.DailyRate * r.Duration;
            //ha tutto tranne l'id
            return r;

        }

        private static void VisualizzaNoleggiAttivi()
        {
            List<Rental> noleggiAttivi = bl.GetRentalsInProgress();

            if (noleggiAttivi.Count != 0)
            {
                Console.WriteLine();
                foreach (var item in noleggiAttivi)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("\nNessun noleggio ancora in corso!");
            }



        }

        private static void VisualizzaDettagliNoleggio()
        {
            Console.WriteLine("\nInserisci Id del noleggio cercato:");
            int id = GetInt();
            Rental noleggio = bl.GetRentalById(id);

            if (noleggio == null)
            {
                Console.WriteLine("\nNessun noleggio registrato con questo id!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(noleggio);
                Customer c = bl.GetCustomerById(noleggio.CustomerFC);
                Vehicle v = bl.GetVehicleById(noleggio.VehiclePlate);

                if (c != null)
                {
                    Console.WriteLine("Dati cliente: " + c);
                }
                else Console.WriteLine($"Noleggio registrato con codice utente {noleggio.CustomerFC} - Nessun utente in elenco con questo codice");

                if (v != null)
                {
                    Console.WriteLine("Veicolo noleggiato: " + v);
                }
                else Console.WriteLine($"Noleggio registrato con targa {noleggio.VehiclePlate} - Nessun veicolo in elenco con questa targa");

            }
        }

        private static int GetInt()
        {
            int num;
            bool parse;

            do
            {
                parse = int.TryParse(Console.ReadLine(), out num);
            } while (!parse);
            return num;
        }

        private static void VisualizzaNoleggiPerVeicolo()
        {
            Console.WriteLine("\nLe targhe in elenco sono:");
            List<Vehicle> targhe = bl.GetAllVehicles();
            foreach (Vehicle vehicle in targhe)
            {
                Console.WriteLine(vehicle.Plate);
            }
            Console.WriteLine("\nDigita la targa del veicolo di cui vuoi visualizzare i noleggi:");
            string targa = Console.ReadLine();

            Vehicle v = bl.GetVehicleById(targa);
            if (v == null)
                Console.WriteLine("\nErrore! Nessun veicolo in elenco con questa targa");

            else
            {
                List<Rental> noleggiVeicolo = bl.GetRentalsByPlate(v.Plate);
                if (noleggiVeicolo.Count != 0)
                {
                    Console.WriteLine();
                    foreach (var item in noleggiVeicolo)
                    {
                        Customer c = bl.GetCustomerById(item.CustomerFC);
                        Console.WriteLine(item);

                        if (c != null)
                        {
                            Console.WriteLine("Dati cliente: " + c);
                        }
                        else Console.WriteLine($"Noleggio registrato con codice utente {item.CustomerFC} - Nessun utente in elenco con questo codice");

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("\nQuesto veicolo non è mai stato noleggiato");
                }

            }
        }

        private static void VisualizzaNoleggi()
        {
            List<Rental> noleggi = bl.GetAllRentals();
            foreach (var item in noleggi)
            {
                Customer c = bl.GetCustomerById(item.CustomerFC);
                Vehicle v = bl.GetVehicleById(item.VehiclePlate);

                Console.WriteLine(item);

                if (c != null)
                {
                    Console.WriteLine("Dati cliente: " + c);
                }
                else Console.WriteLine($"Noleggio registrato con codice utente {item.CustomerFC} - Nessun utente in elenco con questo codice");

                if (v != null)
                {
                    Console.WriteLine("Veicolo noleggiato: " + v);
                }
                else Console.WriteLine($"Noleggio registrato con targa {item.VehiclePlate} - Nessun veicolo in elenco con questa targa");

                Console.WriteLine();
            }
        }
    }
}
