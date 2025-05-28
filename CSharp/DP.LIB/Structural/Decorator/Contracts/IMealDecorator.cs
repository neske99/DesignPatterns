namespace DP.LIB.Structural;

public abstract class MealDecorator : IMeal
{
    protected readonly IMeal _meal;

    protected MealDecorator(IMeal meal)
    {
        _meal = meal ?? throw new ArgumentNullException(nameof(meal));
    }

    public abstract string ConsumeMeal();
    
}
