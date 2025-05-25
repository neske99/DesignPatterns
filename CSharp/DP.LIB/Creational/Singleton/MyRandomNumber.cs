namespace DP.LIB.Creational;
    
public sealed class MyRandomNumber
{
  private static Lazy<MyRandomNumber> myNumber= new Lazy<MyRandomNumber>(()=>new MyRandomNumber());

  public static MyRandomNumber Instance()
  { 
    return myNumber.Value;
  }

  private MyRandomNumber(){}

  private int myNum=7;
  public void DoStuff(){
    Console.WriteLine("My lucky  number is : "+myNum.ToString());
  }
}
