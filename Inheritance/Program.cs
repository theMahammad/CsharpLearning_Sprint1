using Inheritance;

Student student = new();
Instructor instructor = new();
Console.WriteLine(student.Id);
Console.WriteLine(instructor.Id);

Staff staff = new();
staff.Foo();
BaseType type = staff; //Boxing
Staff staff2 = type as Staff; //Unboxing






