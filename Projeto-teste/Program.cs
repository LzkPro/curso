using Projeto_teste.Enums;
using Projeto_teste.Entitites;
using System;
using System.Globalization;
namespace Projeto_teste
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string clientname = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth Date: ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            
            Client client = new Client(clientname, email, birthdate);
            Order order = new Order(DateTime.Now, orderstatus, client);
  
            Console.Write("How many items to this Order? : ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i} item data :");
                Console.WriteLine("Product name: ");
                string prodname = Console.ReadLine();
                Console.WriteLine("Enter product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                
                Product product = new Product(prodname, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }

            
            Console.WriteLine("Order Sumary: ");
            Console.Write(order);
            Console.WriteLine("Order Items: ");
            foreach (OrderItem item in order.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}