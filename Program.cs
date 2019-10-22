using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace street_fighter_character_selection
{
    class Program
    {
        static void Main(string[] args)
        {

            var fighters = new string[][]
          {
              new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
              new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
          };

            string[] moves = new string[] { "up", "left", "right", "left", "left" };
            // string[] moves = new string[] { "right", "down", "left", "left", "left", "left", "right" };
            // string[] moves = new string[] { "left", "left", "left", "left", "left", "left", "left", "left" };
            int[] position = new int[] { 0, 0 };
            StreetFighterSelection(fighters, position, moves);
        }

        public static string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {

            int startX = position[1];
            int startY = position[0];
            List<string> sff = new List<string>();

            for (var i = 0; i < moves.Length; i++)
            {
                if (i < moves.Length)
                {
                    switch (moves[i])
                    {
                        case "up": startY--; if (startY < 0) { startY = 0; }; break;
                        case "down": startY++; if (startY > fighters.Length - 1) { startY = fighters.Length - 1; }; break;
                        case "left": startX--; if (startX < 0) { startX = fighters[startY].Length - 1; }; break;
                        case "right": startX++; if (startX > fighters[startY].Length - 1) { startX = 0; }; break;
                    }
                    sff.Add(fighters[startY][startX]);
                    WriteLine(sff[i]);
                };
            }

            return sff.ToArray();
        }

        // public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        // {
        //     int x = position[1];
        //     int y = position[0];
        //     return moves.Select(m =>
        //     {
        //         x += m == "left" ? -1 : m == "right" ? 1 : 0;
        //         y += m == "up" ? -1 : m == "down" ? 1 : 0;
        //         x = x < 0 ? 5 : x > 5 ? 0 : x;
        //         y = y < 0 ? 0 : y > 1 ? 1 : y;
        //         return fighters[y][x];
        //     }).ToArray();
        // }

    }
}
