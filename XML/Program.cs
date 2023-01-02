using System.Diagnostics;
using System.Text;
using System.Xml;
string XmlPath = @"C:\Users\acer\source\repos\CsharpLearning_Sprint1\XML\MyXML.xml";

#region Write content to .xml file
void WriteToXml()
{
    XmlTextWriter writer = new(XmlPath, UTF8Encoding.UTF8);
    writer.WriteComment("Welcome to 'MyXML' file!");
    writer.WriteStartElement("Staffs");


    writer.WriteStartElement("Staff");
    writer.WriteAttributeString("ID", "1");
    writer.WriteElementString("Name", "Mahammad");
    writer.WriteElementString("Surname", "Sadigzada");
    writer.WriteElementString("Email", "mahammadsadigzada@gmail.com");
    writer.WriteEndElement();

    writer.WriteStartElement("Staff");
    writer.WriteAttributeString("ID", "2");
    writer.WriteElementString("Name", "Madin");
    writer.WriteElementString("Surname", "Gahramanov");
    writer.WriteElementString("Email", "madin@gmail.com");
    writer.WriteEndElement();

    writer.WriteEndElement();
    writer.Close();
}
#endregion
#region Read content from .xml file
void ReadFromXml()
{
    XmlTextReader reader = new(XmlPath);
    while (reader.Read())
    {
        Console.WriteLine($"{reader.LocalName.ToString()} - {reader.Value.ToString()}");
    }
}
ReadFromXml();

 
#endregion
openXmlFile(XmlPath);




void openXmlFile(string path){

    Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });

}