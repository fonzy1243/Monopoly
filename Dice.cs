namespace Minipoly;

public class Dice
{ 
    public short RollDice()
    {
        var random = new Random();
        return (short) random.Next(1, 7);   // 7 because the upper bound is exclusive
    }
}