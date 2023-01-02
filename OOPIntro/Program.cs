
using OOPIntro;

Test test = new();
Console.WriteLine(test.number);
Console.WriteLine(test.db);
Console.WriteLine(test.character);

int x = 5;
test.AddByOne(ref x);
Console.WriteLine(x);

Car car = new("BMW", "X5", 2007, 35000);
car.SalePrice = 15000M;
car.MaxDiscountAmount = 3000M;
car.FuelType = 1;
car.SetPrice(12000M);
car.DisplayDetails();

