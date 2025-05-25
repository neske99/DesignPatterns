namespace DP.LIB.Creational;

public interface IBuildPerson
{
  public Person BuildPerson();
}

public interface ISpecifyAge
{
  public IBuildPerson SpecifyAge(int age);
}

public interface ISpecifyName 
{
  public ISpecifyAge SpecityName(string name );
}

public interface IPersonBuilderResult: IBuildPerson,ISpecifyAge, ISpecifyName 
{
}
