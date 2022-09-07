namespace ConsoleApp1;
public class Updated_List<T>
{
    private readonly List<T> _list = new();
    private readonly object _lock = new();

    
    public void Add(T item)
    {
        lock (_lock)
        {
            _list.Add(item);
        }
    }


    public void Remove(T item)
    {
        lock (_lock)
        {
            _list.Remove(item);
        }
    }
    
    
    public int Count()
    {
        lock (_lock)
        {
            return _list.Count();
        }
    }
    
    
    public void Clear()
    {
        lock (_lock)
        {
            _list.Clear();
        }
    }
    
    
    public T GetIntItem(int item)
    {
        lock (_lock)
        {
            return _list.Find(x => item == item);
        }
    }
    
    
    public T GetStringItem(string item)
    {
        lock (_lock)
        {
            return _list.Find(x => item == item);
        }
    }
}