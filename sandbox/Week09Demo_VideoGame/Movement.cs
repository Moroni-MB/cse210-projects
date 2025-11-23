public class Movement
{
    private string _startingLocation;
    private string _destination;
    public Movement()
    {

    }
    public void MoveCharacter(Character c, string start, string end)
    {
        c.Move(start, end);
    }
}