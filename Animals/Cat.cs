namespace lab2.Animal;

public class Cat : HomeAnimal, IWalkingAnimal
{
  public override AnimalType Type { get; } = AnimalType.Omnivores;

  public int LegsCount { get; set; } = 4;

  public Cat(int age)
    : base(age)
  {
  }

  public override void Voice()
  {
    MakeVoice("Meow");
  }
}