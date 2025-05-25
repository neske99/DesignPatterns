namespace DP.LIB.Creational;

public abstract class Car
{
  public abstract void Go();
  public static Car? CreateCar(CarType carType){ 
    if(carType  == CarType.BMW)
      return new BMW();   
    if(carType== CarType.Mercedes)
      return new Mercedes();
     
    return null;
  }

}
  public enum CarType {
    BMW,
    Mercedes
  }

    

