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

        static int currentPage;
        static string[] story = new string[9]; 
        static bool GameOver = false; 
        static char input; //reads input for gameplay

        static void InitStory()
        {
            char[] splitChars = { '' };

            //story[0] = "You are this person in this place.;Jump off a bridge.;Jump off a building;5;10"; //start
            story[0] = "You decide that you want to go bungie jumping.&Go bungie jumping from a building.$Go bungie jumping from a bridge+1%2"; //start
            story[1] = "you land in the water. \n(a) swim to shore. (b) swim to the bottom of the ocean";
            story[2] = "you hit the ground and die"; 
            story[3] = "you swim straight down for about 50 seconds and then it dawns on you. You're not a fish \nyou drown and die";
            story[4] = "you finally make it back to shore and you're PARCHED from such a long workout \n(a) drink some sea water (b) Pray to God it starts raining so you can drink from the sky";
            story[5] = "";
            story[6] = "";
            story[7] = "";
            story[8] = "";

            string[] splitPage = story[currentPage].Split(splitChars);
        }
        static void Gameplay()
        {
            if (GameOver == false)
            {

            }            
        }
    }
}
