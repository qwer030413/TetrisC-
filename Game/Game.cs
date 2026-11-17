using Raylib_cs;

class Game
{
    private Board board;
    private PieceQueue pieceQueue;
    // private Shapes shapes;
    Tetromino currentPiece;
    Tetromino holdPiece;
    InputHandler input;
    public Game()
    {
        pieceQueue = new PieceQueue();
        // shapes = new Shapes();
        board = new Board(pieceQueue);
        currentPiece = new Tetromino(pieceQueue.getNext(),0,3);
        input = new InputHandler();
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
            else if(input.ReadKey() == "C")
            {
                holdPiece = currentPiece;
                nextPiece();
            }

            board.Draw(currentPiece, holdPiece);
        }
        Raylib.CloseWindow();
    }

    public void nextPiece()
    {
        currentPiece = new Tetromino(pieceQueue.getNext(),0,3);
    }

}