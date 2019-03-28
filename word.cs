using System;

namespace word
{
    class Program
    {
        static void Main(string[] args)
        {
            //get text file into an object
            Dictionary<int, string> dict = new Dictionary<int, string>();
            
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(@"words.txt");

            foreach (var line in lines)
            {
                dict.add(line);
            }

            foreach (var line in lines)
            {
                Console.WriteLine(line.ToLower());
            }
            //get input word

            //get final word

            //transform loop

            //output list of words to transform from start to end, count, time


        }
    }
}
