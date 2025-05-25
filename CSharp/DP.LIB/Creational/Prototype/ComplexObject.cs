using System.Text.Json;

namespace DP.LIB.Creational;

interface IClonabilno<T>
{
  public T Clone();
}

public class ComplexObject:IClonabilno<ComplexObject>
{
  public List<int> Prices { get; set; }=new List<int>();
  public List<string> Names { get; set; }=new List<string>();
  public List<int> Quantities { get; set; }=new List<int>();

    public ComplexObject Clone()
    {
      string json=JsonSerializer.Serialize( this);
      return JsonSerializer.Deserialize<ComplexObject>(json);
    }

    public int GetCheckoutPrice(){
    int result=0;
    for(int i=0;i<Prices.Count();i++){
      result += Prices[i]*Quantities[i];
    }
    return result;
  }

    public void Show(){
      string toShow="";
      for(int i=0;i<Prices.Count();i++){
        toShow += Names[i]+ ":" + Prices[i].ToString()+"*" + Quantities[i].ToString()+"\n";
      }
      toShow+=  "Total Price: "+GetCheckoutPrice().ToString();  
      Console.WriteLine(toShow);
    }
    
}
