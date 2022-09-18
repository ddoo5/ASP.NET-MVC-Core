using System.Diagnostics;
using ConsoleApp1;

//немного непонятно в методичке указана задача, но, вроде, реализовал правильно

LoadData data = new();
SomeLibrary someLibrary = new();

byte[] load = data.DisplayData("");
byte[] res = data.GetFile("").Result;
    
someLibrary.WriteData(res);
someLibrary.WriteData(load);

Console.ReadKey();