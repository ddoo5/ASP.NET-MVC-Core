namespace ConsoleApp1;

public class SomeLibrary
{
    public void WriteData(byte[] text)   //write in log text data
    {
        string path = Directory.GetCurrentDirectory() + "/something.log";
        
        if (!File.Exists(path))
            new Thread(() => File.Create(path));
        
        using (FileStream fs = new(path, FileMode.Append))
        {
            fs.Write(text, 0, text.Length);
        }
    }
}