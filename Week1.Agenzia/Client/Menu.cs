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
                Console.WriteLine("[1] Visualizza tutti gli immobili");
                Console.WriteLine("[2] ...");
                Console.WriteLine("[Q] Esci");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        GetAllImmobili();
                        break;
                    case '2':
                        break;
                    case 'Q':
                        quit = true;
                        Console.WriteLine("Chiusura in corso...");
                        break;
                    default:
                        Console.WriteLine("Scelta errata dal menu!");
                        break;
                }

            } while (quit);
        }

        private static void GetAllImmobili()
        {
            List<Immobile> immobili = bl.GetAllImmobili();
        }
    }
}
