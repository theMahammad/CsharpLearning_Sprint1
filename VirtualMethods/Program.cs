using VirtualMethods;

Test test = new()
{
    Age = 18,
    Name = "Tural"
};
Console.WriteLine(test.ToString());

SubSubClass subSub = new();
subSub.sayHello();