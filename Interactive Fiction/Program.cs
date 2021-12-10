using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Interactive_Fiction
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenerateHash();
            //CheckHash();
            InitStory();
        }

        static int currentPage;
        static string[] story = new string[17];
        static bool gameOver = false;
        static string[] splitPage;
        static string[] splitLine;
        static char[] splitChars = { ';' }; // splits story text
        static string savePath = @"SaveData.txt"; // last save data
        static string storyFile = @"story.txt"; // story stored in .txt

        //attempted to use hash codes, but I ran out of time

        //static string StorySource = File.ReadAllText(storyFile); 
        //static byte[] source;
        //static byte[] hash;
        
        //static void GenerateHash()
        //{
        //    //create byte array
        //    source = ASCIIEncoding.ASCII.GetBytes(StorySource);

        //    //compute hash
        //    hash = new MD5CryptoServiceProvider().ComputeHash(source);
        //}

        //static void CheckHash()
        //{
        //    if (hash.ToString() != "06FCA1D358921624DFC2829894093F41")
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Story file has been altered or corrupted");
        //        Console.WriteLine("Press any key to continue");
        //        Console.ReadKey(true);
        //    }
        //}

        static void InitStory()
        {
            if (!File.Exists(storyFile))
            {
                Console.Clear();
                Console.WriteLine("Story file has been corrupted or does not exist");
                Console.WriteLine("Console will now close");
                Console.ReadKey(true);
                gameOver = true;
            }

            else
            {
                story = File.ReadAllLines(storyFile);
                if (File.ReadAllText(storyFile) == "")
                {
                    Console.Clear();
                    Console.WriteLine("Story data is blank");
                    Console.WriteLine("Console will now close");
                    Console.ReadKey(true);                    
                }
                else
                {
                    DisplayTitleScreen();
                }
            }               
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
            if (!File.Exists(savePath))
            {
                Console.Clear();
                Console.WriteLine("Save file has been corrupted or does not exist");                
                Console.ReadKey(true);
                DisplayTitleScreen();
            }
            else if (File.ReadAllText(savePath) == "")
            {
                Console.Clear();
                Console.WriteLine("No save data");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                DisplayTitleScreen();
            }
            else
            {
                currentPage = int.Parse(File.ReadAllText(savePath));
            }
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
                gameOver = true;
            }
            else
            {
                Console.WriteLine("please input valid character");
                Console.ReadKey(true);
                DisplayTitleScreen();                
            }

        }

        static void SplitPage()
        {
            splitPage = story[currentPage].Split(splitChars);
            if (splitPage[0] == "")
            {
                Console.WriteLine("Error: Page is blank");
                Console.WriteLine("Console will now close");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
           else
            {
                splitLine = splitPage[0].Split('#');
            }
                
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
                Console.Clear();
                Console.WriteLine("Game saved");
                Console.ReadKey(true);
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
            }
            else if (input.KeyChar == 'l' || input.KeyChar == 'L')
            {
                Console.Clear();
                LoadGame();
                Gameplay();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please input valid character");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            }
        }

        static void DisplayTitleScreen()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("   ▄▄▄▄▄   ▄███▄   █     ▄███▄   ▄█▄      ▄▄▄▄▀        ▄▄▄▄▀ ▄  █ ▄█    ▄   ▄███▄       █ ▄▄  ▄███▄   █▄▄▄▄   ▄▄▄▄▄   ████▄    ▄   ██   █         ██   ██▄       ▄   ▄███▄      ▄     ▄▄▄▄▀ ▄   █▄▄▄▄ ▄███▄       ");
            Console.WriteLine("  █     ▀▄ █▀   ▀  █     █▀   ▀  █▀ ▀▄ ▀▀▀ █        ▀▀▀ █   █   █ ██     █  █▀   ▀      █   █ █▀   ▀  █  ▄▀  █     ▀▄ █   █     █  █ █  █         █ █  █  █       █  █▀   ▀      █ ▀▀▀ █     █  █  ▄▀ █▀   ▀      ");
            Console.WriteLine("▄  ▀▀▀▀▄   ██▄▄    █     ██▄▄    █   ▀     █            █   ██▀▀█ ██ ██   █ ██▄▄        █▀▀▀  ██▄▄    █▀▀▌ ▄  ▀▀▀▀▄   █   █ ██   █ █▄▄█ █         █▄▄█ █   █ █     █ ██▄▄    ██   █    █  █   █ █▀▀▌  ██▄▄        ");
            Console.WriteLine(" ▀▄▄▄▄▀    █▄   ▄▀ ███▄  █▄   ▄▀ █▄  ▄▀   █            █    █   █ ▐█ █ █  █ █▄   ▄▀     █     █▄   ▄▀ █  █  ▀▄▄▄▄▀    ▀████ █ █  █ █  █ ███▄      █  █ █  █   █    █ █▄   ▄▀ █ █  █   █   █   █ █  █  █▄   ▄▀     ");
            Console.WriteLine("           ▀███▀       ▀ ▀███▀   ▀███▀   ▀            ▀        █   ▐ █  █ █ ▀███▀        █    ▀███▀     █                   █  █ █    █     ▀        █ ███▀    █  █  ▀███▀   █  █ █  ▀    █▄ ▄█   █   ▀███▀       ");
            Console.WriteLine("                                                              ▀      █   ██               ▀            ▀                    █   ██   █              █           █▐           █   ██        ▀▀▀   ▀                ");
            Console.WriteLine("                                                                                                                                    ▀              ▀            ▐                                                 ");
            Console.WriteLine("");
            MainMenu();
        }

        static void Gameplay()
        {
            Console.Clear();

            while (gameOver == false)
            {
                SplitPage();
                DisplayStory();
                TakeInput();
                Console.Clear();
                if (story[currentPage] == story[14])
                {
                    DisplayTitleScreen();                    
                }
            }
        }
    }
}
