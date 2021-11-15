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
            Console.WriteLine("Interactive Fiction (select thine individual story)");
            Console.WriteLine("-------------------------------------------------");

            

            while (GameOver == false)
            {

            }

            Console.ReadKey(true);
        }

        static string[] story = new string[9];
        static bool GameOver = false;

        static void StoryCell()
        {
            story[0] = ""; //start
            story[1] = "";
            story[2] = "";
            story[3] = "";
            story[4] = "";
            story[5] = "";
            story[6] = "";
            story[7] = "";
            story[8] = "";
        }

    }
}
