// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            
            Customer customer = new Customer();

            customer.City = "Konya";
            customer.Id = 4900;
            customer.FirstName = "Mustafa";
            customer.LastName = "Gediz";

            Customer customer2 = new Customer
            {
                Id = 49,City = "Ankara",FirstName = "Ahu",LastName = "Gediz"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
        
    }
}
