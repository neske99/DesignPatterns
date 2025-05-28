namespace DP.LIB.Structural;

public class KetchupMealAddOn : MealDecorator
{
    public KetchupMealAddOn(IMeal meal) : base(meal)
    {
    }

    public override string ConsumeMeal()
    {
      return base._meal.ConsumeMeal() + "extra ketchup ";
    }
}
