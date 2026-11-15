using Raylib_cs;

internal class Board
{
    PieceQueue pieceQueue;
    Shapes shape;
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
            shape.DrawShape(shape.SToShape(temp[i]),750,j,30,Shapes.Colors[temp[i]]);
            j += 100;
        }
    }

    public void Draw(Tetromino currentPiece)
    {
        // main window
        Raylib.BeginDrawing();
        Raylib.DrawRectangleLines(300,200,400,600,Color.White);


        // hold box
        Raylib.DrawRectangle(100,200,200,30,Color.White);
        Raylib.DrawText("HOLD",110,205,20,Color.Black);
        Raylib.DrawRectangleLines(100,230,200,100,Color.White);


        // Next box
        Raylib.DrawRectangle(700,200,200,30,Color.White);
        Raylib.DrawText("NEXT",710,205,20,Color.Black);
        Raylib.DrawRectangleLines(700,230,200,500,Color.White);

        string type = currentPiece.Type;
        int x = 300 + currentPiece.Column * 40;
        int y = 200 + currentPiece.Row * 30;
        shape.DrawShape(Shapes.Data[type], x, y, 30, Shapes.Colors[type]);
        DrawNext5Pieces();
        Raylib.ClearBackground(Color.Black);

        // shape.DrawShape(shape.SToShape(input.ReadKey()),0,0,50);
        Raylib.EndDrawing();
    }
}
