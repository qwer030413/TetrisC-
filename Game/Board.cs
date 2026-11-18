using Raylib_cs;


// board start is 300,200
internal class Board
{
    PieceQueue pieceQueue;
    Shapes shape;
    int[,] boardGrid = new int[10, 20];
    public Board(PieceQueue PQ)
    {
        shape = new Shapes();
        pieceQueue = PQ;
        Raylib.InitWindow(1000, 1000, "Hello, World");
        Raylib.SetTargetFPS(60);

    }

    private void DrawNext5Pieces()
    {
        List<string> temp = pieceQueue.GetPreview();
        int j = 250;
        for(int i = 0; i < temp.Count; i++)
        {
            shape.DrawShape(shape.SToShape(temp[i]),650,j,30,Shapes.Colors[temp[i]]);
            j += 100;
        }
    }

    public void Draw(Tetromino currentPiece, Tetromino? holdPiece)
    {
        string type = currentPiece.Type;
        int x = 300 + currentPiece.Column * 30;
        int y = 200 + currentPiece.Row * 30;
        int rotation = currentPiece.Rotation % 4;
        // main window
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Black);
        Raylib.DrawRectangleLines(300,200,300,600,Color.White);


        // hold box
        Raylib.DrawRectangle(100,200,200,30,Color.White);
        Raylib.DrawText("HOLD",110,205,20,Color.Black);
        Raylib.DrawRectangleLines(100,230,200,100,Color.White);
        if (holdPiece != null)
        {
            string holdType = holdPiece.Type;
            shape.DrawShape(
                Shapes.Data[holdType],
                170, 250, 30,
                Shapes.Colors[holdType]
            );
        }

        // Next box
        Raylib.DrawRectangle(600,200,200,30,Color.White);
        Raylib.DrawText("NEXT",610,205,20,Color.Black);
        Raylib.DrawRectangleLines(600,230,200,500,Color.White);

        int[,] newShape = Shapes.Data[type];
        for(int i = 0; i < rotation; i++)
        {
            newShape = shape.RotateShape(newShape);
        }
        shape.DrawShape(newShape, x, y, 30, Shapes.Colors[type]);
        DrawNext5Pieces();

        // shape.DrawShape(shape.SToShape(input.ReadKey()),0,0,50);
        Raylib.EndDrawing();
    }
}
