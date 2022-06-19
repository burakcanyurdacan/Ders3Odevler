using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Customer cst = new Customer()
            {
                Id = customer.Id,
                Ad = customer.Ad,
                Soyad = customer.Soyad
            };

            Console.WriteLine(String.Format("Yeni müşteri eklendi. Müşteri bilgileri:\n" +
                "Id: {0}\n" +
                "Ad: {1}\n" +
                "Soyad: {2}", cst.Id, cst.Ad, cst.Soyad));
        }

        public void ListCustomer(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Id:"+customer.Id + "\n" + "Ad:"+customer.Ad + "\n" + "Soyad:"+customer.Soyad+"\n");
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Aşağıdaki bilgilere sahip müşteri silinmiştir.\n" +
                "ID: "+customer.Id+"\n"+
                "Ad: "+customer.Ad+"\n"+
                "Soyad: "+customer.Soyad);
        }
    }
}