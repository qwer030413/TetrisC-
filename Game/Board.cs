using Raylib_cs;
internal class Board
{
    public Board()
    {
        Raylib.InitWindow(800, 800, "Hello, World");
        Raylib.SetTargetFPS(60);
        InputHandler input = new InputHandler();
        string lastKey = "";
        while (!Raylib.WindowShouldClose())
        {
            
            string key = input.ReadKey();
            if (key != "")
            {
                lastKey = key;
            }
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);
            Raylib.DrawText($"{input.ReadKey()}", 12, 12, 20, Color.White);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
