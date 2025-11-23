class Program
{
    static void Main(string[] args)
    {
        List<Character> players = new List<Character>();

        Character bob = new Character("Bob");
        // bob.Attack();
        players.Add(bob);

        Magician larry = new Magician("Larry");
        // larry.Attack();
        players.Add(larry);

        Entrepeneur steve = new Entrepeneur();
        // steve.Attack();
        players.Add(steve);

        Movement mover = new Movement();

        foreach (Character c in players)
        {
            c.Attack();
            mover.MoveCharacter(c, "Rexburg", "Idaho Falls");
        }

        
    }
}
