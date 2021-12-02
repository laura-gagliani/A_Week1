using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.LINQ
{
    internal class DemoLINQ
    {
        public static void Demo()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Tizio", Salary = 1200 },
                new Employee() {Id = 2, Name = "Caio", Salary = 1500 },
                new Employee() {Id = 3, Name = "Sempronio", Salary = 1300 },
                new Employee() {Id = 4, Name = "Caio", Salary = 1300 }
            };

            //fino ad ora:
            foreach (var item in employees)
            {
                if (item.Id == 2)
                {
                    Console.WriteLine(item.Name);
                }
            }

            //linq:
            var names =     //mi troverò una Ienumerable di string (a prescindere che la query renda 1 nome o 300 nomi)
                from e in employees
                where e.Id == 2
                select e.Name;

            Console.WriteLine();
            foreach (string name in names) //names è il generico "oggetto Ienumerable" che la query ha reso
            {
                Console.WriteLine(name);
            }


            IEnumerable<Employee> filtered =
                from e in employees
                where e.Id == 2
                select e;

            //con il foreach dopo la query faccio l'esecuzione differita (cioè che esegue la query solo quando si  trova es. il "names" nel foreach
            //se voglio farla immediata (??) devo fare il .toList() (????)
            IEnumerable<Employee> filtered2 =
                from e in employees
                where e.Id == 2
                select e;

            //es di query di ordinamento
            var orderedEmployees =
                from e in employees
                orderby e.Name
                select e;

            //using System.LinQ     <--- libreria per ? operatori ?


            //fine parte query syntax
            //inizio parte con lambda expressions

            //TRADUZIONE DI:
            //IEnumerable<Employee> filtered =
            //    from e in employees
            //    where e.Id == 2
            //    select e;

            IEnumerable<Employee> filteredEmp1 = employees.Where(x => x.Id == 2).ToList();
            //quella dentro il Where() è la lambda expression

            foreach (var item in filteredEmp1)
            {
                //fai cose
            }

            //seleziona impiegati con salario maggiore di 1500
            var filteredEmp2 = employees.Where(e => e.Salary >= 1500).ToList();

            //recuperare tutti i nomi degli impiegati
            var selectNames = employees.Select(e => e.Name);

            //recuperare I NOMI degli impiegati con id 2 (che sarà solo uno ma vabbè, in teoria rende l'elenco)

            //faccio una select sul risultato del where? si, scrivendo una "operazione" dietro l'altra
            var nameofempno2 = employees.Where(x => x.Id == 2).Select(e => e.Name);

            //ci sono dei metodi che prendono il primo elemento che risponde a una condizione (or default o no a seconda di che vuoi)
            var foundemployee = employees.FirstOrDefault(e => e.Id == 2);
            var foundemployee2 = employees.First(e => e.Id == 6); //questo se non trova roba va in eccezione
                                                                  // esiste anche, es., il SingleOrDefault. se io voglio che mi renda l'elemento solo se è singolo

            //ordinare gli impiegati
            var orderedemployees = employees.OrderBy(e => e.Name);

            //estraggo ogni nome dai miei impiegati e lo manipolo
            var names2 = employees.Select(e => e.Name.ToUpper());

            //qui non andrà a filtrare in base all'id == 2; renderà un elenco di bool che dicono per ogni employee se è vero o no che id è 2
            var employeebooleans = employees.Select(e => e.Id == 2); //dopo la freccia c'è una condizione(bool)
        }
    }
}
