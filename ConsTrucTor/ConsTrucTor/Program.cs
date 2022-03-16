using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTrucTor
{
    public class Program
    {
        const string GameName = "Welcome to game";

        static Program()
        {
            Console.WriteLine(GameName);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter your character name: ");
            var player = new Player(Console.ReadLine());
            Console.WriteLine("\nPlayer ID: " + player.Id.ToString());
            Console.WriteLine("Character Name: " + player.Name);
            Console.ReadLine();
        }
    }

    public class Player
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Player()
        {
            this.Id = Guid.NewGuid();
        }

        public Player(string name) : this()
        {
            this.Name = name;
        }
    }
}
