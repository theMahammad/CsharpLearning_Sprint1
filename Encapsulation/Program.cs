using Encapsulation;

Customer customer = new();
customer.Name = "Mahammad";
Console.WriteLine(customer.Name); //Maha
customer.Name = "Mahamma"; 
Console.WriteLine(customer.Name); //Mahamma

customer.Id = -1;
Console.WriteLine(customer.Id);

customer.Pin = "12345678910";
Console.WriteLine(customer.Pin);
customer.Name = "Mahammad";
customer.Surname = "Sadigzada";
Console.WriteLine(customer.EmailAdress);
