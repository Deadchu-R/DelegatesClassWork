// ---- C# II (Dor Ben Dor) ----
//          Roee Tal
// -----------------------------
using System;

LimitedObservableList list = new LimitedObservableList(IsContainLetterS);



//list.ListItemAdded += Print;
list.TryAdd("roee");
list.TryAdd("smile");
list.TryAdd("stanly");
list.TryAdd("Etai");
list.TryAdd("Smack");
list.TryAdd("lol");
list.TryAdd("Zero");
list.TryAdd("IHateKremer");
list.TryAdd("DorBenDor");
list.TryAdd("IwantToDie");

list.PrintAll();

//list.PrintAll();

bool IsContainLetterS(string input)
{
    if (input.Contains("s") || input.Contains("S"))
    {
        return true;
    }
    else
    {
       return false;
    }
}

class LimitedObservableList
{
    
    private List<string> _list = new();
    private Func<string, bool> _check;
    public Action<string> ListChanged;

     
    public void PrintChangedObject(string item)
    {
        if (_list.Contains(item))
        { 
          Console.WriteLine($"{item} added");
        }
        else
        {
          Console.WriteLine($"{item} removed");
        }
    }

    public LimitedObservableList(Func<string , bool> predicate)
    {
        _check = predicate;
        ListChanged += PrintChangedObject;
    }

    public bool TryAdd(string item) 
    {
        if (!_check(item))
        {
            return false;
        }
        _list.Add(item);
        ListChanged?.Invoke(item);
      
        return true;
    }

    public void PrintAll()
    {
        Console.Write("List Contains [");
        foreach (var item in _list)
        {
            Console.Write($",{item}");
        }
        Console.Write("]");
    }

}