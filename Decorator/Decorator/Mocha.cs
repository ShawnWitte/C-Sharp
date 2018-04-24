using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => this.beverage.Description + ", Mocha";

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
