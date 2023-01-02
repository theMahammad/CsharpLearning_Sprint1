using Static;

Student student = new();
student.Name = "Mahammad";
student.Surname = "Sadigzada";
student.SayHelloToSpecificPerson();
//student.SayHelloGenerally(); //compile-time error -- An instance doesn't access a static method/field of its class
Console.WriteLine("****************************");
Student.SayHelloGenerally();
