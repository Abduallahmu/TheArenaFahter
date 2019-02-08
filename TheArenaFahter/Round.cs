using System;
using System.Collections.Generic;
using System.Text;

namespace TheArenaFighter
{
    class Round
    {

        public Character player;
        public Character opponent;
        Battle Arenabattle;

        public int Fight(Character player1, Character opponent1, Battle battle)
        {
            this.Arenabattle = battle;
            Random rnd = new Random();
            player = player1;
            opponent = opponent1;


            while (player.Health > 0 && opponent.Health > 0)
            {

                int dice1 = rnd.Next(20, 30);
                int dice2 = rnd.Next(10, 15);

                player.Power = dice1;
                opponent.Power = dice2;


                Console.WriteLine(player.Name + " " + " Power " + " " + player.Power + " " + opponent.Name + " " + " Power " + " " + opponent.Power);

                if (player.Power > opponent.Power)
                {

                    Console.WriteLine("Press enter to attack : " + " " + opponent.Name);
                    Console.ReadLine();

                    opponent.Health = opponent.Health - player.damage;



                    Console.WriteLine(player.Name + " " + " Health " + player.Health + " " + opponent.Name + " Health " + opponent.Health);
                    Console.WriteLine("¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(player.Name + " " + "You won the Game");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤-¤");

                    Console.ReadLine();
                }

                if (opponent.Power > player.Power)
                {
                    Console.WriteLine("Press enter to attack : " + " " + player.Name);
                    Console.ReadLine();

                    player.Health = player.Health - opponent.damage;

                    Console.WriteLine(player.Name + " " + " Health " + player.Health + " " + opponent.Name + " Health " + opponent.Health);
                    Console.ReadLine();

                }

                if (player.Power == opponent.Power)
                {
                    Console.WriteLine("Tie Roll the Dice again");
                }

            }

            if (player.Health <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(player.Name + " : " + "Dead");
                Console.WriteLine(player.Name + " " + " killed by " + " " + opponent.Name);

                Arenabattle.Show_statistics();

            }

            if (opponent.Health <= 0)
            {

                Console.WriteLine(opponent.Name + " " + " is " + "Dead");
                Console.WriteLine("Enter 1 -  To Hunt for an Opponent:");
                Console.WriteLine("Enter 2 - To Retire from fighting:");
                String s = Console.ReadLine();
                Console.Clear();


                if (s == "2")
                {
                    Console.WriteLine("You decided to Retire ...");
                    Arenabattle.Score.Add(5);
                    Arenabattle.Victims.Add(opponent.name);
                    Arenabattle.Show_statistics();

                }

                if (s == "1")
                {
                    Arenabattle.Victims.Add(opponent.name);
                    Arenabattle.Score.Add(5);
                    Character opponent2 = new Character();
                    Console.WriteLine("Opponent: " + opponent2.name);
                    Console.WriteLine("Health: " + opponent2.health);
                    Console.WriteLine("Damage: " + opponent2.damage);
                    Console.WriteLine("power: " + opponent2.power);
                    Console.ReadKey();

                    Fight(player, opponent2, this.Arenabattle);
                }

            }

            Console.ReadKey();

            return 0;
        }





    }
}
