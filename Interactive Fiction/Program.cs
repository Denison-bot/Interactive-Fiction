using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction
{
    class Program
    {
        static void Main(string[] args)
        {
            //init
            InitStory();
            //----------------------------------------------------------------------
            Console.WriteLine("Interactive Fiction (select thine personal quest)");
            Console.WriteLine("---------------------------------------------------");

            Gameplay();

            Console.ReadKey(true);
        }

        static int currentPage;
        static string[] story = new string[9]; 
        static bool GameOver = false; 
        static string[] splitPage;
        static char[] splitChars = { ';' };

        static void InitStory()
        {
            //story[0] = "You are this person in this place.;Jump off a bridge.;Jump off a building;5;10"; //start
            story[0] = "You decide that you want to go bungie jumping.;Go bungie jumping from a building.;Go bungie jumping from a bridge;1;2"; //start
            story[1] = "you land in the water. \n(a) swim to shore. (b) swim to the bottom of the ocean";
            story[2] = "you hit the ground and die"; 
            story[3] = "you swim straight down for about 50 seconds and then it dawns on you. You're not a fish \nyou drown and die";
            story[4] = "you finally make it back to shore and you're PARCHED from such a long workout \n(a) drink some sea water (b) Pray to God it starts raining so you can drink from the sky";
            story[5] = "";
            story[6] = "";
            story[7] = "";
            story[8] = "";
        }

        

        static void Gameplay()
        {
            if (GameOver == false)
            {
                InitStory();
                splitPage = story[currentPage].Split(splitChars);
                Console.WriteLine(splitPage[0]);
                Console.WriteLine();
                Console.WriteLine(splitPage[1]);
                Console.WriteLine("-OR-");
                Console.WriteLine(splitPage[2]);

                //read input
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);

                //check input
                if (input.KeyChar == 'a' || input.KeyChar == 'A')
                {
                    currentPage = int.Parse(splitPage[3]);
                }
                if (input.KeyChar == 'b' || input.KeyChar == 'B')
                {
                    currentPage = int.Parse(splitPage[4]);
                }
            }            
        }
    }
}
