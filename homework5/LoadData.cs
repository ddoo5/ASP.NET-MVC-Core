using System.Text;

namespace ConsoleApp1;

public class LoadData
{
    private static Mutex waiter = new();
    
    
    public async Task<byte[]> GetFile(string result)   //take data from some file
    {
        string path = "/Users/mac/Desktop/test.txt";

        if (!File.Exists(path))
            throw new FileNotFoundException($"check yor path: {path}");

        using (StreamReader streamReader = new StreamReader(path))
        {
            result = await streamReader.ReadToEndAsync();
        }
        
        byte[] bt = new UTF8Encoding(true).GetBytes(result);
        
        return bt;
    }
    
    private List<int> GenerateData()   //cpu or ram load generator (like true)
    {
        waiter.WaitOne();
        
        int lowLoad; 
        int middleLoad;
        int highLoad;
        List<int> dataArray = new();

        for (int i = 0; i < 20; i++)
        {
            highLoad = new Random().Next(70,100);
            dataArray.Add(highLoad);
        }
        
        for (int i = 0; i < 5; i++)
        {
            middleLoad = new Random().Next(30,70);
            dataArray.Add(middleLoad);
        }
        
        for (int i = 0; i < 5; i++)
        {
            lowLoad = new Random().Next(0,30);
            dataArray.Add(lowLoad);
        }
        
        for (int i = 0; i < 10; i++)
        {
            middleLoad = new Random().Next(30,70);
            dataArray.Add(middleLoad);
        }
        
        for (int i = 0; i < 60; i++)
        {
            lowLoad = new Random().Next(0,30);
            dataArray.Add(lowLoad);
        }
        
        waiter.ReleaseMutex();
        return dataArray;
    }

    
    public byte[] DisplayData(string text)  //converter for cpu data
    {
        List<int> array = new (GenerateData());   //cpu
        List<int> array2  = new (GenerateData());  //ram
        
        if (array == null) 
            throw new ArgumentNullException(nameof(array));
        if (array2 == null) 
            throw new ArgumentNullException(nameof(array2));

        for (int i = 0; i < 100; i++)
        {
            text += $"{DateTime.Now} | CPU Load | {array[i]}\n";
            text += $"{DateTime.Now} | RAM Load | {array2[i]}\n";
        }

        byte[] bt = new UTF8Encoding(true).GetBytes(text);
        
        return bt;
    }
}