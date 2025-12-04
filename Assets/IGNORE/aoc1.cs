using System.Collections.Generic;
using UnityEngine;

public class aoc1 : MonoBehaviour
{
    public TextAsset aocInput;
    private int zeroCounter;
    private int dial = 50;
    private Queue<string> lines = new();
    
    void Start()
    { 
        string[] inputLines = aocInput.text.Split('\n');
        foreach (string line in inputLines)
        {
            lines.Enqueue(line.TrimEnd('\r'));
        }
        
        while (lines.Count > 0)
        {
            string input = lines.Dequeue();    
            string direction = input[0].ToString();  
            int steps = int.Parse(input.Substring(1));       

            TurnDial(direction, steps);
        }
        
        Debug.Log(zeroCounter);
    }

    void TurnDial(string plusminus, int amount)
    {
        if (plusminus == "L")
        {
            for (int i = 0; i < amount; i++)
            {
                dial -= 1;
                if (dial < 0)
                {
                    dial = 99;
                }
            }
        }
        else
        {
            for (int i = 0; i < amount; i++)
            {
                dial += 1;
                if (dial > 99)
                {
                    dial = 0;
                }
            }
        }

        if (dial == 0)
            zeroCounter++;
    }
}
