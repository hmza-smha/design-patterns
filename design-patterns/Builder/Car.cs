using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Builder
{
    internal class Car
    {
        private int _id;
        private string _name;
        private string _model;
        private string _brand;
        private string _color;
        private double _height;
        private double _width;
        // ...

        public Car(int id, string name, string model, string brand, string color, double height, double width)
        {
            _id = id;
            _name = name;
            _model = model;
            _brand = brand;
            _color = color;
            _height = height;
            _width = width;
            // ...
        }

        public void PrintInfo()
        {
            Console.WriteLine("Id: " + _id);
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Model: " + _model);
            Console.WriteLine("Brand: " + _brand);
            Console.WriteLine("Color: " + _color);
            Console.WriteLine("Height: " + _height);
            Console.WriteLine("Width: " + _width);
        }
        
    }
}
