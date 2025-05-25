namespace DP.LIB.Creational;


public abstract class Plane
{
  public abstract void Go();
   public static IPlainFactory  Factory {get; }
   = new PlaneFactory();
    
private class PlaneFactory: IPlainFactory
  {

    public Plane CreatePlain(PlaneType planeType){
       if(planeType==PlaneType.BMW) 
         return new BMWPlane();  
       return new MercedesPlane();
    }
  }
  
private class BMWPlane : Plane
{
  public BMWPlane()
  {
      
  }
    public override void Go()
    {
      Console.WriteLine("BMWPlane goes chu chyu!");
    }
}
private class MercedesPlane : Plane
{
    public override void Go()
    {
      Console.WriteLine("MercedesPlane goes chu chyu!");
    }
}
}

public interface IPlainFactory{
    public Plane CreatePlain(PlaneType planeType);
}

public enum PlaneType{
  BMW,
  Mercedes  
}

 

  
