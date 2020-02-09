using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MageProtector
{
    class Introduction
    {
        public Introduction()
        {
            Console.WriteLine("Welcome to Mage Protector!\n");
            Console.WriteLine("Would you like to read the lure, or get right to the action?");
            Console.WriteLine("Type \"lure\" for the story.");
            Console.WriteLine("Type \"fight\" for the battle to begin.\n");
            PlayerChoice();
        }
        static void PlayerChoice()
        {
            // check to see if they've entered the right input
            // if they haven't, prompt them again
            bool properStringEntered = false;
            while (properStringEntered == false)
            {
                try
                {
                    // get their input
                    string playerChoice = Console.ReadLine();
                    // if it's lure, show story
                    if (playerChoice == "lure")
                    {
                        Console.Clear();
                        Console.WriteLine("The City of Regular Folks is under attack! \n" +
                            "Three mysterious mages have appeared and want to harm the innocent people of the City.\n" +
                            "Will you fight off the mages and save the day?!\n" +
                            "Let's find out...\n\n\n\n..Hit enter to continue..");
                        Console.ReadLine();
                        properStringEntered = true;
                    }
                    // if it's fight, display a message saying they chose to fight, and do nothing because they next thing to run 
                    // in the program will be the code for the first battle
                    else if (playerChoice == "fight")
                    {
                        Console.Clear();
                        Console.WriteLine("Let's get right to it then!\n\n\n\n..Hit enter to continue..");
                        Console.ReadLine();
                        properStringEntered = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Type \"lure\" for the story.");
                        Console.WriteLine("Type \"fight\" for the battle to begin.");
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
