public class Entrepeneur : Character
{
    public Entrepeneur() : base("Steve")
    {

    }

    public override void Attack()
    {
        Console.WriteLine($"{_name} throws money at people $$");
    }
}