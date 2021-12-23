﻿using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
