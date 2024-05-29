namespace lab2.Animal;

public class AnimalsCollection : List<Animal>
{
  public AnimalsCollection()
    : base()
  {
  }

  public AnimalsCollection(IEnumerable<Animal> collection)
    : base(collection)
  {
  }

  public int CalcAgesSum()
  {
    return this.Aggregate(0, (acc, animal) => acc + animal.Age);
  }

  public void PringAges()
  {
    var ages = this.Select((animal) => animal.Age);

    Console.WriteLine(String.Join(", ", ages));
  }

  public void PrintCountByName()
  {
    this
      .GroupBy((animal) => animal.Name)
      .Select((group) => new {
        name = group.Key,
        count = group.Count(),
      })
      .ToList()
      .ForEach((item) => Console.WriteLine($"{item.name}: {item.count}"));
  }
}