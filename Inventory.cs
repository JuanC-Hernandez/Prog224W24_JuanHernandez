using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json;

namespace Prog224W24_JuanHernandez
{
    // Inherit IEnumerable
    public class Inventory : IEnumerable
    {
        //list field
        public List<Product> _products = new List<Product>();

        // constructor
        public Inventory(List<Product> productlist)
        {
            _products = productlist;    
        }

        // Methods

        // Adds Products
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Removes Products
        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        // Inemurable Method
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // Save to JSON file
        public void SaveToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(_products);
            File.WriteAllText(filePath, json);
            //Console.WriteLine("Saved to JSON file.");
        }

        // Loads from JSON file
        public void LoadFromJson(string filePath)
        {
            
            string json = File.ReadAllText(filePath);
            
            //_products = JsonConvert.DeserializeObject<List<Product>>(json);
            //_products = JsonSerializer.Deserialize<List<Product>>(json);

        }

    }// Class

}// namespace
