var pig = new Pig();
var foodType = FoodType.CatFood;
var pigEat = FoodType.PigFood;
var cat = new Cat();

pig.Feed(2,foodType);

public class Anymals
{
    protected double Satiety { get; set; }
    public virtual void Feed(int count)
    {
        Satiety += count;
        Console.WriteLine("Om-nom-nom");
    }
    public virtual void Feed(int count, FoodType foodType)
    {
        if (foodType != FoodType.CatFood)
        {
            Console.WriteLine("Meow, I dont eat this!");

            return;
        }

        Satiety += count;
        Console.WriteLine("Om-nom-nom");
    }
}
public class Cat:Anymals
{
    public string Name { get; set; }

    public  void Feed(int count,FoodType foodType)
    {
        if (foodType != FoodType.CatFood)
        {
            Console.WriteLine("Meow, I dont eat this!");

            return;
        }

        Satiety += count;
        Console.WriteLine("Om-nom-nom");
    }

    public void SayHelloToCat()
    {
        Console.WriteLine($"Hello, {Name}");
    }
}

internal class FoodTypeAttribute : Attribute
{
}

public class Pig:Anymals
{
    public int Age { get; set; }
    public override void  Feed(int count, FoodType foodType)
    {
        Feed(count);
    }
    public virtual void Feed(int count)
    {
        Satiety += count;
        Console.WriteLine("Om-nom-nom");
    }



}

public enum FoodType
{
    PigFood,
    CatFood,
    Other
}