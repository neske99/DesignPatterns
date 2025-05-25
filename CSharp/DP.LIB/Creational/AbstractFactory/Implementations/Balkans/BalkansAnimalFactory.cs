namespace DP.LIB.Creational;

public class BalkanAnimalFactory : IAnimalFactory
{
    public ICat CreateCat()
    {
      return new MountainLion();
    }

    public ISnake CreateSnake()
    {
      return new RattleSnake();
    }
}
