using System;
using System.Collections.Generic;
class PieceQueue
{
    private Queue<string> pieces = new Queue<string>();
    private Random random = new Random();

    public PieceQueue()
    {
        refill();
    }
    private void refill()
    {
        string[] blocks = {"O", "I", "S", "Z", "L", "J", "T"};
        for(int i = blocks.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            string temp = blocks[j];
            blocks[j] = blocks[i];
            blocks[i] = temp;
        }

        foreach(string i in blocks)
        {
            pieces.Enqueue(i);
        }
        
    }

    public string getNext()
    {
        if(pieces.Count < 6)
        {
            refill();
        }
        return pieces.Dequeue();
    }

    public List<string> GetPreview()
    {
        return pieces.Take(5).ToList();
    }
}