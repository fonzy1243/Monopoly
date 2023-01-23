namespace Minipoly;

public class Dice
{
    private short diceRoll;

    public short DiceRoll
    {
        get => diceRoll;
        set => diceRoll = value;
    }

    private void RollDice()
    {
        var random = new Random();
        diceRoll = (short) random.Next(1, 7);   // 7 because the upper bound is exclusive
    }
}