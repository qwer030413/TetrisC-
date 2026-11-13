using Raylib_cs;

internal class Board
{

    public Board()
    {
        Raylib.InitWindow(1000, 1000, "Hello, World");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Draw();
        }

        Raylib.CloseWindow();
    }

    private void Draw()
    {
        InputHandler input = new InputHandler();
        string lastKey = "";
        string key = input.ReadKey();
        // main window
        Rectangle parentRect = new Rectangle(300,200,400,600);
        int rows = 20;
        int cols = 10;
        float cellWidth = parentRect.Width  / (float)cols;
        float cellHeight = parentRect.Height / (float)rows;
        if (key != "")
        {
            lastKey = key;
        }
        Raylib.BeginDrawing();
        // make main grid
        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < cols; j++)
        //     {
        //         // Calculate individual cell position
        //         float x = parentRect.X + j * cellWidth;
        //         float y = parentRect.Y + i * cellHeight;

        //         // Draw filled cell
        //         Raylib.DrawRectangle((int)x, (int)y, (int)cellWidth, (int)cellHeight, Color.Blank);

        //         // Draw cell border
        //         Raylib.DrawRectangleLines((int)x, (int)y, (int)cellWidth, (int)cellHeight, Color.DarkGray);
        //     }
        // }
        Raylib.DrawRectangleLines(300,200,400,600,Color.White);


        // hold box
        Raylib.DrawRectangle(100,200,200,30,Color.White);
        Raylib.DrawText("HOLD",110,205,20,Color.Black);
        Raylib.DrawRectangleLines(100,230,200,100,Color.White);


        // Next box
        Raylib.DrawRectangle(700,200,200,30,Color.White);
        Raylib.DrawText("NEXT",710,205,20,Color.Black);
        Raylib.DrawRectangleLines(700,230,200,500,Color.White);


        
        Raylib.ClearBackground(Color.Black);
        Raylib.DrawText($"{input.ReadKey()}", 12, 12, 20, Color.White);

        Raylib.EndDrawing();
    }
}
