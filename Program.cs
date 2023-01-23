namespace Minipoly;

internal static class Minipoly
{
    public static void Main(string[] args)
    {
        var isGameOver = false;
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
            PlayerToken = '2',
            PlayerCash = 10000000.00
        };
        
        board.PrintBoard(player1, player2);
        
        // TODO: Uncomment and finish when done implementing game functions
        // for (var turn = 0; !isGameOver; turn++)
        // {
        //     if (turn % 2 == 0)
        //     {
        //         // Player 1's turn
        //     }
        //     else
        //     {
        //         // Player 2's turn
        //     }
        // }
    }
}