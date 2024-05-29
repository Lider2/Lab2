namespace lab2.Animal;

public class Spider : Animal, IWalkingAnimal
{
  public override AnimalType Type { get; } = AnimalType.Сarnivorous;

  public int LegsCount { get; set; } = 8;

  public Spider(int age)
    : base(age)
  {
  }

  public void MakeWeb()
  {
    Console.WriteLine("Spider can make web on wall");
  }
}