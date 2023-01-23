namespace Minipoly;

public class Dice
{
    private short diceRoll;

    public short DiceRoll
    {
        get => diceRoll;
        set => diceRoll = value;
    }

    public short RollDice()
    {
        var random = new Random();
        return (short) random.Next(1, 7);   // 7 because the upper bound is exclusive
    }
}