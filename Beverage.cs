using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_JuanHernandez
{
    public class Beverage : Product
    {
        // Feild / Properties
        public string Size { get; set; }

        // Constructor
        public Beverage(string name, double price, string size) : base(name, price)
        {
            Size = size;
        }

        // Methods
        public override string GetProductType()
        {
            return "Beverage";
        }

    }// class
}// namespace
