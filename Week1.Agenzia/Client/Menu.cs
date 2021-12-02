using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Agenzia.Core.BusinessLayer;
using Week1.Agenzia.Core.Entities;
using Week1.Agenzia.Mock;

namespace Week1.Agenzia.Client
{
    internal static class Menu
    {
        private static readonly AgenziaBusinessLayer bl = new(new MockImmobiliRepository());

        internal static void Start()
        {
            bool quit = false;
            Console.WriteLine("Benvenuto!");

            do
            {
                Console.WriteLine("\n[1] Visualizza tutti gli immobili");
                Console.WriteLine("[2] Filtra immobili per superficie minima");
                Console.WriteLine("[3] Visualizza gli immobili attualmente disponibili");
                Console.WriteLine("[4] Mostra gli immobili per una certa categoria");
                Console.WriteLine("[5] Inserisci un nuovo immobile");
                Console.WriteLine("[6] Elimina un immobile");
                Console.WriteLine("[7] Imposta un immobile come non disponibile");
                Console.WriteLine("[Q] Esci");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        GetAllImmobili();
                        break;
                    case '2':
                        FiltraPerSuperficieMinima();
                        break;
                    case '3':
                        FiltraPerDisponibilita();
                        break;
                    case '4':
                        MostraPerCategoria();
                        break;
                    case '5':
                        InserisciNuovoImmobile();
                        break;
                    case '6':
                        EliminaImmobile();
                        break;
                    case '7':
                        CambiaDisponibilita();
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

        private static void CambiaDisponibilita()
        {
            FiltraPerDisponibilita();
            Console.WriteLine("\nInserisci l'Id dell'immobile non più disponibile:");

            int id = GetInt();
            Immobile im = bl.GetById(id);
            if (im != null)
            {

                bl.UpdateAvailability(im);

            }
            else
                Console.WriteLine("\nAttenzione, l'Id inserito non è in elenco!");

        }

        private static void EliminaImmobile()
        {
            GetAllImmobili();
            Console.WriteLine("\nInserisci l'Id dell'immobile da eliminare:");

            int id = GetInt();
            Immobile im = bl.GetById(id);
            if (im != null)
            {
                bl.DeleteImmobile(im);
            }
            else
                Console.WriteLine("\nAttenzione, l'Id inserito non è in elenco!");


        }

        private static void InserisciNuovoImmobile()
        {
            Console.WriteLine("\nQuale tipo di immobile vuoi inserire?");
            Console.WriteLine("[a] Box auto");
            Console.WriteLine("[b] Appartamenti");
            Console.WriteLine("[c] Ville");

            char choice = Console.ReadKey().KeyChar;

            if (choice == 'a' || choice == 'b' || choice == 'c')
            {
                Console.Write("Indirizzo: ");
                string indirizzo = Console.ReadLine();
                Console.Write("CAP: ");
                int cap = GetInt();
                Console.Write("Città: ");
                string citta = Console.ReadLine();
                Console.Write("Metratura: ");
                int mq = GetInt();


                if (choice == 'a')
                {
                    Console.Write("Posti auto: ");
                    int postiAuto = GetInt();

                    Box nuovoBox = new Box();
                    nuovoBox.Indirizzo = indirizzo;
                    nuovoBox.CAP = cap;
                    nuovoBox.Citta = citta;
                    nuovoBox.SuperficieMQ = mq;
                    nuovoBox.PostiAuto = postiAuto;

                    bl.AddNewImmobile(nuovoBox);
                }
                else if (choice == 'b' || choice == 'c')
                {
                    Console.Write("Vani: ");
                    int vani = GetInt();
                    Console.Write("Bagni: ");
                    int bagni = GetInt();

                    if (choice == 'b')
                    {
                        Appartamento nuovoAppt = new();
                        nuovoAppt.Indirizzo = indirizzo;
                        nuovoAppt.CAP = cap;
                        nuovoAppt.Citta = citta;
                        nuovoAppt.SuperficieMQ = mq;
                        nuovoAppt.Vani = vani;
                        nuovoAppt.Bagni = bagni;
                        bl.AddNewImmobile(nuovoAppt);
                    }

                    if (choice == 'c')
                    {
                        Console.Write("Metratura giardino: ");
                        int mqGiardino = GetInt();

                        Villa nuovaVilla = new();
                        nuovaVilla.Indirizzo = indirizzo;
                        nuovaVilla.CAP = cap;
                        nuovaVilla.Citta = citta;
                        nuovaVilla.SuperficieMQ = mq;
                        nuovaVilla.Vani = vani;
                        nuovaVilla.Bagni = bagni;
                        nuovaVilla.MqGiardino = mqGiardino;

                        bl.AddNewImmobile(nuovaVilla);
                    }

                }

            }

            else
            {
                Console.WriteLine("\nSelezione non corretta!");
            }
        }

        private static void MostraPerCategoria()
        {
            Console.WriteLine("\nQuale categoria vuoi visualizzare?");
            Console.WriteLine("[a] Box auto");
            Console.WriteLine("[b] Appartamenti");
            Console.WriteLine("[c] Ville");

            char choice = Console.ReadKey().KeyChar;
            IEnumerable<Immobile> lista = null;
            switch (choice)
            {
                case 'a':
                    lista = bl.GetByCategory('a');
                    Console.WriteLine("\nI box auto sono:");
                    break;
                case 'b':
                    lista = bl.GetByCategory('b');
                    Console.WriteLine("\nGli appartamenti sono:");
                    break;
                case 'c':
                    lista = bl.GetByCategory('c');
                    Console.WriteLine("\nLe ville sono:");
                    break;
                default:
                    Console.WriteLine("\nSelezione incorretta!");
                    break;
            }
            if (choice == 'a' || choice == 'b' || choice == 'c')
            {
                foreach (Immobile m in lista)
                {
                    Console.WriteLine(m);
                }
            }

        }

        private static void FiltraPerDisponibilita()
        {
            IEnumerable<Immobile> immobiliDisponibili = bl.GetAvailable();
            Console.WriteLine("\nGli immobili disponibili sono:");
            foreach (Immobile imm in immobiliDisponibili)
            {
                Console.WriteLine(imm);
            }
            
        }

        private static void FiltraPerSuperficieMinima()
        {
            Console.WriteLine("\nInserisci la superficie minima che devono avere gli immobili da visualizzare:");
            int min = GetInt();

            List<Immobile> immobiliSuperfMin = bl.GetAllBySuperfMin(min).ToList();
            Console.WriteLine("\nGli immobili selezionati sono:");
            foreach (Immobile immobile in immobiliSuperfMin)
            {
                Console.WriteLine(immobile);
            }
        }

        private static int GetInt()
        {
            bool parse;
            int value;
            do
            {
                parse = int.TryParse(Console.ReadLine(), out value);
            } while (!(parse && value > 0));

            return value;
        }

        private static void GetAllImmobili()
        {
            List<Immobile> immobili = bl.GetAllImmobili().ToList();
            Console.WriteLine("\nGli immobili sono:");
            foreach (Immobile immobile in immobili)
            {
                Console.WriteLine(immobile);
            }
        }
    }
}
