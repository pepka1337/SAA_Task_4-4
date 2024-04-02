// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace Pac
{
    class Program
    {
        static int playerHealth = 10; // Устанавливаем здоровье игрока на 10
        static bool showPath = false; // Флаг для отображения пути до выхода
        static void Main(string[] args)
        {
            char[,] map = ReadMap("map.txt");
            DrawMap(map);

        }
        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");
            char[,] map = new char[GetMaxLengthOfLine(file), file.Length];
            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];
            return map;
        }
        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.WriteLine(map[x, y]);
                }
                Console.WriteLine("\n");
            }

        }
        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach(var line in lines)
                if (line.Length > maxLength)
                     maxLength = line.Length;
            return maxLength;
        }

        

    } 
}
