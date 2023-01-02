using Json;
string path = @"C:\Users\acer\source\repos\CsharpLearning_Sprint1\Json\myJson.json";

#region Json data writing
List<Staff> staffs = DataHelper.GetStaffs(10);


string JsonString = Newtonsoft.Json.JsonConvert.SerializeObject(staffs);

File.WriteAllText(path,JsonString);
Console.WriteLine("The writing operation has been completed succesfully");
#endregion
#region Json data reading
string JsonReaded = File.ReadAllText(path);
List<XObject> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(JsonReaded);
foreach(var obj in Data)
{
    Console.WriteLine($"{obj.Name} {obj.Surname} {obj.Email}");
}
#endregion