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
            StoryCell();
            //----------------------------------------------------------------------
            Console.WriteLine("Interactive Fiction (select thine individual story)");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine(story[0]);

            Gameplay();

            Console.ReadKey(true);
        }
         
        static string[] story = new string[9]; 
        static bool GameOver = false; 
        static char input; //reads input for gameplay

        static void StoryCell()
        {
            story[0] = "Beginning of the story: Do you want to (a) jump off a bridge, or (b) jump off a building"; //start
            story[1] = "you die in the water"; //a
            story[2] = "you die on the ground"; //b
            story[3] = "";
            story[4] = "";
            story[5] = "";
            story[6] = "";
            story[7] = "";
            story[8] = "";
        }
        static void Gameplay()
        {
            if (GameOver == false)
            {
                input = Console.ReadKey(true).KeyChar;
                if (input == 'a' || input == 'A')
                {
                    Console.WriteLine(story[1]);
                }
                else if (input == 'b' || input =='B')
                {
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
