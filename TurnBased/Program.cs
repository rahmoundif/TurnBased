using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBased
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
___________                 __________                          .___
\__    ___/_ _________  ____\______   \_____    ______ ____   __| _/
  |    | |  |  \_  __ \/    \|    |  _/\__  \  /  ___// __ \ / __ | 
  |    | |  |  /|  | \/   |  \    |   \ / __ \_\___ \\  ___// /_/ | 
  |____| |____/ |__|  |___|  /______  /(____  /____  >\___  >____ | 
                           \/       \/      \/     \/     \/     \/");

            int playerHp = 50;
            int enemyHp = 50;

            int playerAttack = 10;
            int enemyAttack = 15;

            int heal = 10;
            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                Console.WriteLine("--- Players Turn ---");
                Console.WriteLine(" Player hp - " + playerHp + ". Enemy hp -" + enemyHp );
                Console.WriteLine("Type 'A' to attack or 'H' to Heal");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("the player attacks the enemy and the enemy takes " + playerAttack + "damage");
                }
                else if (choice == "h") {
                    playerHp += heal;
                    Console.WriteLine("The player Heals himself and gets back" + heal + "HP");
                }else
                    Console.WriteLine("Nothing happens, use either 'A' or 'H' ");
                {
                }
                if (enemyHp > 0)
                {
                    Console.WriteLine("--- Enemy Turn ---");
                    Console.WriteLine(" Player hp - " + playerHp + ". Enemy hp -" + enemyHp);

                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {

                        playerHp -= enemyAttack;
                        Console.WriteLine("The enemy attack the player and the players takes " + enemyAttack + "damage");
                    }

                    else
                    {
                        enemyHp += heal;
                        Console.WriteLine("The enemy heals himself and gets back " + heal + "HP");
                    }
                }
                }
                if (playerHp <= 0)
                {
                    Console.WriteLine("Player Fainted");
                    Console.WriteLine("The enemy Stomps on your body");
                }
                if (enemyHp <= 0)
                {
                    Console.WriteLine("The enemy vanished");
                    Console.WriteLine("The player goes to the pub");
                }

            }
        }
    }

