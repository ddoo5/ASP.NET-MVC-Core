var thread = new Thread(SomeLogics);
thread.Start();
Thread.Sleep(400);
thread.Interrupt();
Console.ReadLine(); //exception here: "System.Threading.ThreadInterruptedException: Thread was interrupted from a waiting state..."



void SomeLogics()
{
    int a = 0;
    while (true)
    {
        Console.WriteLine(a);
        
        Thread.Sleep(100);

        a++;
    }       
}