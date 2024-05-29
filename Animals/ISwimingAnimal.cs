namespace lab2.Animal;

public interface ISwimingAnimal : IAnimal
{
  public void Swim()
  {
    Console.WriteLine($"{Name} can swim");
  }
}