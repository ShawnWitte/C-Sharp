using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Amplifier
    {
       public void on()
        {
            Console.WriteLine("Amplifier on");
        }

        public void off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void setDvd(string x)
        {
            Console.WriteLine("Now setting " + x);
        }

        public void setVolume(int x)
        {
            Console.WriteLine("Volume set to " + x);
        }
    }
}
