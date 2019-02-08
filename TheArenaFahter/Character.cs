using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheArenaFighter
{
    class Character
    {
        InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);
        public static Random rnd = new Random();
        public String name;
        public int health;
        public int power;
        public int damage;

        public Character()
        {
            this.name = infoGen.NextFullName();
            this.damage = rnd.Next(10, 15);
            this.health = rnd.Next(20, 30);
            this.power = rnd.Next(8, 14);
        }


        public Character(String name) : this()
        {

            this.name = name;

        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }





    }
}