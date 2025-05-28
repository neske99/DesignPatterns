namespace DP.LIB.Behavioral;

public class Memento
{
  public string contxt;
  public Memento(string x=""){
    contxt=x; 
  }
}

public class Context
{
  private string context;
  public Context(string ct="")
  {
    context= ct;
  }

  public Memento GetMemento()
  {
    return new Memento(context);
  }
  public void UpdateState(Memento m)
  {
    context = m.contxt;
  }
  public void DoSomething()
  { 
    Console.WriteLine("!!!"+context);
  }
}
