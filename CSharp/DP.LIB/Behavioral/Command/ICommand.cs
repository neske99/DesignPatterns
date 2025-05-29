namespace DP.LIB.Behavioral;

public interface ICommand
{
  void Execute();
}

public interface IReversableCommand: ICommand
{
  void Reverse();
}

public class Printer
{
  public void PrintWithStar()
  {
    Console.WriteLine("***unanan***");
  }
}

public class PrintCommand:ICommand
{
  private Printer _p;
  PrintCommand(Printer p)
  {
    _p=p;
  }

   public void Execute()
  {
    _p.PrintWithStar();
  }
}


