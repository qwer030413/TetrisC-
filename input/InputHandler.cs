using Raylib_cs;

internal class InputHandler
{
    public string ReadKey()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Up))
            return "U";

        if (Raylib.IsKeyPressed(KeyboardKey.Down))
            return "D";

        if (Raylib.IsKeyPressed(KeyboardKey.Right))
            return "R";

        if (Raylib.IsKeyPressed(KeyboardKey.Left))
            return "L";

        if (Raylib.IsKeyPressed(KeyboardKey.C))
            return "C";

        if (Raylib.IsKeyPressed(KeyboardKey.Space))
            return "S";

        return "";
    }
}