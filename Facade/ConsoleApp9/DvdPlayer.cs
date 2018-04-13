using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class DvdPlayer
    {
        public void on()
        {
            Console.WriteLine("Dvd is now on");
        }

        public void play(string x)
        {
            Console.WriteLine("Now plaing " + x);
        }

        public void stop()
        {
            Console.WriteLine("Dvd is now off");
        }

        public void eject()
        {
            Console.WriteLine("Dvd ejecting");
        }

        public void off()
        {
            Console.WriteLine("Dvd is now off");
        }
    }
}
