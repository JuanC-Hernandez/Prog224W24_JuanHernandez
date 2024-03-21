using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_JuanHernandez
{
    public class Receipt
    {
        // Fields / Properties
        public Order Order { get;}
        public double Total { get;}

        // Constructor
        public Receipt(Order order)
        {
            Order = order;
            Total = order.CalculateTotalPrice();            
        }

        // Methods
        // Receipt to string
        public override string ToString()
        {
            string receipt = $"Thank your purchase!" +
                $"\nTotal Price: ${Total}\n" +
                $"\nProducts ordered:\n";

            foreach (Product product in Order.Products)
            {
                receipt += $"{product.Name}: ${product.Price}\n";
            }

            return receipt;
        }
    }// class
}// namespace
