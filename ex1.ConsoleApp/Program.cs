﻿using System;

namespace ex1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura = 50;
            int altura = 10;
            string str = "";

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    str = str+"*";
                }
                str += "\n";
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
