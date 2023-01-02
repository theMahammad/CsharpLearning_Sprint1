using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile_ReadingWriting
{
    public static class DataHelper
    {
        private static List<Customer> data = new();

        static DataHelper()
        {
            data = new List<Customer>();
        }
        public static List<Customer> GetCustomers(int amount)
        {
            for(int i = 1; i <= amount; i++)
            {
                Customer temp = new();
                temp.ID = i.ToString();
                temp.Name = FakeData.NameData.GetFirstName();
                temp.Surname = FakeData.NameData.GetSurname();
                data.Add(temp);
            }
            return data;
        }
    }
}
