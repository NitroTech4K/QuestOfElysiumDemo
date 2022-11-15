using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestOfElysiumDemo
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };


        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        static void Main(string[] args)
        {
            DisplayMap(5);
            Repeat(3, 'w');

            Console.ReadKey(true);

        }

        static void Repeat(int count, char character)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(character);
            }
        }

        static void DisplayMap()
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Console.Write(map[x, y]);
                }
                // After y
                Console.WriteLine(" ");
            }
            // AFter X

        }
        //static void DisplayMap(int scale)
        //{

        //}
        static void DisplayMap(int scale)   //scale is 5
        {
            for (int ScaleX = 0; ScaleX < scale; ScaleX++)
            {
                for (int y = 0; y < map.GetLength(1); y++)  //do the below for every character in a row
                {
                    for (int ScaleY = 0; ScaleY < scale; ScaleY++)  //do the below 5 times
                    {
                        Console.Write(map[ScaleX, y]);  //write one character
                    }
                }
                // After y
                Console.WriteLine(" ");
            }
            // AFter X
        }

    }
}
