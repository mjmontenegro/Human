using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human John = new Human("John");
            Human Howard = new Human("Howard");
            System.Console.WriteLine(Howard.Attack(John));
            
        }
    
    }
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int HealthProp {
            get
            {
                return health;
            }
        }
        public Human( string Name)
        {
            this.Name = Name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 1000;
        }
        public Human( string Name, int Strength, int Intelligence, int Dexterity, int health) {
            this.Name = Name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
            this.Dexterity = Dexterity;
            this.health = health;
        }
        public int Attack( Human target )
        {
            target.health = target.health - ( 5 * Strength );
            return target.health;
        }
    }
}
