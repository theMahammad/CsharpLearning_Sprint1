//Directory operations
#region Create a directory

//CreateNewFolder("C:\\MyDirectory");
void CreateNewFolder(string path)
{
    Directory.CreateDirectory(path); //If there is no folder like this, this method creates it
}
#endregion
#region Checking existence of a directory
bool directoryControl = Directory.Exists("C:\\MyDirectory"); ///true

#endregion
#region  Delete a directory
DeleteEmptyDirectory("C:\\MyDirectory");
void DeleteEmptyDirectory(string path)
{
   if(Directory.Exists(path))
    Directory.Delete(path);
}
DeleteFullDirectory("C:\\Customer"); 
void DeleteFullDirectory(string path)
{
    if (Directory.Exists(path))
        Directory.Delete(path, true); //If there are any subdirectories,files in directory, we must use this overload of Delete method
                                     // thanks to 'true', we can delete all things inside directory
}
#endregion


#region Moving a directory to a new location

void MoveDirectory(string currentPath, string newPath)
{
    Directory.Move(currentPath, newPath);
}
string currentPath = @"C:\MyBlog";
string newPath = @"C:\LoveBombing\Myblog";
MoveDirectory(currentPath, newPath);
#endregion
//Practice
//Create a directory in disk 'C'. If it already exists in 'C', delete it and create a new one

void Practice()
{
    string path = "C:\\LoveBombing";
    if (Directory.Exists(path))
    {
        Directory.Delete(path, true);
        Console.WriteLine("Existed directory has been deleted");
        Directory.CreateDirectory(path);
        Console.WriteLine("The directory has been created");
    }
    else
    {
        Directory.CreateDirectory(path);
        Console.WriteLine("The directory has been created");
    }
}






