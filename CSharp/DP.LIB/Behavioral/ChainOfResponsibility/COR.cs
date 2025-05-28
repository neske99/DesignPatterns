namespace DT.LIB.Behavioral;

public enum RequestType
{
  StarPrint,
  AmpersendPrint
}

public interface ICORHandler
{
  void Handle(RequestType type,string body);
}

public abstract class CORHandler:ICORHandler
{
  public ICORHandler? _next{get;set;}
  protected RequestType _type;
  public CORHandler(RequestType rtype,ICORHandler? next=null)
  {
    _type =rtype;
    _next=next;
  }

    public void Handle(RequestType type, string body)
    {
      if(_type == type)
      {
        CustomHandle(body);
      }else{
        _next?.Handle(type,body);
      }
    }
    public abstract void CustomHandle(string body);
    


}

public class StarHandler : CORHandler
{
    public StarHandler( ICORHandler? next = null) : base(RequestType.StarPrint, next)
    {
    }

    public override void CustomHandle(string body)
    {
      Console.WriteLine("***"+body+"***");

    }
}

public class AmpersendHandler : CORHandler
{
    public AmpersendHandler ( ICORHandler? next = null) : base(RequestType.AmpersendPrint, next)
    {
    }

    public override void CustomHandle(string body)
    {
      Console.WriteLine("&&&"+body+"&&&");
    }
}
