using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            PruductManager pruductManager = new PruductManager();
            pruductManager.Add();
            pruductManager.Update();


            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "test";
            customer.LastName = "erfgre";
            customer.City = "Ankara";

            Customer customer2 = new Customer { Id =2, FirstName="Hilal", LastName= "demir",City="Konya"};

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
