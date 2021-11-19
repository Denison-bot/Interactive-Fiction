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

            Console.WriteLine(story[0]);

            Gameplay();

            Console.ReadKey(true);
        }
         
        static string[] story = new string[9]; 
        static bool GameOver = false; 
        static char input; //reads input for gameplay

        static void InitStory()
        {
            story[0] = "Beginning of the story: Do you want to (a) jump off a bridge, or (b) jump off a building"; //start
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
                //choice 1
                input = Console.ReadKey(true).KeyChar;
                if (input == 'a' || input == 'A')
                {
                    //choice 2
                    Console.WriteLine(story[1]);
                    input = Console.ReadKey(true).KeyChar;
                    if (input == 'a' || input == 'A')
                    {
                        Console.WriteLine(story[4]);

                    }
                    else if (input == 'b' || input == 'B')
                    {
                        Console.WriteLine(story[3]);
                    }
                }
                else if (input == 'b' || input =='B')
                {
                    //first death 
                    Console.WriteLine(story[2]);
                }
                else
                {
                    Console.WriteLine("Please input valid entry");
                    Console.WriteLine(story[0]);
                    Gameplay();
                }
            }
        }
    }
}
