//FileOperations

#region Create a new file
void CreateFile(string path)
{
    FileStream fs = File.Create(path);
    fs.Close(); //If we doesn't close the stream, we can't directly access this file from pc 
}
string path = @"C:\LoveBombing\Myblog\salam.txt";
//CreateFile(path);
#endregion
#region  Checking existence of a file
bool fileControl = File.Exists(path);
Console.WriteLine(fileControl); //True
#endregion
#region Delete a file
void DeleteFile(string path)
{
    if (File.Exists(path))
    {
        File.Delete(path);
        
    }
    
}
DeleteFile("C:\\Users\\acer\\OneDrive\\Masaüstü\\aue.txt");
#endregion
#region Copy a file
void CopyFile(string originalPath,string copiedPath)
{
    File.Copy(originalPath,copiedPath,true); //If second path already exists, with 'true' value, we can overwrite it
}
//CopyFile(@"C:\LoveBombing\MyBlog\salam.txt", @"C:\LoveBombing\Aue\salam.txt");
#endregion

#region  Append text
void Append(string path,string text)
{
    File.AppendAllText(path,text);
    
}
string appendPath = @"C:\LoveBombing\MYblog\salam.txt";
string appendText = "Salamlar olsun Lənkəran əhlinə";
Append(appendPath, appendText);
#endregion
#region Read the content
string Read(string path)
{
    string text = File.ReadAllText(path);
    return text;
}
string text = Read(@"C:\Lovebombing\myblog\salam.txt");
Console.WriteLine("The content of 'salam.txt' : \n{0}",text);

#endregion
