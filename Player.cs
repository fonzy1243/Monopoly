namespace Minipoly;

public class Player
{
    public int PlayerPos { get; set; }

    public char PlayerToken { get; set; }

    public double PlayerCash { get; set; }

    private LinkedList<char> playerProperties = new LinkedList<char>();

    public int MovePlayer(short diceRoll)
    {   
        return PlayerPos += diceRoll;
    }

    public ConsoleKeyInfo GetInput()
    {
        return Console.ReadKey();
    }
}