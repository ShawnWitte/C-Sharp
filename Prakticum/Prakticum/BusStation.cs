using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticum
{
    public class BusStation
    {
        private Stack<Nameable> perron = new Stack<Nameable>();
        public void rijdtBinnen(Bus bus)
        {
            leegBus(bus);
            vulBus(bus);
        }


        public void leegBus(Bus bus)
        {
            foreach(string name in bus.getNames())
            {
                Nameable uitgestapte = bus.uitstappen(name);
                perron.Push(uitgestapte);
                bus.uitstappen(name);
            }

        }

        public void vulBus(Bus bus)
        {
            while (perron.Any())
            {
                Nameable opgestapelde = perron.Pop();
                bus.instappen(opgestapelde);
            }
        }
    }
}
