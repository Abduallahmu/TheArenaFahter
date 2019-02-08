using System;
using System.Collections.Generic;
using System.Text;

namespace TheArenaFighter
{
    class Battle
    {

        public Character sasuke;
        public Character boruto;

        public List<int> Score = new List<int>();
        public List<string> Victims = new List<string>();


        public void CheckHealth(Character uchiha, Character uzumaki)
        {

            sasuke = uchiha;
            boruto = uzumaki;

            Round Roun = new Round();

            Roun.Fight(sasuke, boruto, this);

        }

        public void Show_statistics()

        {
            int d = 0;
            int b = 0;
            string c = null;
           
            foreach (int sc in Score)
            {

                b = b + sc;

            }

            foreach (string st in Victims)
            {
                c = c + st;
                Console.WriteLine(sasuke.Name + " " + " Killed " + " " + c);
                d = d + 1;
            }
            Console.WriteLine(sasuke.Name + " " + "won" + " " + d + " " + "Games");
            Console.WriteLine("Score:" + b);

            Console.WriteLine("((((¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤))))");
            Console.WriteLine("Press Enter to exit:");

            Console.ReadKey();

        }

    }

}
