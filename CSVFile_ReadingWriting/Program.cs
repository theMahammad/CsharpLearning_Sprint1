using CSVFile_ReadingWriting;

List<Customer> customers = DataHelper.GetCustomers(15);
StreamWriter SW = new(@"C:\Users\acer\source\repos\CsharpLearning_Sprint1\CSVFile_ReadingWriting\myCSV.csv");
CsvHelper.CsvWriter cWriter = new CsvHelper.CsvWriter(SW,System.Globalization.CultureInfo.InvariantCulture);
customers.ForEach(c => cWriter.WriteRecord(c));
SW.Close();
