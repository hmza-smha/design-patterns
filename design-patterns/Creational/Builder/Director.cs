using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Builder
{
    /*
     * This is an optional class in Buider Design Pattern
     */
    internal class Director
    {
        public void BuildBMW(CarBuilder builder)
        {
            builder.Brand("BMW");
        }
    }
}
