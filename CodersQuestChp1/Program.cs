using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersQuestChp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 1;
            bool keepGoing = true;
            bool haskey = false;
            string input = null;

            while (keepGoing == true)
            {
                if (pos == 1)
                {
                    Console.WriteLine("You are in a dungeon. You must find your way out.");
                    Console.WriteLine("You can go South. (s)");
                    input = Console.ReadLine();
                    if (input == "s")
                    {
                        pos = 2;
                    }
                }
                else if (pos == 2)
                {
                    Console.WriteLine("There is a spider web here.");
                    Console.WriteLine("You can go North or East. (n/e)");
                    input = Console.ReadLine();
                    if (input == "n")
                    {
                        pos = 1;
                    }
                    else if (input == "e")
                    {
                        pos = 3;
                    }
                }
                else if (pos == 3)
                {
                    Console.WriteLine("There is a small pool of water here.");
                    Console.WriteLine("You can go North, East, or West. (n/e/w)");
                    input = Console.ReadLine();
                    if (input == "n")
                    {
                        pos = 4;
                    }
                    else if (input == "e")
                    {
                        pos = 5;
                    }
                    else if (input == "w")
                    {
                        pos = 2;
                    }
                }
                else if (pos == 4)
                {
                    Console.WriteLine("You are standing in front of a wooden door.");
                    Console.WriteLine("You can go south or open the door. (s/open door)");
                    input = Console.ReadLine();
                    if (input == "s")
                    {
                        pos = 3;
                    }
                    else if (input == "open door")
                    {
                        haskey = true;
                        Console.WriteLine("You have picked up a key.");
                    }
                }
                else if (pos == 5)
                {
                    Console.WriteLine("There is a wooden door in front of you.");
                    Console.WriteLine("You can go west or open the door. (w/open door)");
                    input = Console.ReadLine();
                    if (input == "w")
                    {
                        pos = 3;
                    }
                    else if (input == "open door")
                    {
                        Console.WriteLine("The door is locked.");
                        if (haskey == true)
                        {
                            Console.WriteLine("Would you like to use your key? (y/n)");
                            input = Console.ReadLine();
                            if (input == "y")
                            {
                                Console.WriteLine("You are out of the dungeon.");
                                Console.ReadLine();
                                keepGoing = false;
                            }
                            else if (input == "n")
                            {
                                Console.WriteLine("WHAT ARE YOU THINKING?! USE THAT KEY!");
                                Console.WriteLine("Would you like to use your key? (y)");
                                input = Console.ReadLine();
                                if (input == "y")
                                {
                                    Console.WriteLine("You are out of the dungeon.");
                                    Console.ReadLine();
                                    keepGoing = false;
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}