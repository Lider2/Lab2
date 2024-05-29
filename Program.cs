using lab2.Animal;

namespace lab2;

public class TestProgram
{
  private Cat cat;

  private Dog dog;

  private Heron heron;

  private Shark shark;

  private Spider spider;

  public void Start()
  {
    var homeCat = new Cat(3);
    homeCat.Tame("Снежок");

    var dog1 = new Dog(15);
    dog1.Tame("Шарик");

    var dog2 = new Dog(15);

    var animals = new AnimalsCollection([
      homeCat,
      cat = new Cat(5),
      dog = new Dog(8),
      dog1,
      dog2,
      heron = new Heron(12),
      shark = new Shark(7),
      spider = new Spider(1),
    ]);
    
    spider.MakeWeb();

    animals.PringAges();
    animals.PrintCountByName();

    foreach(var animal in animals)
    {
      Console.WriteLine($"\n--- {animal.Name} ---");

      if (animal is IWalkingAnimal)
      {
        (animal as IWalkingAnimal).Walk();
      }

      if (animal is IFlyingAnimal)
      {
        (animal as IFlyingAnimal).Fly();
      }

      if (animal is ISwimingAnimal)
      {
        (animal as ISwimingAnimal).Swim();
      }

      animal.Voice();
    }
  }
}

class Program
{
  static void Main(string[] args)
  {
    new TestProgram().Start();
  }
}