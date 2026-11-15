using Raylib_cs;

class Shapes
{
    // int[,] is 2d array
    public static readonly Dictionary<string, int[,]> Data = new()
    {
        ["I"] = new int[,]
        {
            { 1, 1, 1, 1 }
        },

        ["O"] = new int[,]
        {
            { 1, 1 },
            { 1, 1 }
        },

        ["T"] = new int[,]
        {
            { 0, 1, 0 },
            { 1, 1, 1 }
        },

        ["S"] = new int[,]
        {
            { 0, 1, 1 },
            { 1, 1, 0 }
        },

        ["Z"] = new int[,]
        {
            { 1, 1, 0 },
            { 0, 1, 1 }
        },

        ["J"] = new int[,]
        {
            { 1, 0, 0 },
            { 1, 1, 1 }
        },

        ["L"] = new int[,]
        {
            { 0, 0, 1 },
            { 1, 1, 1 }
        },
        [""] = new int[,]
        {
            {}
        }
    };

    public static readonly Dictionary<string, Color> Colors = new()
    {
        ["I"] = Color.SkyBlue,
        ["O"] = Color.Yellow,
        ["T"] = Color.Purple,
        ["S"] = Color.Green,
        ["Z"] = Color.Red,
        ["J"] = Color.Blue,
        ["L"] = Color.Orange
    };
    public int[,] SToShape(string temp)
    {
        return Data[temp];
    }
    public void DrawShape(int[,] shape, int x, int y, int blockSize, Color color)
    {
        for(int r = 0; r < shape.GetLength(0); r++)
        {
            for(int c = 0; c < shape.GetLength(1); c++)
            {
                int row = x + (blockSize * c);
                int col = y + (blockSize * r);
                if(shape[r,c] == 1)
                {
                    Raylib.DrawRectangle(row,col,blockSize,blockSize,color);
                    Raylib.DrawRectangleLines(row,col,blockSize,blockSize,Color.Black);
                }
            }
        }
    }
}