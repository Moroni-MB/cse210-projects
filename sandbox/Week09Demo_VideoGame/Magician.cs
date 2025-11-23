public class Magician : Character
{
    public Magician(string name) : base(name)
    {

    }

    public override void Attack()
    {
        Console.WriteLine($"{_name} casts fire down from the sky!!!");
    }
}