namespace Minipoly;

internal static class Minipoly
{
    public static void Main(string[] args)
    {
        var player1 = new Player
        {
            PlayerPos = 0,
            PlayerToken = 'X'
        };
        
        Console.WriteLine(player1.PlayerPos);
        // Console.WriteLine("Just a test");
        var board = new Board();
        board.PrintBoard();
    }
}