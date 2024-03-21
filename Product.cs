using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_JuanHernandez
{
    public abstract class Product
    {
        // fields
        private string _name;
        private double _price;

        // properties
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }

        // Constructor
        public Product(string name, double price) 
        { 
            Name = name;
            Price = price;
        }

        // methods

        // overrides to string method
        public override string ToString()
        {
            return $"{Name}, Price: ${Price}";
        }

        // gets product type
        public abstract string GetProductType();

    }// class
}// namespace
