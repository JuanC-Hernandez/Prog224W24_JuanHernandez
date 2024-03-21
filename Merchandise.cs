using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_JuanHernandez
{
    public class Merchandise : Product
    {
        // Fields / Properties
        public string Category { get; set; }

        // Constructor
        public Merchandise(string name, double price, string category) : base(name, price)
        { 
            Category = category;
        }

        // methods
        public override string GetProductType()
        {
            return "Merchandise";
        }

    }// class
}// namespace

