namespace lab2.Animal;

public abstract class Animal : IAnimal
{
  public string Name { get => GetType().Name; }

  public int Age { get; set; }

  public abstract AnimalType Type { get; }

  public Animal(int age)
  {
    Age = age;
  }

  public virtual void Voice()
  {
    MakeVoice($"{Name} can't make voice");
  }

  protected void MakeVoice(string voiceLine)
  {
    Console.WriteLine(voiceLine);
  }

  public enum AnimalType
  {
    Сarnivorous,
    Herbivorous,
    Omnivores,
  };
}