class Tetromino
{
    public string Type { get; }
    public int Row { get; set; }
    public int Column { get; set; }

    public int Rotation {get; set;}

    public Tetromino(string type, int row, int column, int rotation)
    {
        Type = type;
        Row = row;
        Column = column;
        Rotation = rotation;
    }
}