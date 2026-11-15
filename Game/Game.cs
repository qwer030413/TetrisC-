using Raylib_cs;

class Game
{
    private Board board;
    private PieceQueue pieceQueue;
    // private Shapes shapes;
    Tetromino currentPiece;
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
                Update();
            }
            board.Draw(currentPiece);
        }
        Raylib.CloseWindow();
    }

    public void Update()
    {
        currentPiece = new Tetromino(pieceQueue.getNext(),0,3);
    }

}