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
            PlayMusic();
            Console.ReadKey(true);
            Console.Clear();
            Gameplay();
        }

        static int currentPage;
        static string[] story = new string[15]; 
        static bool GameOver = false; 
        static string[] splitPage;
        static char[] splitChars = { ';' };

        static void InitStory()
        {
            story[0] = "You find yourself at the doorway of a dilapidated church, crucifix in your left hand, a wooden stake in the right. \nYour prey was sighted last at this church four hours prior when it attacked an ongoing funeral. None made it out alive. \n\nExcept for you...;enter church;pray for strength;1;2"; 
            story[1] = "You walk through the front doors of the church and you're met with an alarming sense of dread. \nPews are overturned, the alter is on the other side of the room, and a statue of Jesus has been toppled. \n\nTo your left is a stairway leading to the priests quarters... \n\nYour quarters.;go to the statue of Jesus;go upstairs;3;6";
            story[2] = "You kneel with your head bowed, and recite \n\n\"Touch me, O Lord, and fill me with your light and your hope. \nDear God, please give me strength when I am weak, \nlove when I feel forsaken, \ncourage when I am afraid, \nwisdom when I feel foolish, \ncomfort when I am alone, \nhope when I feel rejected, \nand peace when I am in turmoil. \n\nAmen.\"\n\nAt that moment you hear a screech above you, from a broken window on the second floor \n\nCertainly not from a human;enter the church;turn around and leave;1;13"; 
            story[3] = "You approach the overturned statue. \nHis head fell off at the neck when it hit the marble floor. \n\nBehind you theres a bang, and you feel a presence closing the distance behind you.;turn and attack with your stake;turn and defend yourself with your crucifix;4;5";
            story[4] = "Your poorly aimed thrust is batted away with ease, and you feel fangs sink into your skin just above the collarbone. \n\nYou die before seeing what the hellspawn even looked like;restart;quit;0;14";
            story[5] = "As if guided by the lord himself, the hand holding his iconography lurches behind you, and your body follows through. \n\nA shriek pierces your ears as your foe recoils and sheilds it's eye.s\n\nThe beast before you barely resembles the human they used to be... \n\nThe Vampire's pale, blotched skin showcases the crooked joints and broken bones under it's surface \nlike the thin veil of the widow he had devoured only hours earlier.;recite prayer;attack with stake;9;10";
            story[6] = "You start up the the stairs that used to make you feel at home. But now you barely recognize it. \n\nAs you approach your quarter's door, your sense of dread peaks.;turn back;enter your quarters;7;8";
            story[7] = "Your sense of dread overcomes you, and you start back down the stairs. \n\nHalfway down, you hear your own door open. \nSuddenly, you hear whatever did open it break into a sprint down the stairs behind you. \n\nYou pick up your pace. \n\nBy the time you reach the bottom, you sense your assailant directly behind you.;turn and attack with your stake;turn and defend yourself with your crucifix;4;5";
            story[8] = "Inside your quarters you find the remains of the days funeral. \n\nNearly two dozen- half devoured, half drained, and half dead funeral goers have been lazily piled on the floor of your home. \n\nYour holy place of rest has become a grotesque treasure trove of flesh. \n\nBefore your body can react to what you just witnessed, two beastly hands grab you from above, claws sinking into your throat and cheek, \nlifting you off your feet and tearing your neck. \n\nYour only shot at saving countless lives ends here.;restart;quit;0;14";
            story[9] = "\"In the Name of Jesus Christ, \nour God and Lord, \nstrengthened by the intercession of the Immaculate Virgin Mary, \nMother of God,\" \n\nThe beast recoils further, shreiking like a banshee.;continue praying;attack with stake;11;10";
            story[10] = "You make an attempt to thrust at the beast, but as soon as you lower your crucifix the monster lunges in the blink of an eye- \n\nCrushing your chest immedietly.;restart;quit;0;14";
            story[11] = "\"We drive you from us, whoever you may be, \nunclean spirits, \nall satanic powers, \nall infernal invaders, \nall wicked legions, assemblies and sects.\" \n\nThe vampire falls on its back, writhing in pain, and lashing in every direction.;;;;";
            story[12] = ";;;;";
            story[13] = "You decide a life of religion wasn't worth it anyways and abandon your community. \nOnly a month later you're found dead in the woods because you're a rube with no foraging skills and managed to poision yourself with toxic mushrooms.;restart;quit;0;14";
            story[14] = ";;;;";
        }

        static void SplitPage()
        {
            splitPage = story[currentPage].Split(splitChars);            
        }

        static void DisplayStory()
        {
            Console.WriteLine(splitPage[0]);
            Console.WriteLine();

            Console.WriteLine("__________________________________");
            Console.WriteLine("Press A to: " + splitPage[1]);
            Console.WriteLine("-OR-");
            Console.WriteLine("Press B to: " + splitPage[2]);
            Console.WriteLine("__________________________________");
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
                Console.Beep(125, 100);
            }
            else if (input.KeyChar == 'b' || input.KeyChar == 'B')
            {
                currentPage = int.Parse(splitPage[4]);
                Console.Beep(100, 100);
            }
            else
            {
                Console.WriteLine("please input valid character");
                Console.ReadKey(true);
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
                if (story[currentPage] == story[14])
                {
                    GameOver = true;
                }
            }
        }
        static void PlayMusic()
        {
            
        }
    }
}
