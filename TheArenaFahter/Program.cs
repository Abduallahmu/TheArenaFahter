using System;

namespace TheArenaFighter
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("¤¤¤((Welcome The Arena Fighter))¤¤¤");

            Console.ForegroundColor = ConsoleColor.White;
            Battle Arenabattle = new Battle();

            Console.WriteLine("Enter Player Your name:\n");
            String naruto = Console.ReadLine();

            Character player = new Character(naruto);
            Console.WriteLine("Name:" + naruto);
            Console.WriteLine("Health:" + player.health);
            Console.WriteLine("Damage:" + player.damage);
            Console.WriteLine("power:" + player.power);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What do you want to do?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter 1 -  To Hunt for an Opponent:");
            Console.WriteLine("Enter 2 - To Retire from fighting:");
            String nummer1 = Console.ReadLine();
            String nummer2 = Console.ReadLine();
            Console.Clear();


            if (nummer1 == "1")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Name:" + naruto);
                Console.WriteLine("Health:" + player.health);
                Console.WriteLine("Damage:" + player.damage);
                Console.WriteLine("power:" + player.power);


                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Character opponent = new Character();
                Console.WriteLine("Opponent:" + opponent.Name);
                Console.WriteLine("Health:" + opponent.health);
                Console.WriteLine("Damage:" + opponent.damage);
                Console.WriteLine("power:" + opponent.power);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Arenabattle.CheckHealth(player, opponent);

                Console.Clear();

            }

            else nummer2 = "2";
            {
                Console.WriteLine("[You Decided not to Fight]");
                Console.WriteLine(player.Name + " " + " score : 0");
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();

            }

        }
    }
}