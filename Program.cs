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



        static void Main(string[] args)
        {
            DisplayMap();
            Console.WriteLine("");
            DisplayMap(5);
            

            Console.ReadKey(true);

        }

        //Matt's Example

        static void DisplayLegend()
        {
            Console.WriteLine("╔═══════════════╗");
            Console.WriteLine("║  map legend   ║  ");
            Console.WriteLine("║═══════════════║  ");
            Console.WriteLine("║  ^ = mountain ║ "); 
            Console.WriteLine("║  ` = grass    ║ "); 
            Console.WriteLine("║  ~ = water    ║ ");
            Console.WriteLine("║  * = trees    ║ ");
            Console.WriteLine("╚═══════════════╝");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        // static void Repeat(int count, char character)
        // {
        //     for (int i = 0; i < count; i++)
        //     {
        //         Console.Write(character);
        //     }
        // }

        static void DisplayMap()
        {


            Console.WriteLine("This is the map at normal values.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("╔");

            for (int BoarderTop = 0; BoarderTop < map.GetLength(1); BoarderTop++)
            {
                Console.Write("═");
            }
                Console.Write("╗");
                Console.WriteLine("");


            for (int y = 0; y < map.GetLength(0); y++)
            {
                Console.Write("║");

                for (int x = 0; x < map.GetLength(1); x++)
                {
                    
                    Console.Write(map[y, x]);
                }
                // After x

                Console.Write("║");
                Console.WriteLine(" ");

                
            }
            // AFter y

                Console.Write("╚");

            for (int BoarderBottom = 0; BoarderBottom < map.GetLength(1); BoarderBottom++)
            {
                Console.Write("═");
            }
                Console.Write("╝");
                Console.WriteLine("");

            DisplayLegend();
        }
        


        static void DisplayMap(int scale)   //scale is 5
        {

            Console.WriteLine("This is the map at a scale value of " + scale + ".");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("╔");

            for (int BoarderTop = 0; BoarderTop < map.GetLength(1) * scale; BoarderTop++)
            {
                Console.Write("═");
            }
                Console.Write("╗");
                Console.WriteLine("");
            for (int y = 0; y < map.GetLength(0); y++)  //do the below for every row in the map
            {
                for (int ScaleY = 0; ScaleY < scale; ScaleY++) //do the below twice
                {
                    Console.Write("║"); 

                    for (int x = 0; x < map.GetLength(1); x++)  //do the below for every character in a row
                    {
                        for (int ScaleX = 0; ScaleX < scale; ScaleX++)  //do the below twice
                        {
                            Console.Write(map[y, x]);  //write one character
                        }
                    }
                    Console.Write("║");
                    Console.WriteLine(" ");
                }

                // After X
            }

            Console.Write("╚");

            for (int BoarderBottom = 0; BoarderBottom < map.GetLength(1) * scale; BoarderBottom++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
            Console.WriteLine("");
            // After Y

            DisplayLegend();
        }

    }
}
