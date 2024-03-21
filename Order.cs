using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_JuanHernandez
{
    public class Order
    {
        // Fields / Properties
        public List<Product> Products { get; }
        public double TotalPrice { get; set; }

        // Constructor
        public Order()
        {
            Products = new List<Product>();
            TotalPrice = 0;
        }

        // Methods
        
        // Adds products to list
        public void AddProduct(Product product)
        {
            Products.Add(product);
            TotalPrice += product.Price;
        }

        // Calculates total price 
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }// class

}// namespace
