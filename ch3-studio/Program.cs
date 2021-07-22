using System;
using System.Collections.Generic;
using System.IO;

namespace ch3_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //string example = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //Console.WriteLine("Please enter a string to analyze:");
            //string input = Console.ReadLine().ToLower();

            string file = @"C:\Users\16165\Documents\CoderGirl2021\Unit2\csharp-practice\chapter3\ch3-studio\ch3-studio\input.txt";

            Console.WriteLine("Reading File using File.ReadAllText()");
            string textToAnalyze;

            if (File.Exists(file))
            {
                textToAnalyze = File.ReadAllText(file).ToLower();
                Console.WriteLine("Analyzing: " + textToAnalyze);
            } else
            {
                textToAnalyze = "";
                Console.WriteLine("Text file not found.");
                Environment.Exit(0);
            }

            char[] charactersInString = textToAnalyze.ToCharArray();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char c in charactersInString)
            {
                if (!charCount.ContainsKey(c) && Char.IsLetter(c))
                {
                    charCount.Add(c, 1);
                }
                else if (charCount.ContainsKey(c))
                {
                    charCount[c] += 1;
                }
            }

           

            foreach(char i in charCount.Keys)
            {
                Console.WriteLine(i+": "+charCount[i]);
            }

        }
    }
}
