namespace Prog224W24_JuanHernandez
{

    // Juan Hernandez
    // Final - "Why is it still dark outside, Joe?" App
    // 03/20/24

    /**
     * Notes:
     * 
     * Couldnt make it read from the read the json file, I believe I was close but it kept throwing error, 
     * cant convert type string, in the inverntor class Load from json file method. I have left most of 
     * my test code comment it out so you can see and give me some advise.
     * 
     * I had to load inventory localy from main.
     * 
     * I got it to save inital items and item added from user to 
     * 
     **/

    internal class Program
    {
        static void Main(string[] args)
        {
            // Location of json file
            string location = @"..\..\productList.json";

            // new product list 
            List<Product> inventory = new List<Product>();

            // creating items and adding items to list
            Beverage beverage = new Beverage("Soda", 1.99, "Carbonated");
            Food food = new Food("Sandwich", 5.99, Convert.ToDateTime("07-31-2024")); // couldnt figure out date time without converting
            Merchandise merchandise = new Merchandise("T-shirt", 19.99, "Clothing");
            inventory.Add(beverage);
            inventory.Add(food);
            inventory.Add(merchandise);

            // adding to inventory list to add to json file
            // Have to reset each time app opens b/c I could get program to read from file, I got it to save. you can check file after closing app
            Inventory productList = new Inventory(inventory);
            productList.SaveToJson(location);
                        

            int choice = 0;
            

            do
            {
                // Menu
                Console.WriteLine("******************************************************");
                Console.WriteLine("Welcome to the Why is it still dark outside, Joe? App");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Ring Up Customer");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                // try catch if wrong input
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        // Displays from main, could read it from json, got it to save but not load
                        Console.WriteLine("\n********************************");
                        Console.WriteLine("Available Products: ");
                        int count = 0;
                        foreach (Product product in inventory)
                        {
                            //keeps count of item in inventory
                            count += 1;
                            Console.WriteLine($"{count}. {product.ToString()}");
                        }
                        productList.LoadFromJson(location);
                        Console.WriteLine("********************************\n");
                        break;
                    case 2:
                        // getting user information for new product
                        Console.WriteLine("\nEnter product name: ");
                        string newProduct = Console.ReadLine();

                        // making sure user enters valid value for price
                        double newPrice = 0;
                        bool isValidInput = false;
                        do
                        {
                            Console.WriteLine("Enter product price: ");
                            string input = Console.ReadLine();

                            try
                            {
                                newPrice = Convert.ToDouble(input);
                                isValidInput = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid double value.");
                            }
                        }
                        while (!isValidInput);
                        //***********************************************
                        // getting type of product
                        Console.WriteLine("\nSelect product type: \n1. Beverage\n2. Food\n3. Merchandise");
                        int productType=0;
                        bool isValidInput2 = false;
                        
                        // making sure user chooses from the available options only
                        do
                        {
                            Console.WriteLine("Enter your choice: ");
                            string input2 = Console.ReadLine();


                            try
                            {
                                productType = Convert.ToInt32(input2);

                                if (productType >= 1 && productType <= 3)
                                {
                                    isValidInput2 = true;

                                    
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid option.");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid option.");
                            }
                        }
                        while (!isValidInput2);
                        //***********************************************
                        if (productType == 1)
                        {
                            // user bev size for option 1 
                            Console.WriteLine("Enter beverange size (Small\\Medium\\Large): ");
                            string bevSize = Console.ReadLine();
                            // adding new user beverage to list and saving to json, Check file after closing app
                            Beverage userBev = new Beverage(newProduct, newPrice, bevSize);
                            inventory.Add(userBev);
                            productList.SaveToJson(location);
                            Console.WriteLine("Product added successfully!");
                        }
                        //***********************************************
                        else if (productType == 2)
                        {
                            
                            int expMo = 0;
                            bool isValidInput3 = false;

                            // making sure user chooses from the available options only
                            do
                            {
                                // getting user exp Month for option 2
                                Console.WriteLine("Enter expiration Month(ex. 01=Jan to 12=Dec): ");
                                string input3 = Console.ReadLine();


                                try
                                {
                                    expMo = Convert.ToInt32(input3);

                                    if (expMo >= 1 && expMo <= 12)
                                    {
                                        isValidInput3 = true;

                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid option.");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid option.");
                                }
                            }
                            while (!isValidInput3);

                            //***********************************************
                            int expDay = 0;
                            bool isValidInput4 = false;

                            // making sure user chooses from the available options only
                            do
                            {
                                // getting user exp Day for option 2
                                Console.WriteLine("Enter expiration day: ");
                                string input4 = Console.ReadLine();


                                try
                                {
                                    expDay = Convert.ToInt32(input4);

                                    if (expDay >= 1 && expDay <= 31)
                                    {
                                        isValidInput4 = true;

                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid option.");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid option.");
                                }
                            }
                            while (!isValidInput4);
                            //***********************************************
                            int expYear = 0;
                            bool isValidInput5 = false;

                            // making sure user chooses from the available options only
                            do
                            {
                                // getting user exp Year for option 2
                                Console.WriteLine("Enter expiration year: ");
                                string input5 = Console.ReadLine();


                                try
                                {
                                    expYear = Convert.ToInt32(input5);

                                    if (expYear >= 2024 && expYear <= 3000)
                                    {
                                        isValidInput5 = true;

                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid option.");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid option.");
                                }
                            }
                            while (!isValidInput5);
                            // adding new user beverage to list and saving to jsonm, Check file after closing app
                            Food userFood = new Food(newProduct, newPrice, Convert.ToDateTime($"{expMo}-{expDay}-{expYear}"));
                            inventory.Add(userFood);
                            productList.SaveToJson(location);
                            Console.WriteLine("Product added successfully!");
                        }
                        //***********************************************
                        else if (productType == 3)
                        {
                            Console.WriteLine("Enter mechandise category: ");
                            string merchCat = Console.ReadLine();
                            // adding new user beverage to list and saving to json, Check file after closing app
                            Merchandise userMerch = new Merchandise(newProduct, newPrice, merchCat);
                            inventory.Add(userMerch);
                            productList.SaveToJson(location);
                            Console.WriteLine("Product added successfully!");

                        }
                        break;
                    case 3:
                        int count2 = 0;

                        // initializing new order.
                        Order newOrder = new Order();
                        Console.WriteLine("\nSelect a product to add the order: ");
                        // displaying menu
                        foreach (Product product in inventory)
                        {
                            //keeps count of item in inventory
                            count2 += 1;
                            Console.WriteLine($"{count2}. {product.ToString()}");
                        }
                        
                        
                        int itemSelection = 0;
                        bool isValidInput99 = false;

                        // making sure user chooses from the available options only
                        do
                        {
                            // added bool to see if user wants to keep adding
                            bool continueOrder = true;
                            while (continueOrder)
                            {
                                Console.WriteLine("Enter product number: ");
                                string orderOption = Console.ReadLine();


                                try
                                {
                                    itemSelection = Convert.ToInt32(orderOption);

                                    if (itemSelection >= 1 && itemSelection <= count2)
                                    {
                                        isValidInput99 = true;
                                        // adding item to order
                                        newOrder.AddProduct(inventory[itemSelection - 1]);
                                        //double orderPrice = newOrder.CalculateTotalPrice();
                                        //Console.WriteLine(orderPrice);
                                        Console.WriteLine("Product added to the order.");
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid option.");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid option.");
                                }
                                // asking if wanting to add moreproducts
                                Console.WriteLine("Do you want to add more products to the order? (yes/no): ");
                                // to lower response
                                string selectedOption = Console.ReadLine().ToLower();
                                // change to break if user chooses no
                                if (selectedOption == "no")
                                {
                                    //double total = Convert.ToDouble(newOrder.CalculateTotalPrice);
                                    Console.WriteLine($"Total price of the order: ${newOrder.CalculateTotalPrice()}\n");
                                    Receipt receipt = new Receipt(newOrder);

                                    // displaying receipt
                                    Console.WriteLine("\n************************************");
                                    Console.WriteLine(receipt.ToString());
                                    Console.WriteLine("************************************\n");
                                    continueOrder = false;
                                }
                            }
                            
                        }
                        while (!isValidInput99);



                        break;
                    case 4:
                        Console.WriteLine("Exiting the app.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.\n");
                        break;
                }

            } while (choice != 4);


        }// main
    }// class
}// namespace

// Complete