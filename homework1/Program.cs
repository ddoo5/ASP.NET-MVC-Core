using ConsoleApp1;


//add items
Updated_List<int> list1 = new();
Updated_List<string> list2 = new();

//threads init
Thread thread1 = new(() => list1.Add(1));
Thread thread2 = new(() => list2.Add("lorem"));
Thread thread3 = new(() => list1.Add(2));
Thread thread4 = new(() => list1.Add(3));
Thread thread5 = new(() => list1.Remove(3));
Thread thread6 = new(() => list2.Add("some text"));
Thread thread7 = new(() => list2.GetStringItem("some text"));
Thread thread8 = new(() => list1.GetIntItem(2));

//like some logics
thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();
thread5.Start();
thread6.Start();
thread7.Start();
thread8.Start();

Console.WriteLine($"Count in list1 with items: {list1.Count()}");
Console.WriteLine($"Count in list2 with items: {list2.Count()}");

list1.Clear();
list2.Clear();

Console.WriteLine($"Count in list1 without items: {list1.Count()}");
Console.WriteLine($"Count in list2 without items: {list2.Count()}");

Console.ReadKey();