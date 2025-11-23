public class Character
{
    protected string _name;

    public Character(string name)
    {
        _name = name;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{_name} attacks generically.");
    }

    public void Move(string from, string to)
    {
        Console.WriteLine($"{_name} moved to {to}");
    }
}