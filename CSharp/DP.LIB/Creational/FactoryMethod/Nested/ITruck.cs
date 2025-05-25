namespace DP.LIB.Creational;

public interface ITruck
{
  public static ITruck CreateTruck(TruckType truckType){ 
    if(truckType==TruckType.Mercedes  )
      return new MercedesTruck(); 
    return new BMWTruck();
  }
    
  public void ChuChu();
    
    private class MercedesTruck : ITruck
    {
      public void ChuChu()
      {
        Console.WriteLine( "Mercedes Truck goes Chu Chuy !!!!!!!!!!!");
      }
    }
    
    private class BMWTruck : ITruck
    {
      public void ChuChu()
      {
        Console.WriteLine( "BMW Truck goes Chu Chuy !!!!!!!!!!!");
      }
    }

}

public enum TruckType{
  BMW,
  Mercedes
}



