try
{
	//Some codes....
	throw new Exception("There is an unbelieveable error");
}
catch(Exception ex) when(ex.Message=="There is an unbelieveable error")
{
	Console.WriteLine(ex.Message);
}
catch (Exception ex)
{

	Console.WriteLine(ex.Message);
}