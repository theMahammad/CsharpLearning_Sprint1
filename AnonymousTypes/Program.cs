

using System.Runtime.CompilerServices;

var type = new
{
    id = 1,
    name = "mahammad",
    surname = "sadigzada",
    age = 20,
    email = "maqa@gmail.com"
};
void PrintInfo()
{
   
    Console.WriteLine($"ID : {type.id}\nNAME : {type.name}\nSURNAME : {type.surname}\nAGE : {type.age}\nEMAIL : {type.email}");
}
PrintInfo();



