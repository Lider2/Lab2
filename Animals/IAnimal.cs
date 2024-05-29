using static lab2.Animal.Animal;

namespace lab2.Animal;

public interface IAnimal {
  public string Name { get; }

  public int Age { get; set; }

  public abstract AnimalType Type { get; }
}