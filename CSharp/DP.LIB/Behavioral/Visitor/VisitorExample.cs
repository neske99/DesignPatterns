namespace DP.LIB.Behavioral;


public interface IVisitor
{
  public void Visit(Pivo p);
}

public interface IAcceptVisitor
{
  public void Accept(IVisitor visitor);

}

public class PrintVisitor : IVisitor
{
    public void Visit(Pivo p)
    {
      Console.WriteLine(p.Name +"  " + p.Kolicina+ "!!!");
    }
}

public class Pivo:IAcceptVisitor
{
  public string Name{get;set;}
  public string Kolicina{get;set;}

  public Pivo (string name,string kolicina) 
  {
    Name= name;
    Kolicina=kolicina;  
  }

    public void Accept(IVisitor visitor)
    {
      visitor.Visit(this);
    }
}
