using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_12
{
    public class DuckSimulator
    {
        public static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            simulator.simulate();

            Console.ReadLine();
        }

        void simulate()
        {
            Quackable mallardDuck = new MallardDuck();
            Quackable redheadDuck = new RedheadDuck();
            Quackable duckCall = new DuckCall();
            Quackable rubberDuck = new RubberDuck();
            Quackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("\nDuck Simulator");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);
        }

        void simulate(Quackable duck)
        {
            duck.quack();
        }
    }
}
