using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class TurkeyAdapter : IDucks
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void quack()
        {
            turkey.gobble();
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }
    }
}
