using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            Projector projector = new Projector();
            DvdPlayer dvd = new DvdPlayer();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, projector, dvd);

            homeTheater.watchMovie("Raiders of the Lost Ark");
            homeTheater.endMovie();
            Console.ReadLine();

            
        }
    }
}
