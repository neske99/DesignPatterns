namespace DP.LIB.Creational;


public class EqyptAnimalFactory : IAnimalFactory
{
    public ICat CreateCat()
    {
      return new Lion();
    }

    public ISnake CreateSnake()
    {
      return new Cobra();
    }
}
