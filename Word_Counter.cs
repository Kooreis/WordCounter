```CSharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            Console.WriteLine("Word: {0}, Count: {1}", pair.Key, pair.Value);
        }

        Console.ReadKey();
    }
}
```