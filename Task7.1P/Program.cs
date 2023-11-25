using System;
using System.Numerics;

namespace Iteration6
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of your player: ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter the description of your player: ");
            string description = Console.ReadLine();
            Player p = new Player(name, description);
            Location l = new Location("Hallway", "This is a long well lit hallway");
            Item gem = new Item(new string[] { "gem" }, "gem", "A bright red gem");
            Item sword = new Item(new string[] { "sword" }, "sword", "A Big bronze sword");
            p.Inv.Put(gem);
            p.Inv.Put(sword);
            


            Bag b = new Bag(new string[] { "bag" }, "bag", "That is a leather bag");
            p.Inv.Put(b);
            l.Inv.Put(gem);
            p.Loc = l;
            Item box = new Item(new string[] { "box" }, "box", "A big box");
            b.Inv.Put(box);

            bool exit = false;
            LookCommand look = new LookCommand();
            while (!exit)
            {
                Console.WriteLine("\nType your command here ==> ");
                string command = Console.ReadLine();
                if (command == "exit")
                {
                    exit = true;

                }
               
                else
                {
                    Console.WriteLine(look.Execute(p, command.Split()));
                }
            }
            
        }
    }
}



