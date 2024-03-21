using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_JuanHernandez
{
    public class Food : Product 
    {
        // Fields / Properties
        public DateTime ExpirationDate { get; set; }

        // Constructor
        public Food(string name, double price, DateTime expirationDate) : base(name, price)
        {
            ExpirationDate = expirationDate;
        }

        // Methods
        public override string GetProductType()
        {
            return "Food";
        }
    }// class
}// namespace
