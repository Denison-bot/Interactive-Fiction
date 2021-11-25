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
            Console.WriteLine("");
            Console.WriteLine("  _____   ___  _        ___     __  ______      ______  __ __  ____  ____     ___      ____    ___  ____    _____  ___   ____    ____  _           ____   ___   __ __  ____   ____     ___  __ __ ");
            Console.WriteLine(" / ___/  /  _]| |      /  _]   /  ]|      |    |      ||  |  ||    ||    \\   /  _]    |    \\  /  _]|    \\  / ___/ /   \\ |    \\  /    || |         |    | /   \\ |  |  ||    \\ |    \\   /  _]|  |  |");
            Console.WriteLine("(   \\_  /  [_ | |     /  [_   /  / |      |    |      ||  |  | |  | |  _  | /  [_     |  o  )/  [_ |  D  )(   \\_ |     ||  _  ||  o  || |         |__  ||     ||  |  ||  D  )|  _  | /  [_ |  |  |");
            Console.WriteLine(" \\__  ||    _]| |___ |    _] /  /  |_|  |_|    |_|  |_||  _  | |  | |  |  ||    _]    |   _/|    _]|    /  \\__  ||  O  ||  |  ||     || |___      __|  ||  O  ||  |  ||    / |  |  ||    _]|  ~  |");
            Console.WriteLine(" /  \\ ||   [_ |     ||   [_ /   \\_   |  |        |  |  |  |  | |  | |  |  ||   [_     |  |  |   [_ |    \\  /  \\ ||     ||  |  ||  _  ||     |    /  |  ||     ||  :  ||    \\ |  |  ||   [_ |___, |");
            Console.WriteLine(" \\    ||     ||     ||     |\\     |  |  |        |  |  |  |  | |  | |  |  ||     |    |  |  |     ||  .  \\ \\    ||     ||  |  ||  |  ||     |    \\  `  ||     ||     ||  .  \\|  |  ||     ||     |");
            Console.WriteLine("  \\___||_____||_____||_____| \\____|  |__|        |__|  |__|__||____||__|__||_____|    |__|  |_____||__|\\_|  \\___| \\___/ |__|__||__|__||_____|     \\____j \\___/  \\__,_||__|\\_||__|__||_____||____/ ");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
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
            story[0] = "You find yourself in ;;;;"; 
            story[1] = ";;;;";
            story[2] = ";;;;"; 
            story[3] = ";;;;";
            story[4] = ";;;;";
            story[5] = ";;;;";
            story[6] = ";;;;";
            story[7] = ";;;;";
            story[8] = ";;;;";
            story[9] = ";;;;";
            story[10] = ";;;;";
            story[11] = ";;;;";
            story[12] = ";;;;";
            story[13] = "";
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
            }
        }

        static void Gameplay()
        {
          InitStory();
            while (GameOver == false)
            {
                SplitPage();
                DisplayStory();
                TakeInput();
                Console.Clear();
            }            
        }
    }
}
