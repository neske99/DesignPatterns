namespace DP.LIB.Creational;

public class Person
{
  public int Age { get; set; }
  public string Name{ get; set; }

  private Person()
  {
  }
   
  public static IPersonBuilder Builder= new PersonBuilder();

  private class PersonBuilder : IPersonBuilder
  {
   private IPersonBuilderResult _personBuilderResult;
  
   public PersonBuilder()
   {
     _personBuilderResult = new Person.PersonBuilderResult() ;
   }

   public ISpecifyName CreatePerson(){
     return _personBuilderResult;
   }
  }

  public class PersonBuilderResult : IPersonBuilderResult
  {
    private Person _person;

    public PersonBuilderResult()
    {
        _person= new Person();
    }

    public Person BuildPerson()
    {
      return _person;
    }

    public IBuildPerson SpecifyAge(int age)
    {
      _person.Age=age;
      return this;
    }

    public ISpecifyAge SpecityName(string name)
    {
      _person.Name=name;
      return this;
    }
  }
}

public interface IPersonBuilder
{
   public ISpecifyName CreatePerson();
}






