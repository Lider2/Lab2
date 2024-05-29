namespace lab2.Animal;

public class Heron: Animal, IWalkingAnimal, IFlyingAnimal
{
  public override AnimalType Type { get; } = AnimalType.Omnivores;

  public int LegsCount { get; set; } = 2;

  public int WingsCount { get; set; } = 2;

  public Heron(int age)
    : base(age)
  {
  }
}