namespace Minipoly;

public class Player
{
    private int playerPos;

    private char playerToken;

    private double playerCash;
    public int PlayerPos
    {
        get => playerPos;
        set => playerPos = value;
    } 

    public char PlayerToken
    {
        get => playerToken;
        set => playerToken = value;
    }

    public double PlayerCash
    {
        get => playerCash;
        set => playerCash = value;
    }
    public int MovePlayer(short diceRoll)
    {   
        return playerPos += diceRoll;
    }
}