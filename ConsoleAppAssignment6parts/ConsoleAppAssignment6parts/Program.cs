using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment6parts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] charClass = new string[7];
            charClass[0] = "warrior";
            charClass[1] = "cleric";
            charClass[2] = "rogue";
            charClass[3] = "wizard";
            charClass[4] = "ranger";
            charClass[5] = "bard";
            charClass[6] = "paladin";

            Console.WriteLine("Let's go on a dungeon crawling adventure!");
            Console.WriteLine();
            Console.WriteLine("Chose you race: human, elf, dwarf, gnome, halfling.");
            string inputText = Console.ReadLine();

            int counter = 10;

            while(true) // Infinite Loop
            {
                Console.Write("*");
                if (counter < 1)
                    break; // Infinite Loop Fix

                counter--;
            }

            Console.WriteLine();

            int i = 0;
            while(i < charClass.Count())
            {
                string item = charClass[i];
                item = inputText + " " + item;
                charClass[i] = item;
                i++;
            }

            Console.WriteLine("You can be these classes:");

            for (int x = 0; x < charClass.Length; x++)
            {
                Console.WriteLine(charClass[x]);
            }

            Console.WriteLine();

            Console.WriteLine("You enter a room with several chests.");

            List<string> weapons = new List<string> { "sword", "flail", "dagger", "staff", "bow", "rapier", "mace" };
            Console.WriteLine("What weapon do you search for?");
            string inputWeapon = Console.ReadLine();

            bool containsWeapon = false;
            for(int w = 0; w < weapons.Count; w++)
            {
                string item = weapons[w];
                if (item.Equals(inputWeapon))
                {
                    Console.WriteLine("You find a " + inputWeapon + " in chest #" + ((int)(w + 1)).ToString() + ".");
                    containsWeapon = true;
                    break;
                }

            }
            if (!containsWeapon)
            {
                Console.WriteLine("Sorry, you do not find a " + inputWeapon + " in any of the chests.");
            }

            Console.WriteLine();

            List<string> armor = new List<string> { "plate", "mail", "leather", "cloth", "mail", "plate" };
            Console.WriteLine("What type of armore do you search for?");
            string inputArmor = Console.ReadLine();
            List<int> armorMatches = new List<int>();

            bool containsArmor = false;
            for (int a =0; a < armor.Count; a++)
            {
                string item = armor[a];
                if (item.Equals(inputArmor))
                {
                    armorMatches.Add(a + 1);
                    containsArmor = true;
                }

            }
            if (containsArmor)
            {
                string formatMatches = String.Join(" and ", armorMatches.ToArray());
                Console.WriteLine("You find " + inputArmor + " armor in chest #" + formatMatches + ".");
            }

            else
            {
                Console.WriteLine("Sorry, no " + inputArmor + " armor is found in any of the chests.");
            }

            Console.WriteLine();

            Console.WriteLine("Suddenly, these monsters rush in and attack!");
            List<string> mobs = new List<string> { "goblin", "hobgoblin", "skeleton", "zombie", "ghoul", "goblin", "skeleton" };
            List<string> matchedMobs = new List<string>();
            foreach(string item in mobs)
            {
                bool containsMatch = matchedMobs.Contains(item);
                if(containsMatch)
                {
                    Console.WriteLine("Uh oh! Another" + item + " has entered the room.");
                }
                else
                {
                    Console.WriteLine(item);
                    matchedMobs.Add(item);
                }

            }

            Console.WriteLine();
            Console.WriteLine("I would run if I were you!");
            Console.ReadLine();
        }
    }
}
