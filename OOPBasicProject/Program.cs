using OOPBasicProject;
using System.Collections;

Customer customer = new()
{
    Name = "Mahammad",
    Surname = "Sadigzada",
    EmailAdress = "mahammad@gmail.com",
    Username = "maqa355",
    Password = " 123456 "
};
Customer customer1 = new()
{

    Name = "Nagi",
    Surname = "Aliyev",
    EmailAdress = "nagi@gmail.com",
    Username = "maqa355",
    Password = "12345566"
};
Customer customer2 = new()
{
    Name = "Mading",
    Surname = "Gahramanov",
    EmailAdress = "mading@gmail.com",
    Password = "12345566"
};
Customer customer3 = new()
{
    Name = "Ayaz",
    Surname = "Dergahli",
    EmailAdress = "ayaz@gmail.com",
    Username = "ayazMessi10",
    Password = "12345566"
};
Customer customer4 = new()
{
    Name = "Kanan",
    Surname = "Rahimov",
    EmailAdress = "ayaz@gmail.com",
    Username = "kananQaniQara",
    Password = "1234567"
};
CustomerHelper.AddCustomer(customer);



CustomerHelper.AddCustomer(customer1); //The username field of customer1 exist in system, so it won't be accepted

CustomerHelper.AddCustomer(customer2); // Due to not having username, this operation also won't be accepted

CustomerHelper.AddCustomer(customer3); // The id field of this instance has been set inside AddCustomer() method

CustomerHelper.AddCustomer(customer4); // Due to having existed email adress, this instance has not been added

CustomerHelper.ShowAllCustomers();

        