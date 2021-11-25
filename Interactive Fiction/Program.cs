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
            Console.WriteLine("Interactive Fiction (select thine personal quest)");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Gameplay();

            Console.ReadKey(true);
        }

        static int currentPage;
        static string[] story = new string[14]; 
        static bool GameOver = false; 
        static string[] splitPage;
        static char[] splitChars = { ';' };

        static void InitStory()
        {
            story[0] = ";;;1;2"; 
            story[1] = ";;;3;4";
            story[2] = ";;;5;6"; 
            story[3] = ";;;7;8";
            story[4] = ";;;;";
            story[5] = ";;;;";
            story[6] = ";;;;";
            story[7] = ";;;;";
            story[8] = ";;;;";
            story[9] = ";;;;";
            story[10] = ";;;;";
            story[11] = ";;;;";
            story[12] = ";;;;";
            story[13] = ";;;;";
        }

        static void SplitPage()
        {
            splitPage = story[currentPage].Split(splitChars);            
        }

        static void DisplayStory()
        {
            Console.WriteLine(splitPage[0]);
            Console.WriteLine();
            Console.WriteLine("Press A to: " + splitPage[1]);
            Console.WriteLine("-OR-");
            Console.WriteLine("Press B to: " + splitPage[2]);
        }

        static void TakeInput()
        {
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
            else if (input.KeyChar == 'b' || input.KeyChar == 'B')
            {
                currentPage = int.Parse(splitPage[4]);
            }
            else
            {
                Console.WriteLine("please input valid character");
                Console.WriteLine();
                Gameplay();
            }
        }

        static void Gameplay()
        {
            while (GameOver == false)
            {
                InitStory();
                SplitPage();
                DisplayStory();
                TakeInput();
            }            
        }
    }
}
