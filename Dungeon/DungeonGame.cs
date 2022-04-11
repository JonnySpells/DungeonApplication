using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DungeonMonsterLibrary;

namespace Dungeon
{
    internal class DungeonGame
    {
        static void Main(string[] args)
        {
            Console.Title = "Catalyst :3";

            Console.WriteLine("May The Force Be With You");

            
            int score = 0;

            
            Console.WriteLine("");

            //Game loop
            bool loopGame = true;
            do
            {
                //TODO Create Player
                
                //Encounter loop
                bool loopEncounter = true;

                Weapon longSword = new Weapon(1, 8, "Long Sword", 10, false, WeaponType.Lightsaber);
                Player userPlayer = new Player("Jedi Guardian", 30, 30, 30, 30, "Zabraak", longSword);



                do
                {

                    //TODO: CreateMonster
                    
                    //TODO: CreateRoom // GetRoom is creating a string, and is stori
                    string currentRoom = MethodWarehouse.GetRoom();
                    Monster monster = new Monster("Dark Jedi", 10, 10, 10, 10, 10, 1, "Sith");



                    //Menu loop
                    bool loopMenu = true;
                    do
                    {


                        Console.WriteLine(
                            "1) Attack\n" +
                            "2) Run Away\n" +
                            "3) Character Info\n" +
                            "4) Monster Info\n" +
                            "5) Exit");
                        string menuSelect = "";

                        menuSelect = Console.ReadKey(true).Key.ToString();
                        Console.WriteLine(menuSelect);
                        //Console.Clear();
                        switch (menuSelect)
                        {
                            case "D1":
                            case "NumPad1":
                                Console.WriteLine("* You Swing your lightsaber *");
                                Kombat.DoBattle(userPlayer, monster);

                                if (monster.Life <= 0)
                                {

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("\nYou killed {0}!\n", monster.Name);

                                    Console.ResetColor();

                                    score++;

                                    loopMenu = true;


                                }

                                break;
                            case "D2":
                            case "NumPad2":
                                Console.WriteLine("Run Away Option");
                                Console.WriteLine($"{monster.Name} attacks you as you flee!");                                                                                                                             
                                
                                loopMenu = !loopMenu;
                                break;
                            case "D3":
                            case "NumPad3":
                                Console.WriteLine("Character Info Option");
                                break;
                            case "D4":
                            case "NumPad4":
                                Console.WriteLine("Monster Info Option");
                                break;
                            case "D5":
                            case "NumPad5":
                                Console.WriteLine("Dont give up hope. May the Force be with you.");
                                loopMenu = !loopMenu;
                                loopEncounter = !loopEncounter;
                                loopGame = !loopGame;

                                break;
                            default:
                                Console.WriteLine("Input Not Valid.");
                                break;


                        }
                        //Random rand = Random





                    } while (loopMenu);





                } while (loopEncounter);

                


            } while (loopGame);


        }
    }
}
