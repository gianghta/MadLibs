using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision;
            bool hasEnterValidInput;
            Game myGame = new Game();

            //Intro
            Console.WriteLine("Welcome to MadLibs the game");
            Console.WriteLine("Please enter prompts that you are asked for a crazy story");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();
            do
            {
                //Presenting menu and prompting the user to enter options for story
                Console.WriteLine("Enter 1 to choose the Hound of Baskerville version");
                //Asking for input into MadLibs
                hasEnterValidInput = Int32.TryParse(Console.ReadLine(), out decision);
                if(hasEnterValidInput)
                {
                    if(decision == 1)
                    {
                        myGame.Baskerville.PrintEditedStory();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            } while (hasEnterValidInput);

            Console.ReadKey();
        }
    }
}
