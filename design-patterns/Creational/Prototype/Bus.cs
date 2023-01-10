using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Prototype
{
    /*
     * Prototype Design 1 (only Bus class)
     * 
     * In prototype design pattern the cloneable class must implement an interface 
     * which have only one method Clone() like the built in ICloneable interface
     * 
     * NOTE:
     * if the class have a (HAS-A object x) thrn x should implement
     * prototype design pattern or you will end up with shallow copy!
     */
    internal class Bus : ICloneable
    {
        private string _id;
        public string color;
        public string brand;
        // ...

        public Bus()
        {
            _id = Guid.NewGuid().ToString();
        }

        public Bus(Bus bus)
        {
            _id = bus._id;
            color = bus.color;
            brand = bus.brand;
            // ...

            /* 
             * if the Bus is subclass then use:
             * super(bus);
             * _topSpeen = bus._topSpeed;
             * ...
             * 
             */
        }

        /*
         * Bus b1 = new Bus();
         * Bus b2 = (Bus) b1.Clone();
         */
        public object Clone()
        {
            /*
             * the return type 'object' will be always Bus
             */
            return new Bus(this);
        }

        public string GetId()
        {
            return _id;
        }
    }
}
