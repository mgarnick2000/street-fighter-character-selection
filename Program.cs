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
            int[] position = new int[] { 0, 0 };
            StreetFighterSelection(fighters, position, moves);
        }

        public static string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {

            int startX = position[1];
            int startY = position[0];
            List<string> sff = new List<string>();
            for (int i = 0; i < fighters.Length; i++)
            {
                for (int j = 0; j < fighters[i].Length; j++)
                {
                    if (j < moves.Length )
                    {
                        switch (moves[j])
                        {
                            case "up": startY--; if (startY < 0) { startY = 0; }; break;
                            case "down": startY++; if (startY > fighters.Length - 1) { startY = fighters.Length - 1; }; break;
                            case "left": startX--; if (startX < 0) { startX = fighters[startY].Length - 1; }; break;
                            case "right": startX++; if (startX > fighters[startY].Length - 1) { startX = 0; }; break;
                        }
                        sff.Add(fighters[startY][startX]);
                        WriteLine(sff[j]);
                    };
                }

            }

            return sff.ToArray();
        }
    }
}
