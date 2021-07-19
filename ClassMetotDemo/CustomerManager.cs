using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi" + " " + customer.FirstName + " " + customer.LastName);
        }
        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Güncllendi" + " " + customer.FirstName + " " + customer.LastName);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi" + " " + customer.FirstName + " " + customer.LastName);
        }
    }
}
