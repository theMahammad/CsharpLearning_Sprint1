using Enums;

Customer customer = new()
{
    Id = 1,
    CustomerCode = "MES001",
    Email = "mamqa@gmail.com",
    Name = "Mahammad",
    Surname = "Sadigzade"
};
CustomerReturnValue customerReturnValue =  VirtualDatabase.AddNewCustomer(customer);

if (customerReturnValue == CustomerReturnValue.succesfullyAdding)
{
    Console.WriteLine("Adding operation has been completed succesfully");
}
