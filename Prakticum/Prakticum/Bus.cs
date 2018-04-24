using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticum
{
    public class Bus
    {
        private BusChauffeur chauffeur;
        private Dictionary<string, Nameable> stoelen = new Dictionary<string, Nameable>();

        public Bus(BusChauffeur chauffeur)
        {
            this.chauffeur = chauffeur;
        }

        public void instappen(Nameable mens1, Nameable mens2, Nameable mens3)
        {
            instappen(mens1);
            instappen(mens2);
            instappen(mens3);
        }

        private void showInfo(Nameable mens, string actie)
        {
            Console.WriteLine(mens.getName() + actie);
        }


        public void instappen(Nameable mens)
        {
            string key = mens.getName();
            Nameable value = mens;
            this.stoelen.Add(mens.getName(), mens);
            showInfo(mens, " is ingestapt.");
        }


        private int getCount()
        {
            return stoelen.Count();
        }

        public Nameable uitstappen(string name)
        {
            if (!stoelen.ContainsKey(name))
            {
                Console.WriteLine(name + " zit niet in de bus.");
                return null;
            }
            Nameable uitgestapte = stoelen[name];
            stoelen.Remove(name);
            showInfo(uitgestapte, " is uitgestapt.");
            return uitgestapte;
        }

        public string[] getNames()
        {
            return (string[])stoelen.Keys.ToArray();
            
        }

        public void printNames()
        {
            Console.WriteLine("Deze wezens zitten in de bus:");
            foreach (var keyValue in stoelen)
            {
                Console.WriteLine(keyValue.Key);
            }
        }

        public override string ToString()
        {

            return "Er zitten " + getCount() + "  wezens in de bus";

        }
    }
}
