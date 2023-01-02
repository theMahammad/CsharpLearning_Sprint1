using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public static class DataHelper
    {
        private static List<Staff> staffs = new();
        internal static List<Staff> GetStaffs(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Staff staff = new();
                staff.Id = Guid.NewGuid();
                staff.Name = FakeData.NameData.GetFirstName();
                staff.Surname = FakeData.NameData.GetSurname();
                staff.Email = $"{staff.Name}.{staff.Surname}@gmail.com".ToLower();
                staff.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                staff.Country = FakeData.PlaceData.GetCountry();
                staffs.Add(staff);
            }
            return staffs;
        }
    }
}
