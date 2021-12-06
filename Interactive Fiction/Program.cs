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
            //Console.WriteLine("");
            //Console.WriteLine("   ▄▄▄▄▄   ▄███▄   █     ▄███▄   ▄█▄      ▄▄▄▄▀        ▄▄▄▄▀ ▄  █ ▄█    ▄   ▄███▄       █ ▄▄  ▄███▄   █▄▄▄▄   ▄▄▄▄▄   ████▄    ▄   ██   █         ██   ██▄       ▄   ▄███▄      ▄     ▄▄▄▄▀ ▄   █▄▄▄▄ ▄███▄       ");
            //Console.WriteLine("  █     ▀▄ █▀   ▀  █     █▀   ▀  █▀ ▀▄ ▀▀▀ █        ▀▀▀ █   █   █ ██     █  █▀   ▀      █   █ █▀   ▀  █  ▄▀  █     ▀▄ █   █     █  █ █  █         █ █  █  █       █  █▀   ▀      █ ▀▀▀ █     █  █  ▄▀ █▀   ▀      ");
            //Console.WriteLine("▄  ▀▀▀▀▄   ██▄▄    █     ██▄▄    █   ▀     █            █   ██▀▀█ ██ ██   █ ██▄▄        █▀▀▀  ██▄▄    █▀▀▌ ▄  ▀▀▀▀▄   █   █ ██   █ █▄▄█ █         █▄▄█ █   █ █     █ ██▄▄    ██   █    █  █   █ █▀▀▌  ██▄▄        ");
            //Console.WriteLine(" ▀▄▄▄▄▀    █▄   ▄▀ ███▄  █▄   ▄▀ █▄  ▄▀   █            █    █   █ ▐█ █ █  █ █▄   ▄▀     █     █▄   ▄▀ █  █  ▀▄▄▄▄▀    ▀████ █ █  █ █  █ ███▄      █  █ █  █   █    █ █▄   ▄▀ █ █  █   █   █   █ █  █  █▄   ▄▀     ");
            //Console.WriteLine("           ▀███▀       ▀ ▀███▀   ▀███▀   ▀            ▀        █   ▐ █  █ █ ▀███▀        █    ▀███▀     █                   █  █ █    █     ▀        █ ███▀    █  █  ▀███▀   █  █ █  ▀    █▄ ▄█   █   ▀███▀       ");
            //Console.WriteLine("                                                              ▀      █   ██               ▀            ▀                    █   ██   █              █           █▐           █   ██        ▀▀▀   ▀                ");
            //Console.WriteLine("                                                                                                                                    ▀              ▀            ▐                                                 ");
            //Console.WriteLine("");
            //Console.WriteLine("Press any key to continue");
            //Console.ReadKey(true);
            //Console.Clear();
            DisplayTitleScreen();

            Gameplay();
        }

        static int currentPage;
        static string[] story = new string[17]; 
        static bool GameOver = false; 
        static string[] splitPage;
        static char[] splitChars = { ';' };
        int len;

        static void InitStory()
        {
            story[0] = ";;;;"; 
            story[1] = "You find yourself at the doorway of a dilapidated church, crucifix in your left hand, a wooden stake in the right. \nYour prey was sighted last at this church four hours prior when it attacked an ongoing funeral. None made it out alive. \n\nExcept for you...;enter church;pray for strength;1;2"; 
            story[2] = "You walk through the front doors of the church and you're met with an alarming sense of dread. \nPews are overturned, the alter is on the other side of the room, and a statue of Jesus has been toppled. \n\nTo your left is a stairway leading to the priests quarters... \n\nYour quarters.;go to the statue of Jesus;go upstairs;3;6";
            story[3] = "You kneel with your head bowed, and recite \n\n\"Touch me, O Lord, and fill me with your light and your hope. \nDear God, please give me strength when I am weak, \nlove when I feel forsaken, \ncourage when I am afraid, \nwisdom when I feel foolish, \ncomfort when I am alone, \nhope when I feel rejected, \nand peace when I am in turmoil. \n\nAmen.\"\n\nAt that moment you hear a screech above you, from a broken window on the second floor \n\nCertainly not from a human;enter the church;turn around and leave;1;13"; 
            story[4] = "You approach the overturned statue. \nHis head fell off at the neck when it hit the marble floor. \n\nBehind you theres a bang, and you feel a presence closing the distance behind you.;turn and attack with your stake;turn and defend yourself with your crucifix;4;5";
            story[5] = "Your poorly aimed thrust is batted away with ease, and you feel fangs sink into your skin just above the collarbone. \n\nYou die before seeing what the hellspawn even looked like;restart;quit;0;14";
            story[6] = "As if guided by the lord himself, the hand holding his iconography lurches behind you, and your body follows through. \n\nA shriek pierces your ears as your foe recoils and sheilds it's eyes.\n\nThe beast before you barely resembles the human they used to be... \n\nThe Vampire's pale, blotched skin showcases the crooked joints and broken bones under it's surface \nlike the thin veil of the widow he had devoured only hours earlier.;recite prayer;attack with stake;9;10";
            story[7] = "You start up the the stairs that used to make you feel at home. But now you barely recognize it. \n\nAs you approach your quarter's door, your sense of dread peaks.;turn back;enter your quarters;7;8";
            story[8] = "Your sense of dread overcomes you, and you start back down the stairs. \n\nHalfway down, you hear your own door open. \nSuddenly, you hear whatever did open it break into a sprint down the stairs behind you. \n\nYou pick up your pace. \n\nBy the time you reach the bottom, you sense your assailant directly behind you.;turn and attack with your stake;turn and defend yourself with your crucifix;4;5";
            story[9] = "Inside your quarters you find the remains of the days funeral. \n\nNearly two dozen- half devoured, half drained, and half dead funeral goers have been lazily piled on the floor of your home. \n\nYour holy place of rest has become a grotesque treasure trove of flesh. \n\nBefore your body can react to what you just witnessed, two beastly hands grab you from above, claws sinking into your throat and cheek, \nlifting you off your feet and tearing your neck. \n\nYour only shot at saving countless lives ends here.;restart;quit;0;14";
            story[10] = "\"In the Name of Jesus Christ, \nour God and Lord, \nstrengthened by the intercession of the Immaculate Virgin Mary, \nMother of God,\" \n\nThe beast recoils further, shreiking like a banshee.;continue praying;attack with stake;11;10";
            story[11] = "You make an attempt to thrust at the beast, but as soon as you lower your crucifix the monster lunges in the blink of an eye- \n\nCrushing your chest immedietly.;restart;quit;0;14";
            story[12] = "\"We drive you from us, whoever you may be, \nunclean spirits, \nall satanic powers, \nall infernal invaders, \nall wicked legions, assemblies and sects.\" \n\nThe vampire falls on its back, writhing in pain, and lashing in every direction. \nIt's skin seems to smolder, and it's eyes wildly roll around in its head.;continue praying;attack with stake;15;12";
            story[13] = "You see your window to slay the entity, and press your advantage. \nIn the blink of an eye you manage to close the gap between yourself and your foe. \n\nYou plunge your wooden stake into the chest of the beast, it's brittle rib cage collapsing in and piercing its lungs \n\nThis time there is no scream to fill the silent void in your old home. \n\nYou drop to your knees, shaking. \n\nYou've done it;replay;quit;0;14";
            story[14] = "You decide a life of religion wasn't worth it anyways and abandon your community. \nOnly a month later you're found dead in the woods because you're a rube with no foraging skills and managed to poision yourself with toxic mushrooms.;restart;quit;0;14";
            story[15] = ";;;;"; // death state
            story[16] = "\"Stoop beneath the all-powerful Hand of God. \nTremble and flee when we invoke the Holy and terrible Name of Jesus, \nthis Name which causes hell to tremble, \nthis Name to which the Virtues, Powers and Dominations of heaven are humbly submissive, \nthis Name which the Cherubim and Seraphim praise unceasingly repeating: \nHoly, Holy, Holy is the Lord, the God of Hosts.\" \n\nThe creature lets out one final cry of pain, straining it's body against an invisible holy power. \nSuddenly it all stops. The crying, the panic, and the straining all cease in unison. \n\nBefore you lies a naked, middle aged man. His body no longer distorted by his unholy affliction. \n\nYou lean down to inspect the unconscious body, starting of course with his mouth. \nInside you find a set of perfectly human teeth. \n\nYou saved at least one soul tonight.;replay;quit;0;14";
        }

        static void SplitPage()
        {
            splitPage = story[currentPage].Split(splitChars);            
        }

        static void DisplayStory()
        {
            //int len2 = 5;
            //int counter = 0;
            string PageScroll = splitPage[0];
            int len = PageScroll.Length;

            for (int i = 0; i < len; i++)
                {
                    Console.Write(PageScroll[i]);
                    System.Threading.Thread.Sleep(1);
                }

            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press A to: " + splitPage[1]);
            Console.WriteLine("-OR-");
            Console.WriteLine("Press B to: " + splitPage[2]);
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
            if (input.KeyChar == 'a' || input.KeyChar == 'A')
            {
                currentPage = int.Parse(splitPage[3]);
                Console.Beep(525, 100);
            }
            else if (input.KeyChar == 'b' || input.KeyChar == 'B')
            {
                currentPage = int.Parse(splitPage[4]);
                Console.Beep(500, 100);
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
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
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
    }
}
