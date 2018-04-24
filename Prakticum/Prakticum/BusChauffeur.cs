using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticum
{
    public class BusChauffeur
    {
        private string name;

        public BusChauffeur(string name)
        {
            this.name = name;

        }

        public bool zijnGelijk(Dog dog, Cat cat)
        {
            return dog.Equals(cat);
        }

        public bool zijnGelijk(Dog dog, Dog dog2)
        {
            return (dog == dog2);
        }
    }
}
