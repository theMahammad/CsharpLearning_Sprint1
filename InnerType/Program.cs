using InnerType;
using System.ComponentModel.DataAnnotations;

Customer customer1 = new()
{
    Id = 1,
    Name = "Mahammad",
    Surname = "Sadigzada",
    PIN = "14759e",
};

customer1.adresses.Add(
    new Address()
    {
        AddressType = "1",
        City = "Lankaran",
        Street = "Shirali Akhundov 22",
        PostCode = "AZ4200"
    }
    );
customer1.adresses.Add(
    new Address()
    {
        AddressType = "1",
        City = "Baku",
        Street = "Eli Isgender Isgenderov 1",
        PostCode = "AZ1001"
    }
    );
foreach(Address address in customer1.adresses)
{
    address.ShowAdressDetails();
}

#region Adding Product to Order list
customer1.orders.Add(
    new Order()
    {
        OrderCode = "5700",
        
    });
foreach(Order order in customer1.orders)
{
    order.products.Add(
        new Product()
        {
            Name = "Acer Nitro 5",
            Price = 1000,
            ProductionYear = DateTime.Parse("05-12-2021")
        }
        ); ;
}
#endregion
foreach(Order order in customer1.orders)
{
    foreach(Product product in order.products)
    {
        product.ShowProductDetails();
    }
}

