using Products.Models;
using System;

namespace Products
{
    class Program
    {
        ProductsDBContext context;
        public Program()
        {
            context = new ProductsDBContext();
        }
        static int GetNumberInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid Entry !.enter number again");
            }
            return num;
        }
        static string GetStringInput()
        {
            string input = Console.ReadLine();
            while (input.Length == 0)
            {
                Console.WriteLine("Field cannot be empty!. Enter Again");
                input = Console.ReadLine();
            }
            return input;
        }
        void ProductsMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("1. List Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Exit\n");
                Console.WriteLine("Please select a option");
                choice = GetNumberInput();
                switch (choice)
                {
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        Console.WriteLine("you entered exit!.Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid option!. Please try Again");
                        ProductsMenu();
                        break;
                }
            } while (choice != 3);
        }
        void ListProducts()
        {
            foreach (var item in context.Products)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Product ID : " + item.ProductId);
                Console.WriteLine("Product Name : " + item.Name);
                Console.WriteLine("Product Price : " + item.Price);
                Console.WriteLine("Product Quantity : " + item.Quantity);
                Console.WriteLine("-----------------------------------");
            }
        }
        void AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Enter the Product Name");
            product.Name = GetStringInput();
            Console.WriteLine("Enter the Product Price");
            product.Price = GetNumberInput();
            Console.WriteLine("Enter the Product Quantity");
            product.Quantity = GetNumberInput();
            context.Products.Add(product);
            context.SaveChanges();
            int prodcutNumber = product.ProductId;
            Console.WriteLine("\nProduct Added! "+prodcutNumber);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ProductsMenu();
            Console.ReadKey();
        }
    }
}
