namespace Minipoly;

public class Board
{
    public char[,] GameBoard =
    {
        {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'e', ' ', ' ', ' ', 'f', ' ', ' ', ' ', 'g', ' ', ' ', ' ', 'h', ' ', ' ', ' ', ' ', ' ', ' ', '\n'},
        {' ', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '-', '-', '-', '+', '\n'},
    };

    public void PrintBoard()
    {
        Console.Clear();
        foreach (var i in GameBoard)
        {
            // ReSharper disable once HeapView.BoxingAllocation (code as recommended by Microsoft)
            Console.Write("{0}", i);
        }
    }
    
}