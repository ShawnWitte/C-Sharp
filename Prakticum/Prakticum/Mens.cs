using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticum
{
    class Mens : Nameable
    {
        private string name;

        public Mens(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

    }
}
