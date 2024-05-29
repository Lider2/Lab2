namespace lab2.Animal;

public abstract class HomeAnimal : Animal
{
  private string _nickname = string.Empty;

  public string Nickname
  {
    get => Tamed ? _nickname : Name;
    set
    {
      _nickname = value;
    }
  }

  public bool Tamed { get; set; } = false;

  protected HomeAnimal(int age)
    : base(age)
  {
  }

  public void Free()
  {
    Tamed = false;
    Nickname = string.Empty;
  }

  public void Tame(string nickname)
  {
    Tamed = true;
    Nickname = nickname;
  }
}