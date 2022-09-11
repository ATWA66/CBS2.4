XMLHandler XML = new XMLHandler();
TXTHandler TXT = new TXTHandler();
DOCHandler DOC = new DOCHandler();
XML.Create();
TXT.Create();
DOC.Create();
abstract class AbstractHandler {
    public void Open() { }
    public void Create() { }
    public void Change() { }
    public void Save() { }
}
class XMLHandler : AbstractHandler
{
    public void open() {
        Console.WriteLine("open in XML");
    }
    public void Create()
    {
        Console.WriteLine("Create in XML");
    }
    public void Change()
    {
        Console.WriteLine("Change in XML");
    }
    public void Save()
    {
        Console.WriteLine("Save in XML");
    }
}
class TXTHandler : AbstractHandler
{
    public void open()
    {
        Console.WriteLine("open in TXT");
    }
    public void Create()
    {
        Console.WriteLine("Create in TXT");
    }
    public void Change()
    {
        Console.WriteLine("Change in TXT");
    }
    public void Save()
    {
        Console.WriteLine("Save in TXT");
    }
}
class DOCHandler : AbstractHandler
{
    public void open()
    {
        Console.WriteLine("open in DOC");
    }
    public void Create()
    {
        Console.WriteLine("Create in DOC");
    }
    public void Change()
    {
        Console.WriteLine("Change in DOC");
    }
    public void Save()
    {
        Console.WriteLine("Save in DOC");
    }
}