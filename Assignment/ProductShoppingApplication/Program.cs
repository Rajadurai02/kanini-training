using ProductShoppingApplication.Models;
using System;

namespace ProductShoppingApplication
{
    class Program
    {
        ProductContext context;
        public Program()
        {
            context = new ProductContext();
        }
        /// <summary>
        /// Method for printing the menu based on the input it invokes other methods
        /// </summary>
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. List All Items");
                Console.WriteLine("2. Exit");
                //geting input choice
                try
                {
                    Console.WriteLine("Please select a option");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please select option 1 or 2");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                switch (choice)
                {
                    //if user selects 1 it invokes the PrintAllProducts and PurchaseProduct methods
                    case 1:
                        PrintAllProducts();
                        PurchaseProduct();
                        break;
                    //if user enters 2 then exit from the application
                    case 2:
                        Console.WriteLine("You entered Exit!!.Bye");
                        break;
                    default:
                        Console.WriteLine("Invaild option. Try Agin");
                        break;
                }
            } while (choice != 2);//it continues ask input from user until user enters exit
        }
        /// <summary>
        /// Method for printing all product details
        /// </summary>
        void PrintAllProducts()
        {
            foreach (var item in context.Products)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Product ID :" + item.ProductId);
                Console.WriteLine("Product Name :" + item.Name);
                Console.WriteLine("Product Price :" + item.Price);
                Console.WriteLine("Quantity Avilable :" + item.Quantity);
                Console.WriteLine("--------------------------------");
            }
        }
        //Method for purchasing the product
        void PurchaseProduct()
        {
            int productID;
            //geting the product id from user
            try{
                Console.WriteLine("Please enter the ProductID you want to purchase");
                productID = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("please enter productId in numbers");
                productID = Convert.ToInt32(Console.ReadLine());
            }
            //finding the product id present in the table
            var product = context.Products.Find(productID);
            //if product id present in the table it prints the particluar product details
            if (product != null)
            {
                Console.WriteLine("you have selected ProductID " + productID);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Product ID :" + product.ProductId);
                Console.WriteLine("Product Name :" + product.Name);
                Console.WriteLine("Product Price :" + product.Price);
                Console.WriteLine("Quantity Avilable :" + product.Quantity);
                Console.WriteLine("--------------------------------");
                //check the quantity of the product if product is availble then get the quantity
                if (product.Quantity > 0)
                {
                    int quantityNeeded;
                    //geting the quantity from user
                    try
                    {
                        Console.WriteLine("Please enter the Quantity you want");
                        quantityNeeded = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("please enter Quantity in numbers");
                        quantityNeeded = Convert.ToInt32(Console.ReadLine());
                    }
                    //if user entered quantity is lesser than or equal  to available quantity print the total amount
                    if (quantityNeeded <= product.Quantity)
                    {
                        Console.WriteLine($"\nYour Total Amount is Rs.{quantityNeeded * product.Price}\n");
                        //deducting the purchased quantity from the database
                        product.Quantity -= quantityNeeded;
                        context.SaveChanges();
                    }
                    //if user entered quantity is greater than to available quantity it prints the following msg
                    else
                    {
                        Console.WriteLine("The Mentioned Quantity is Not Available\n");
                    }
                }
                //if product quantity is zero it prints out of stock
                else
                {
                    Console.WriteLine("The Product is out of Stock!!\n");
                }
            }
            //user enters the some random id not present in databse it prints no such product
            else
            {
                Console.WriteLine("There is no Such ProductId \n"+productID);
            }
        }
        static void Main(string[] args)
        {
            new Program().PrintMenu();
            Console.ReadKey();
        }
    }
}
