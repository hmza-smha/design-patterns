using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Creational.Prototype.Example2
{
    internal class Car1 : Vehicle
    {
        private int _topSpeed;

        public Car1(Car1 car1) : base(car1)
        {
            _topSpeed = car1._topSpeed;
        }

        public override Car1 Clone()
        {
            return new Car1(this);
        }
    }
}
