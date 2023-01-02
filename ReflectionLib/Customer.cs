namespace ReflectionLib
{
    public class Customer
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public Customer(Guid id,string name,string surname,string email)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Email = email;
        }
        public Customer(string name,string surname)
        {
            Name = name;
            Surname = surname;

        }
        public Customer(string name,string surname,string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }
        public void PrintToScreen()
        {
            Console.WriteLine($"{ID}");
        }
        public void UpdateID(Guid id)
        {
            ID = id;
        }

    }
}