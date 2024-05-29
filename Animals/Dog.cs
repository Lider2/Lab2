namespace lab2.Animal;

public class Dog : HomeAnimal, IWalkingAnimal
{
  public override AnimalType Type { get; } = AnimalType.Omnivores;

  public int LegsCount { get; set; } = 4;

  public DogState State { get; private set; } = DogState.Standing;

  public Dog(int age)
    : base(age)
  {
  }

  public override void Voice()
  {
    MakeVoice("Woof");
  }

  public void ExecuteCommand(DogState state)
  {
    var commandString = ConvertStateToCommand(state);
    Console.WriteLine($"Master said: {commandString}");

    State = state;
  }

  public void PrintCurrentState()
  {
    var commandString = ConvertStateToString(State);
    Console.WriteLine(commandString);
  }

  private string ConvertStateToCommand(DogState state)
  {
    return state switch
    {
      DogState.Standing => "Стоять",
      DogState.Sitting => "Сидеть",
      DogState.Fetching => "Гнаться за мячиком",
      _ => "Неизвестное состояние"
    };
  }

  private string ConvertStateToString(DogState state)
  {
    return state switch
    {
      DogState.Standing => "Стоит",
      DogState.Sitting => "Сидит",
      DogState.Fetching => "Гонится",
      _ => "Неизвестное состояние"
    };
  }

  public enum DogState
  {
    Standing,
    Sitting,
    Fetching,
  };
}