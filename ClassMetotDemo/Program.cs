using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ulaş";
            customer1.LastName = "Müezzinoğlu";
            customer1.IdentityNumber = "11111111111";
            customer1.BirthYear = 2000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.IdentityNumber = "22222222222";
            customer2.BirthYear = 1986; // umarım tutturmuşumdur :)
            customer2.Balance = 250000;

            Console.WriteLine("---------------Operasyonlar---------------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer1);
            customerManager.UpdateCustomer(customer1);
            Console.WriteLine("---------------------------");
            customerManager.AddCustomer(customer2);
            customerManager.DeleteCustomer(customer2);
            customerManager.UpdateCustomer(customer2);

        }
    }
}
