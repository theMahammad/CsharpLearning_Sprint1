using Exceptions;

void Seperate()
{
	Console.WriteLine("*******************************************");
}
void GetException()
{
	int number = int.Parse("a");
}
//GetException();
#region Example usage of try-catch
void UsingTryCatch()
{
	try
	{
		int number = int.Parse("a");
	}
	catch (Exception ex)
	{

		Console.WriteLine(ex.Message);
        //Despite getting run time error, program doesn't stop. It writes "Input string was not in a correct format." to console.
    }
}
UsingTryCatch();
#endregion
Seperate();
#region Example usage of multiple catches
void UsingMultipleCatch()
{
	try
	{
		int a = int.Parse("a");
	}
	catch(FormatException fex)
	{
		Console.WriteLine("You try to parse non-number symbol");
		Console.WriteLine(fex.Message);
	}
	catch (Exception ex) //Exception is a base class. If the thrown exception cannot be caught by any exception above, it is caught by "Exception" class eventually
	{ //Due to this fact that, if we write any catch method after this block, we'll encounter with compile-time error. 
		Console.WriteLine("There is an undefined error");
		Console.WriteLine(ex.Message);
	}
	/*catch(SystemException ex) // error message : A previous catch clause already catches all exceptions of this or of a super type ('Exception')
    {

	}*/
}
UsingMultipleCatch();
#endregion
Seperate();
#region Example usage of "finally"
//Finally block runs always regardless of existing an exception.
void UsingFinally()
{ 
	
	try
	{
		DatabaseConnection.Open();
		int a = int.Parse("a");
		DatabaseConnection.Close();	//We can't close here, because program runs catch block after encounter with an error
	}
	catch(Exception ex)
	{
		Console.WriteLine(ex.Message);
		
	}
	finally
	{
		DatabaseConnection.Close();
        //If we open database connection, whether there is an error or not, we have to close it.
    }
}
UsingFinally();
#endregion
Seperate();
#region Custom exception classes
void CustomException(){
	try
	{
		int number = 14;
		if (number >10)
		{
			throw new MyException(); // We've thrown a custom error, and it'll be handled by its exception class
		}
	}catch(MyException ex)
	{
		Console.WriteLine(ex.Message);
	}catch(Exception ex)
	{

	}
	
}
CustomException();
#endregion