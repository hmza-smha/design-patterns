﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Creational.Prototype.Example2
{
    internal class Car2 : Vehicle
    {
        private int _doors;

        public Car2(Car2 car2) : base(car2)
        {
            _doors = car2._doors;
        }

        public override Car2 Clone()
        {
            return new Car2(this);
        }
    }
}
