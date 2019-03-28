using System;
using System.Collections.Generic;
using System.IO;

namespace ku_elev
{
    class Program
    {
        static void Main(string[] args)
        {
			// http://codekata.com/kata/kata19-word-chains/
			
			//get start time
			
            //get text file into an object
            Dictionary<int, string> dict = new Dictionary<int, string>();
            
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(@"words.txt");

            int i = 0;
            foreach (var line in lines)
            {
                dict.Add(i, line);
                i++;
            }

            // foreach (var line in dict)
            // {
            //     Console.WriteLine(line);
            // }

            //get input word
            string startWord = "cat";

            //get final word
            string endWord = "dog";
            
            //transform loop, v1
            bool wordFound = false, finalFound = false;
            LinkedList<string> ll = new LinkedList<string>();
            var letters = startWord.ToCharArray();
            while(!finalFound)
            {
                wordFound = false;
                while (!wordFound)
                {
                    for (int j = 0; j < startWord.Length; j++)
                    {
                        if (startWord[j] != endWord[j])
                        {
                            startWord = startWord.Replace(letters[j], endWord[j]);
                            Console.WriteLine(startWord);
                            wordFound = dict.ContainsValue(startWord);
                            if (wordFound)
                            {
                                break;
                            }
                        }
                    }

                }

                //store in collection
                ll.AddLast(startWord);

                if (startWord == endWord)
                {
                    finalFound = true;
                }
            }

            //output linked list of words to transform from start to end, count, time taken

        }
    }
}
