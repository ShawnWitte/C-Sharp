using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticum
{
    public class Dog : Nameable
    {
        private bool head = true;
        private bool tail = true;
        private string name;

        public Dog(string name)
        {
            this.name = name;
        }

        public bool hasHead()
        {
            return this.head;
        }

        public bool hasTail()
        {
            return this.tail;
        }

        public bool Equals(Cat cat)
        {
            return (cat.hasHead() == this.hasHead() && cat.hasTail() == this.hasTail());
                     
        }

        public string getName()
        {
            return this.name;
        }
    }
}
