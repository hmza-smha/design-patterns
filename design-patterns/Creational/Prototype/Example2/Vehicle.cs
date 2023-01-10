using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Creational.Prototype.Example2
{
    /*
     * Prototype Design 2 (Vehicle, Car1, Car2 classes)
     * 
     * Without Interface
     * Provide abstract Clone() method in the super class
     * 
     * NOTE:
     * if the class have a (HAS-A object x) thrn x should implement
     * prototype design pattern or you will end up with shallow copy!
     */
    internal abstract class Vehicle
    {
        private string _id;
        public string color;
        public string brand;
        // ...

        public Vehicle(Vehicle vehicle)
        {
            _id = vehicle._id;
            color = vehicle.color;
            brand = vehicle.brand;
            // ...
        }

        public abstract Vehicle Clone();
    }
}
