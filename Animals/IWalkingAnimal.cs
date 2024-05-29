namespace lab2.Animal;

public interface IWalkingAnimal : IAnimal
{
  public int LegsCount { get; set; }

  public void Walk()
  {
    Console.WriteLine($"{Name} can walk by {LegsCount} legs");
  }
}