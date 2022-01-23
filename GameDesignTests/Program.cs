using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDesignTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PlayerName = "Test Player";
            string Location = "Starting Zone";
            int Turn = 0;
            int Gold = 0;

            Console.Title = "Simple Color Example";


            while (Turn < 20)
            {
                Turn++; Gold++;
                HUD(PlayerName, Location, Turn, Gold);
                Console.WriteLine("Press enter to simulate turns progressing... turn number " + Turn + " ... ");
                Console.ReadKey();
            }

            Console.WriteLine("Simulation of game ending");
            Console.ReadKey();

        }

        public static void HUD(string player, string location, int turn, int gold)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    " + player);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(location);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("turn " + turn + " /20");
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(gold + " gold\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================================================\n\n\n\n");
            Console.ResetColor();


        }
    }
}
