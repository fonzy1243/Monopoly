namespace Minipoly;

public class Board
{
    private char[,] gameBoard = null!;

    public void PrintBoard(Player player1, Player player2)
    {
        Console.Clear();

        gameBoard = new [,]
        { //  0    1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23   24   25   26   27
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'e', ' ', ' ', ' ', 'f', ' ', ' ', ' ', 'g', ' ', ' ', ' ', 'h', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\n'},   // 0
            {' ', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', ' ', '\n'},   // 1
            {' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', '\n'},   // 2
            {' ', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', ' ', '\n'},   // 3
            {'d', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', 'i', '\n'},   // 4
            {' ', '+', '-', '-', '-', '+', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '+', '-', '-', '-', '+', ' ', '\n'},   // 5
            {'c', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', 'j', '\n'},   // 6
            {' ', '+', '-', '-', '-', '+', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '+', '-', '-', '-', '+', ' ', '\n'},   // 7
            {'b', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', 'k', '\n'},   // 8
            {' ', '+', '-', '-', '-', '+', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '+', '-', '-', '-', '+', ' ', '\n'},   // 9
            {'a', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', 'l', '\n'},   // 10
            {' ', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', ' ', '\n'},   // 11
            {' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', '\n'},   // 12
            {' ', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', ' ', '\n'},   // 13
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'o', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'n', ' ', ' ', ' ', 'm', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\n'},   // 14
        };
        
        if (player1.PlayerPos == player2.PlayerPos)
        {
            player1.PlayerToken = player2.PlayerToken = '3';
        }
        else
        {
            player1.PlayerToken = '1';
            player2.PlayerToken = '2';
        }

        var posY = player1.PlayerPos switch
        {
            >= 0 and <= 5 => 3,
            6 or 19 => 7,
            7 or 18 => 11,
            8 or 17 => 15,
            9 or 16 => 19,
            >= 10 and <= 15 => 23,
            _ => throw new ArgumentOutOfRangeException(nameof(player1), $"Player 1 out of bounds (y).")
        };

        var posX = player1.PlayerPos switch
        {
            0 or (>= 15 and <= 19) => 12,
            1 or 14 => 10,
            2 or 13 => 8,
            3 or 12 => 6,
            4 or 11 => 4,
            >= 5 and <= 10 => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(player1), $"Player 1 out of bounds (x).")
        };

        gameBoard[posX, posY] = player1.PlayerToken;

        posY = player2.PlayerPos switch
        {
            >= 0 and <= 5 => 3,
            6 or 19 => 7,
            7 or 18 => 11,
            8 or 17 => 15,
            9 or 16 => 19,
            >= 10 and <= 15 => 23,
            _ => throw new ArgumentOutOfRangeException(nameof(player2), $"Player 2 out of bounds (y).")
        };

        posX = player2.PlayerPos switch
        {
            0 or (>= 15 and <= 19) => 12,
            1 or 14 => 10,
            2 or 13 => 8,
            3 or 12 => 6,
            4 or 11 => 4,
            >= 5 and <= 10 => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(player2), $"Player 2 out of bounds (x).")
        };
        
        gameBoard[posX, posY] = player2.PlayerToken;
        
        foreach (var i in gameBoard)
        {
            // ReSharper disable once HeapView.BoxingAllocation (code as recommended by Microsoft)
            Console.Write("{0}", i);
        }
        
        Console.WriteLine("\nAccount Balance: \nPlayer 1: {0:N}", player1.PlayerCash);
        Console.WriteLine("Player 2: {0:N}",player2.PlayerCash);
    }
    
}