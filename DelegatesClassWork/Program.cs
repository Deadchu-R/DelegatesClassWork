using System;

LimitedObservableList list = new((s) => !s.StartsWith("s") && !s.StartsWith("S"));
//list.ListItemAdded += Print;
list.TryAdd("roee");
list.TryAdd("smile");
list.TryAdd("Etai");
list.TryAdd("Smack");
list.TryAdd("lol");
list.PrintAll();
class LimitedObservableList
{
    private List<string> _list = new();
    private Func<string, bool> _check;
    public Action ListItemAdded;

    public LimitedObservableList(Func<string , bool> predicate)
    {
        _check = predicate;
    }

    public bool TryAdd(string item) 
    {
        if (!_check(item))
        {
            return false;
        }



        _list.Add(item);
        ListItemAdded?.Invoke();
      
        return true;
    }

    public void PrintAll()
    {
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
            
    }

}