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
        }
    };

    public void DrawShape(int[,] shape, int x, int y, int blockSize)
    {
        for(int r = 0; r < shape.GetLength(0); r++)
        {
            for(int c = 0; c < shape.GetLength(1); c++)
            {
                int row = x + (blockSize * r);
                int col = y + (blockSize * c);
                if(shape[r,c] == 1)
                {
                    Raylib.DrawRectangle(100,200,200,30,Color.White);
                }
            }
        }
    }
}