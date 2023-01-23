namespace Minipoly;

public class Player
{
    public int PlayerPos { get; set; }

    public char PlayerToken { get; set; }

    public double PlayerCash { get; set; }

    public int MovePlayer(short diceRoll)
    {   
        return PlayerPos += diceRoll;
    }
}