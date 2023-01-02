using InheritanceProject;
using System.ComponentModel;


Notebook notebook = new()
{
    Barcode = "5713",
    Name = "Asus TUF",
    ProductionYear = DateTime.Parse("5-10-2022"),
    PurchasePrice = 1500M,
    SalePrice = 1800M,
    CampaignPrice = 1600M,
    CPU = "Intel i5-11400H",
    GPU = "Nvidia RTX 3060"

};
VirtualDatabase.AddNewProduct(notebook);

Book book = new()
{
    Barcode = "5890",
    PurchasePrice = 13M,
    SalePrice = 17M,
    CampaignPrice = 15M,
    Name = "What Men Live By",
    Genre = "Short Story",
    AuthorName = "Leo Tolstoy",
    TotalPages = 155
};
VirtualDatabase.AddNewProduct(book);
var notebooks = VirtualDatabase.GetNotebooks();
var books = VirtualDatabase.GetBooks();
Console.WriteLine("Program has been ended");


