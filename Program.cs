namespace Minipoly;

internal static class Minipoly
{
    public static void Main(string[] args)
    {
        var board = new Board();
        var dice = new Dice();
        
        var player1 = new Player
        {
            PlayerPos = 0,
            PlayerToken = '1',
            PlayerCash = 10000000.00
        };
        
        var player2 = new Player
        {
            PlayerPos = 0,
            PlayerToken = '1',
            PlayerCash = 10000000.00
        };
        
        board.PrintBoard(player1.PlayerCash, player2.PlayerCash);
    }
}