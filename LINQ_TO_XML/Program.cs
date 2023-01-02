using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
namespace LINQ_TO_XML
{
    internal class Program
    {
        public static readonly string XmlPAth = @"C:\Users\acer\source\repos\CsharpLearning_Sprint1\LINQ_TO_XML\myXml.xml";
        
        
        static void Main(string[] args)
        {
            #region Basic Usage of LinqXml

            /* string XmlPAth = @"C:\Users\acer\source\repos\CsharpLearning_Sprint1\LINQ_TO_XML\myXml.xml";
             XDocument xDoc = new(
                 new XDeclaration("1.0", "UTF-8", "yes"),
                 new XElement("Database",
                     new XElement("Customer", new XAttribute("ID","1"),
                         new XElement("Name", "Mahammad"),
                         new XElement("Surname","Sadigzada"),
                         new XElement("Email","mehemmedsadigzade@gmail.com"),
                         new XElement("PhoneNumber","050-000-00-11")
                                 )
                             )
                 );
             xDoc.Save(XmlPAth);
            */
            #endregion
          
           
            #region Write data in list to .xml file
            List<Customer> GetRandomCustomers(int amount)
            {
                List<Customer> customers = new List<Customer>();
                for (int i = 0; i < amount; i++)
                {
                    Customer customer = new Customer();
                    customer.ID = Guid.NewGuid();
                    customer.Name = FakeData.NameData.GetFirstName();
                    customer.Surname = FakeData.NameData.GetSurname();
                    customer.Email = $"{customer.Name}.{customer.Surname}@{FakeData.NetworkData.GetDomain()}".ToLower();
                    customer.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                    customers.Add(customer);
                }
                return customers;
            }
            List<Customer> customers = GetRandomCustomers(50);



            //Creating .xml page

            XDocument xDoc = new(
                new XDeclaration("1.1", "utf-8", "yes"),
                new XElement("Database",
                new XElement("Customers", customers.Select(c =>
                    new XElement("Customer",
                        new XElement("ID", c.ID),
                        new XElement("Name", c.Name),
                        new XElement("Surname", c.Surname),
                        new XElement("Email", c.Email),
                        new XElement("PhoneNumber", c.PhoneNumber)

                                )
                            )
                )
                )
                );
            xDoc.Save(XmlPAth);



            #endregion

            #region Read data from .xml file
            XDocument ReadDoc = XDocument.Load(XmlPAth);
            List<XElement> elements = ReadDoc.Descendants("Customer").ToList();
            int count = 1;
            foreach(XElement item in elements)
            {
                Console.WriteLine($"Customer {count}");
                Console.WriteLine($"ID : {item.Element("ID").Value}");
                Console.WriteLine($"Name: {item.Element("Name").Value}");
                Console.WriteLine($"Surname: {item.Element("Surname").Value}");
                Console.WriteLine($"Phone Number: {item.Element("PhoneNumber").Value}");
                Console.WriteLine("***************************");
                count++;
            }
            
            #endregion
        }
        /* static void OpenXmlFile(string xmlPath)
         {
             Process.Start(new ProcessStartInfo { FileName = xmlPath,UseShellExecute = true });
         }
        */

    }
}