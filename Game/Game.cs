using Raylib_cs;

class Game
{
    private Board board;
    private PieceQueue pieceQueue;
    // private Shapes shapes;
    Tetromino currentPiece;
    Tetromino? holdPiece = null;
    InputHandler input;
    int X;
    int Y;
    public Game()
    {
        pieceQueue = new PieceQueue();
        // shapes = new Shapes();
        board = new Board(pieceQueue);
        currentPiece = new Tetromino(pieceQueue.getNext(),0,3,0);
        input = new InputHandler();
        X = 0;
        Y = 0;
        // shapes.DrawShape(Shapes.Data[currentPiece.Type],0,0,30,Shapes.Colors[currentPiece.Type]);
    }

    public void Run()
    {
        while (!Raylib.WindowShouldClose())
        {
            if(input.ReadKey() == "S")
            {
                nextPiece();
            }
            // we can only press c once per completion
            else if(input.ReadKey() == "C")
            {
                holdPiece = currentPiece;   
                nextPiece();
            }
            else if (input.ReadKey() == "U")
            {
                currentPiece.Rotation += 1;
            }
            else if(input.ReadKey() == "L" && currentPiece.Column > 0)
            {
                currentPiece.Column -= 1;
            }
            else if(input.ReadKey() == "R" && currentPiece.Column < 10 - Shapes.Data[currentPiece.Type].GetLength(1))
            {
                currentPiece.Column += 1;
            }
            board.Draw(currentPiece, holdPiece);
        }
        Raylib.CloseWindow();
    }

    public void nextPiece()
    {
        currentPiece = new Tetromino(pieceQueue.getNext(),0,3,0);
    }

}