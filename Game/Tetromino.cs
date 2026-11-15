class Tetromino
{
    public string Type { get; }
    public int Row { get; private set; }
    public int Column { get; private set; }

    public Tetromino(string type, int row, int column)
    {
        Type = type;
        Row = row;
        Column = column;
    }
}