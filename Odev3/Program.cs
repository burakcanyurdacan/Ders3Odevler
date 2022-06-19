using Odev3;

CustomerManager manager = new CustomerManager();
Customer customer = new Customer()
{
    Id = 1,
    Ad = "Burak Can",
    Soyad = "Yurdacan"
};

Customer customer2 = new Customer()
{
    Id = 2,
    Ad = "Ahmet",
    Soyad = "Demir"
};

Customer customer3 = new Customer()
{
    Id = 3,
    Ad = "Mehmet",
    Soyad = "Çelik"
};

Console.WriteLine("Ekleme işlemi\n*********************");
manager.AddCustomer(customer);
Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Listeleme işlemi\n*********************");
Customer[] customersArray = { customer, customer2, customer3 };
manager.ListCustomer(customersArray);
Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Silme işlemi\n*********************");
manager.DeleteCustomer(customer3);
