namespace lab2.Animal;

public interface IFlyingAnimal : IAnimal
{
  public int WingsCount { get; set; }

  public void Fly()
  {
    if (WingsCount <= 1) {
      Console.WriteLine($"{Name} can't fly on 1 wing");
      return;
    }

    Console.WriteLine($"{Name} can fly by {WingsCount} wings");
  }
}