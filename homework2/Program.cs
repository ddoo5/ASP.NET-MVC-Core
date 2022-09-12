using ConsoleApp1;



for(int i = 0; i < 20; i++) //micropool
{
    //ThreadPool.SetMinThreads(23, 23);     it's just for test
    ThreadPool.SetMaxThreads(30, 30);
    
    ThreadPool.QueueUserWorkItem(new WaitCallback(SomeLogicClass.SomeLogicMethod));
}

Thread.Sleep(200);

if (ThreadPool.ThreadCount > 20)    //i haven't found better place for check count of threads than here 
{
    throw new Exception("hey its more than 20");
}

Console.WriteLine($"\n Count: {ThreadPool.ThreadCount}");
Console.WriteLine($"\n Complete: {ThreadPool.CompletedWorkItemCount}");
Console.WriteLine($"\n Pending: {ThreadPool.PendingWorkItemCount}");

Console.ReadKey();