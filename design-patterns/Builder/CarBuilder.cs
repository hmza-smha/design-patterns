using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Builder
{
    internal class CarBuilder
    {
        private int _id;
        private string _name;
        private string _model;
        private string _brand;
        private string _color;
        private double _height;
        private double _width;
        // ...

        public Car Build()
        {
            return new Car(_id, _name, _model, _brand, _color, _height, _width);
        }


        public void Id(int id)
        {
            _id = id;
        }

        public void Name(string name)
        {
            _name = name;
        }

        public void Model(string model)
        {
            _model = model;
        }

        public void Brand(string brand)
        {
            _brand = brand;
        }

        public void Color(string color)
        {
            _color = color;
        }

        public void Height(double height)
        {
            _height = height;
        }

        public void Width(double width)
        {
            _width = width;
        }
    }
}
