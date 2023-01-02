using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    public class Student
    {
        public Guid ID { get; set; }
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Student(Guid id,int studentNumber)
        {
            ID = id;
            StudentNumber = studentNumber;  
        }
        public Student(Guid id, int studentNumber, string name, string surname, string email) : this(id,studentNumber)
        {
            
            Name = name;
            Surname = surname;
            Email = email;
        }
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Student(string name,string surname, string email):this(name,surname)
        {
            
            Email = email;
        }
        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
        public void UpdateStudentNumber(int studentNumber)
        {
            StudentNumber = studentNumber;
        }
        public void UpdateDomain(string domain)
        {
            Email = Email.Split('@')[0] + domain;
        }
    }
}
