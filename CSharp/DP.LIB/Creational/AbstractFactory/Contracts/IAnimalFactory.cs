namespace DP.LIB.Creational;

public interface IAnimalFactory
{
  public ICat CreateCat();
  public ISnake CreateSnake();

  public static IAnimalFactory CreateBalkanAnimalFactory()
  {
    return new BalkanAnimalFactory();
  }

  public static IAnimalFactory CreateEqyptAnimalFactory()
  {
    return new EqyptAnimalFactory();
  }

}
