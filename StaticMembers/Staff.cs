using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class Staff
    {
        private static string domain = "ldu.edu.az";
        public string Name { get; set; }
        public string Surname { get; set; }

        private string emailAdress;
        public Staff()
        {

        }
        public Staff(string name, string surname, string emailAdress)
        {
            Name = name;
            Surname = surname;
            EmailAdress = emailAdress;
        }
        public string EmailAdress {
            get { return emailAdress;}
            set
            {
                emailAdress = value.ToLower() + "@" + domain;
            }
        }
    }
}
