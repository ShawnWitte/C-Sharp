using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticum
{
    class Program
    {
        static void Main(string[] args)
        {
            BusChauffeur chauffeur = new BusChauffeur("Andries");
            Dog lubas = new Dog("Lubas");

            //Dieren van de buurvrouw
            Dog piet = new Dog("Piet");
            Cat kat = new Cat();

            Console.WriteLine(chauffeur.zijnGelijk(lubas, kat));
            
            //bus
            Bus bus = new Bus(chauffeur);
            Console.WriteLine(bus);

            //Bushalte 1
            SchoolKind kwik = new SchoolKind("Kwik");
            SchoolKind kwek = new SchoolKind("Kwek");
            SchoolKind kwak = new SchoolKind("Kwak");

            bus.instappen(kwik, kwek, kwak);
            Console.WriteLine(bus);

            //Bushalte 2
            SchoolKind andries = new SchoolKind("Andries");
            bus.instappen(andries);
            Console.WriteLine(bus);

            OudeMeneer dagobert = new OudeMeneer("Dagobert");
            bus.instappen(dagobert);
            Console.WriteLine(bus);

            //Controle
            Nameable uitgestapt = bus.uitstappen("Andries");
            Console.WriteLine(bus);

            bus.instappen(lubas);
            Console.WriteLine(bus);

            bus.printNames();

            BusStation vlissingen = new BusStation();
            vlissingen.rijdtBinnen(bus);

            
            bus.printNames();




            Console.ReadLine();
        }
    }
}
