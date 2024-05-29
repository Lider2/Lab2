namespace lab2.Animal;

public class Shark: Animal, ISwimingAnimal
{
  public override AnimalType Type { get; } = AnimalType.Сarnivorous;

  public Shark(int age)
    : base(age)
  {
  }
}