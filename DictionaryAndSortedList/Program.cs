//Dictionaries
#region Declaring a dictionary
Dictionary<int, string> dict = new Dictionary<int,string>(); // int - the type of key | string - the type of value
#endregion
#region Add method
dict.Add(1, "Mahammad");
dict.Add(2, "Kubra");
//dict.Add(2, "Sadigzada"); // runtime error - We cannot add a value with being already added key
#endregion
#region Remove method
dict.Remove(1); //This method removes the element whose key is 1
#endregion
#region Get value with using key
string value = dict[2]; // It returns the value of the row whose key is 2
Console.WriteLine(value);
//string value2 = dict[1]; // runtime error - The dictionary 'dict' doesn't contain an element whose key is 1
if (dict.ContainsKey(1)) // We can prevent runtime error with checking whether the dictionary contains or not this key
{
    string value2 = dict[1];
}
#endregion
dict.Add(1, "Mahammad");
#region Iterating a dictionary
foreach(KeyValuePair<int,string> item in dict)
{
    Console.WriteLine($"Key : {item.Key} | Value: {item.Value} ");
}
Console.WriteLine("****************");
foreach(var key in dict.Keys)
{
    Console.WriteLine($"Key : {key} || Value : {dict[key]}");
}
#endregion
dict.Clear();
Console.WriteLine("***********************");
//SortedList -- it is almost the same with the dictionaries. But it sorts its key with ascending order
SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(4, "Bmu");
sortedList.Add(2, "Ldu");
sortedList.Add(3, "WSB");
foreach(KeyValuePair<int,string> item in sortedList)
{
    Console.WriteLine($"Key : {item.Key} || Value : {item.Value}");
}
