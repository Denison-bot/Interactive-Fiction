using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interactive_Fiction
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTitleScreen();
            MainMenu();
        }

        static int currentPage;
        static string[] story = new string[17]; 
        static bool GameOver = false; 
        static string[] splitPage;
        static string[] splitLine;
        static char[] splitChars = { ';' }; // splits story text
        static string savePath = @"SaveData.txt"; // last save data
        static string storyFile = @"story.txt"; // story stored in .txt

        static void InitStory()
        {
            story = File.ReadAllLines(storyFile);
        }

        static void SaveGame()
        {
            //if (!File.Exists(path))
            //{
            //    string[] createText = { };
            //}
            if (File.Exists(savePath))
            {
                string createText = currentPage.ToString() ;
                File.WriteAllText(savePath, createText);
            }
        }

        static void LoadGame()
        {
            currentPage = int.Parse(File.ReadAllText(savePath));
        }

        static void MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1- New Game");
            Console.WriteLine("2- Load Game");
            Console.WriteLine("3- Quit");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            TakeMenuInput();
        }

        static void TakeMenuInput()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            if (input.KeyChar == '1')
            {
                currentPage = 0;
                Gameplay();
            }
            else if (input.KeyChar == '2')
            {
                LoadGame();
                Gameplay();
            }
            else if (input.KeyChar == '3')
            {
                GameOver = true;
            }
            
        }

        static void SplitPage()
        {
            splitPage = story[currentPage].Split(splitChars);
            splitLine = splitPage[0].Split('#');
        }

        static void DisplayStory()
        {
            //int len2 = 5;
            //int counter = 0;

            for (int x = 0; x < splitLine.Length; x++)
            {
                string PageScroll = splitLine[x];
                int len = PageScroll.Length;
                for (int i = 0; i < len; i++)
                {
                    Console.Write(PageScroll[i]);
                    System.Threading.Thread.Sleep(1);
                }
                Console.WriteLine();
            }

            

            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press A to: " + splitPage[1]);
            Console.WriteLine("-OR-");
            Console.WriteLine("Press B to: " + splitPage[2]);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press S to save game");
            Console.WriteLine("Press L to load last save");
            Console.WriteLine("Press P to return to the main menu");
            Console.WriteLine("-------------------------------------");
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
            if (input.KeyChar == 's' || input.KeyChar == 'S')
            {
                SaveGame();
                Console.Beep(575, 100);
            }
            else if (input.KeyChar == 'a' || input.KeyChar == 'A')
            {
                currentPage = int.Parse(splitPage[3]);
                Console.Beep(525, 100);
            }
            else if (input.KeyChar == 'b' || input.KeyChar == 'B')
            {
                currentPage = int.Parse(splitPage[4]);
                Console.Beep(500, 100);
            }
            else if (input.KeyChar == 'p' || input.KeyChar == 'P')
            {
                Console.Clear();
                DisplayTitleScreen();
                MainMenu();
            }
            else if (input.KeyChar == 'l' || input.KeyChar == 'L')
            {
                Console.Clear();
                LoadGame();
                Gameplay();
            }
            else
            {
                Console.WriteLine("please input valid character");
                Console.ReadKey(true);
                Console.WriteLine();
            }
        }

        static void DisplayTitleScreen()
        {
            Console.WriteLine("");
            Console.WriteLine("   ▄▄▄▄▄   ▄███▄   █     ▄███▄   ▄█▄      ▄▄▄▄▀        ▄▄▄▄▀ ▄  █ ▄█    ▄   ▄███▄       █ ▄▄  ▄███▄   █▄▄▄▄   ▄▄▄▄▄   ████▄    ▄   ██   █         ██   ██▄       ▄   ▄███▄      ▄     ▄▄▄▄▀ ▄   █▄▄▄▄ ▄███▄       ");
            Console.WriteLine("  █     ▀▄ █▀   ▀  █     █▀   ▀  █▀ ▀▄ ▀▀▀ █        ▀▀▀ █   █   █ ██     █  █▀   ▀      █   █ █▀   ▀  █  ▄▀  █     ▀▄ █   █     █  █ █  █         █ █  █  █       █  █▀   ▀      █ ▀▀▀ █     █  █  ▄▀ █▀   ▀      ");
            Console.WriteLine("▄  ▀▀▀▀▄   ██▄▄    █     ██▄▄    █   ▀     █            █   ██▀▀█ ██ ██   █ ██▄▄        █▀▀▀  ██▄▄    █▀▀▌ ▄  ▀▀▀▀▄   █   █ ██   █ █▄▄█ █         █▄▄█ █   █ █     █ ██▄▄    ██   █    █  █   █ █▀▀▌  ██▄▄        ");
            Console.WriteLine(" ▀▄▄▄▄▀    █▄   ▄▀ ███▄  █▄   ▄▀ █▄  ▄▀   █            █    █   █ ▐█ █ █  █ █▄   ▄▀     █     █▄   ▄▀ █  █  ▀▄▄▄▄▀    ▀████ █ █  █ █  █ ███▄      █  █ █  █   █    █ █▄   ▄▀ █ █  █   █   █   █ █  █  █▄   ▄▀     ");
            Console.WriteLine("           ▀███▀       ▀ ▀███▀   ▀███▀   ▀            ▀        █   ▐ █  █ █ ▀███▀        █    ▀███▀     █                   █  █ █    █     ▀        █ ███▀    █  █  ▀███▀   █  █ █  ▀    █▄ ▄█   █   ▀███▀       ");
            Console.WriteLine("                                                              ▀      █   ██               ▀            ▀                    █   ██   █              █           █▐           █   ██        ▀▀▀   ▀                ");
            Console.WriteLine("                                                                                                                                    ▀              ▀            ▐                                                 ");
            Console.WriteLine("");
        }

        static void Gameplay()
        {
            Console.Clear();
            InitStory();
            while (GameOver == false)
            {
                SplitPage();
                DisplayStory();
                TakeInput();
                Console.Clear();
                if (story[currentPage] == story[14])
                {
                    GameOver = true;
                }
            }
        }
    }
}
