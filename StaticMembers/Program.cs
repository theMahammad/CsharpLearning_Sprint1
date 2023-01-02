using StaticMembers;

Staff staff = new();
staff.Name = "Ruslan";
staff.Surname = "Mirzeyev";
staff.EmailAdress = "ruslan.mirze";
Console.WriteLine(staff.EmailAdress);

Staff staff1 = new("Bahram","Azizov","bah-aziz");
Console.WriteLine(staff1.EmailAdress);

Helper.SendEmail(staff.EmailAdress,"Dərs cədvəli", "Müəllim, cədvəli dəyişdirməyin də day");

// Helper helper; // compile-time error - we can't declare a variable with static type

//When we firstly access a static member of a class, static constructor works. 
//NonStaticClass.HelloWorld(); // I'm worked + Using static CTOR : 1
//Or when we firstly create an instance of a class, static constuctor works.
NonStaticClass nonStaticClass = new(); // It also triggers non-static constructor's working :
//I'm worked + Using static CTOR : 1
//I'm worked + Using non-static CTOR : 1
NonStaticClass nonStaticClass1 = new(); //But now, only non-static constructor works due to the working principle of a static constructor
//I'm worked + Using non-static CTOR : 2