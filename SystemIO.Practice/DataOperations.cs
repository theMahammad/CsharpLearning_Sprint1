using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SystemIO.Practice
{
    public static  class DataOperations
    {

        public readonly static string saveLocation = @"C:\SysIOPractice";
        static int id = 0;
        public static List<Staff> CallStaffs(int amount)
        {
            
            List<Staff> staffList = new List<Staff>();
            for(int i = 0; i < amount; i++)
            {

                Staff staff = new Staff()
                {
                    Id = ++id,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Country = FakeData.PlaceData.GetCountry()
                    
                };
                staff.Email = $"{staff.Name}.{staff.Surname}@gmail.com";
                staffList.Add(staff);
            }
            return staffList;
        }
       public static void SaveStaff(List<Staff> staffList)
        {
            #region Making Folders by  Countries
            HashSet<string> countries = new HashSet<string>();

            foreach (var item in staffList)
            {
                Staff staff = item as Staff;
                countries.Add(staff.Country);

            }
            MakeDirectoriesByCountry(countries);
            #endregion

            #region Creating .txt file about staffs inside the country folder
            foreach(Staff staff in staffList)
            {
                string staffInfo = $"Id : {staff.Id}\nName : {staff.Name}\nSurname : {staff.Surname}\n" +
                    $"Email : {staff.Email}\nCountry : {staff.Country}";
                string pathForstaff = $@"{saveLocation}\{staff.Country}\{staff.Name}.{staff.Surname}.txt";
                if (!File.Exists(pathForstaff))
                {
                    File.Create(pathForstaff).Close();
                    File.AppendAllText(pathForstaff, staffInfo);
                }
                
            }
            #endregion
        }


        static void MakeDirectoriesByCountry(HashSet<string> countries)
        {
            foreach (string country in countries)
            {
                string pathForCountry = $@"{saveLocation}\{country}";
                if (!Directory.Exists(pathForCountry))
                {

                    Directory.CreateDirectory(pathForCountry);
                }


            }
        }
    }
}
