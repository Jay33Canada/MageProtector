using System;
using System.Threading;
using System.Timers;

namespace MageProtector
{
    class Program
    {
        static void Main(string[] args)
        {
            // show the intro
            Introduction intro = new Introduction();
            // make a new player
            PlayerMage Player = new PlayerMage();
            // make the first enemy to fight
            EnemyMage EasyEnemy = new EnemyMage();
            // let them fight. if the player wins, display a little message for story, then move on to the next enemy
            Fight(Player, EasyEnemy);
            // story message
            // next enemy
            // story  message
            // last enemy aka final boss

            //end of game
        }
        static void Fight(PlayerMage player, EnemyMage enemy)
        {
            // while the battle is still going. while no one has died
            bool battleOn = true;
            while (battleOn)
            {
                // display current situation of stats 
                // ask what the player wants to do
                int playerChose = PlayerChose(player, enemy);
                Console.Clear();
                //Console.ReadLine();
                if( playerChose == 1)
                {
                    Console.WriteLine(player.name + " hits " + enemy.name + " for " + player.attackPower + " damage!");
                    enemy.ChangeDefense(-player.attackPower);
                    Thread.Sleep(2000);
                    Console.Clear();
                    //Console.ReadLine();
                }
                else if( playerChose == 2)
                {
                    Console.WriteLine(player.name + " heals for " + player.healAmount);
                    player.Heal();
                    Console.WriteLine("Your health is now at " + player.defenseNumber);
                    Thread.Sleep(2500);
                }
                // this else if statement will only run once.  thanks to some code in the playerChose method
                else if( playerChose == 3)
                {
                        player.Shield();
                        Console.WriteLine(player.name + " has used the one time shield for " + player.defenseNumber);
                        Console.WriteLine("Your health is now at " + player.defenseNumber);
                        Thread.Sleep(2500);
                        Console.Clear();
                }
                if (enemy.defenseNumber <= 0)
                {
                    battleOn = false;
                    Console.WriteLine(enemy.name + " has been defeated!");
                }
                

            }
            
        }

        

        static int PlayerChose(PlayerMage player, EnemyMage enemy)
        {
            bool goodInput = false;
            int choice = 0;
            while (goodInput == false)
            {
                try
                {
                    // show them the player stats and what their options are
                    player.DisplayAttributes();
                    enemy.DisplayAttributes();
                    Console.WriteLine("Choose your next move:");
                    // if they haven't used the shield, display option for shield
                    if (player.shieldUsed == false)
                    {
                        Console.WriteLine("Attack: 1\n" +
                        "Heal: 2\n" +
                        "Shield: 3 (one time use)\n");
                    }
                    // if they have used the shield, remove the option
                    else
                    {
                        Console.WriteLine("Attack: 1\n" +
                        "Heal: 2\n");
                    }
                    // get their input
                    choice = Convert.ToInt32(Console.ReadLine());
                    
                    if (choice == 1)
                    {
                        goodInput = true;
                    }
                    else if (choice == 2)
                    {
                        goodInput = true;
                    }
                    else if (choice == 3)
                    {
                        // if they haven't used the shield, it's a good input
                        if (player.shieldUsed == false)
                        {
                            goodInput = true;
                        }
                        // if they have used the shield, it's not a good input
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You've already used your shield");
                            goodInput = false; // redundant, but just to remind myself what's happening more less
                            // goodInput staying false will let the while loop run again to get a new choice
                        }
                            
                    }
                    // if they didn't enter 1, 2, or 3, rerun the while loop to  
                    // clear the console to redisplay the stats and give options again
                    else 
                    { 
                        Console.Clear(); 
                        continue; 
                    }
                }
                catch 
                {
                    Console.Clear(); 
                    continue; 
                }
            }
            return choice;
        }
    }
}
