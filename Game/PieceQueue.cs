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
        string[] blocks = {"O", "i", "S", "Z", "L", "J", "T"};
        for(int i = 0; i < blocks.Length; i++)
        {
            int j = random.Next(blocks.Length - 1);
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
        if(pieces.Count <= 7)
        {
            refill();
        }
        return pieces.Dequeue();
    }
}