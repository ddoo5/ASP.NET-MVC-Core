using ConsoleApp1;



for(int i = 0; i < 20; i++) //micropool
{
    ThreadPool.QueueUserWorkItem(new WaitCallback(SomeLogicClass.SomeLogicMethod));
}

Thread.Sleep(200);


Console.WriteLine($"\n Count: {ThreadPool.ThreadCount}");
Console.WriteLine($"\n Complete: {ThreadPool.CompletedWorkItemCount}");
Console.WriteLine($"\n Pending: {ThreadPool.PendingWorkItemCount}");

Console.ReadKey();