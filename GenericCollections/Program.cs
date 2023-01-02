List<int> numbers = new List<int>();
#region AddRange method

numbers.AddRange(new int[] {5,4,8,8});
foreach (var item in numbers)
{
    Console.WriteLine(item);

}
#endregion
#region ForEach method
numbers.ForEach(number => Console.WriteLine(++number));
#endregion

#region Insert method
numbers.Insert(2, 17);
numbers.ForEach(number => Console.WriteLine(number)); // 5 4 17 8 8 
#endregion
#region Any method
Console.WriteLine(numbers.Any()); //Check whether an element exist in this list -- true
Console.WriteLine(numbers.Any(number => number%2==0 )); // If any element meets the given condition, method returns true
#endregion
#region Max method
Console.WriteLine("This is the largest number of list : {0}", numbers.Max()); //It finds the the largest element inside list
#endregion
#region Min method
Console.WriteLine("This is the smallest number of this list : {0}", numbers.Min());//It finds the the smallest element inside list
#endregion
#region Sum method
Console.WriteLine("Total summary of all elements : {0}",numbers.Sum()); // It sum up all elements together
#endregion
#region Remove method and its variations
numbers.Remove(5); //This method removes the first of given parameter in the 'numbers' list
numbers.RemoveAll(number => number==8); // This method removes all elements which match the given condition
numbers.RemoveAt(1); //This method removes an element by its index which is given as argument
numbers.Clear(); //This method removes all elements from the list
#endregion